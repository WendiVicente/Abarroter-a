using CapaDatos.Models.Productos;
using CapaDatos.Repository;
using CapaDatos.Validation;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Forms.modulo_recargas
{
    public partial class EditarRecargas : BaseContext
    {
        private readonly ProductosRepository _productosRepository = null;
        private readonly ProveedoresRepository _proveedoresRepository = null;
        private readonly RecargasRepository _recargasRepository = null;

        private string Empresa = "";
        private Recarga _recarga = null;
        private ListadoRecargas _listadoRecargas = null;
        private bool Edicion = false;

        public EditarRecargas()
        {
            _productosRepository = new ProductosRepository(_context);
            _proveedoresRepository = new ProveedoresRepository(_context);
            _recargasRepository = new RecargasRepository(_context);
            InitializeComponent();
        }        

        public EditarRecargas(Recarga rec, ListadoRecargas listado, bool edit)
        {
            Edicion = edit;
            _recarga = rec;
            _listadoRecargas = listado;
            _productosRepository = new ProductosRepository(_context);
            _proveedoresRepository = new ProveedoresRepository(_context);
            _recargasRepository = new RecargasRepository(_context);
            InitializeComponent();
        }

        private void EditarRecargas_Load(object sender, EventArgs e)
        {
            Cargarproveedores();
            CargarCategorias();
            CargarTipos();
            CargarTextBox();
        }        

        private void CargarCategorias()
        {
            CbCategoria.DataSource = _productosRepository.GetCategoriasList();
            CbCategoria.DisplayMember = "Nombre";
            CbCategoria.ValueMember = "Id";
            CbCategoria.Invalidate();
        }

        private void Cargarproveedores()
        {
            try
            {
                cbproveedor.DataSource = _proveedoresRepository.GetList();
                cbproveedor.DisplayMember = "Nombre";
                cbproveedor.ValueMember = "Id";
                cbproveedor.Invalidate();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("no hay ningun proveedor,deberá ingresar uno", ex.Message);
            }

        }

        private void CargarTipos()
        {
            List<String> lista = new List<string>();
            lista.Add("Internet");
            lista.Add("Llamadas");
            lista.Add("Apps Ilimitadas");
            CbTipo.DataSource = lista;
        }

        private void CargarTextBox()
        {
            if (Edicion)
            {
                try
                {
                    cbproveedor.SelectedValue = _recarga.ProveedorId;
                    CbTipo.Text = _recarga.Tipo;
                    CbCategoria.SelectedValue = _recarga.CategoriaId;
                    if (_recarga.Empresa == "TIGO")
                    {
                        RbTigo.Checked = true;
                    }
                    else if (_recarga.Empresa == "CLARO")
                    {
                        RbClaro.Checked = true;
                    }
                    TxtVigencia.Text = _recarga.Vigencia;
                    TxtNomProducto.Text = _recarga.Descripcion;
                    TxtDescripcionCorta.Text = _recarga.DescripcionCorta;
                    TxtCodigoReferecia.Text = _recarga.CodigoBarras;
                    TxtPrecioVenta.Text = _recarga.PrecioVenta.ToString();
                }
                catch (Exception ex)
                {
                    KryptonMessageBox.Show(ex.Message);
                }
            }
        }

        private Recarga GetViewModel()
        {
            if (!Edicion)
            {
                return new Recarga
                {
                    CategoriaId = Convert.ToInt32(CbCategoria.SelectedValue.ToString()),
                    SucursalId = UsuarioLogeadoSistemas.User.SucursalId,
                    ProveedorId = Convert.ToInt32(cbproveedor.SelectedValue.ToString()),
                    Empresa = Empresa,
                    Tipo = CbTipo.Text,
                    CodigoBarras = TxtCodigoReferecia.Text,
                    Descripcion = TxtNomProducto.Text,
                    DescripcionCorta = TxtDescripcionCorta.Text,
                    Vigencia = TxtVigencia.Text,
                    PrecioVenta = TxtPrecioVenta.Text
                };
            }
            else
            {
                _recarga.CategoriaId = Convert.ToInt32(CbCategoria.SelectedValue.ToString());
                _recarga.SucursalId = UsuarioLogeadoSistemas.User.SucursalId;
                _recarga.ProveedorId = Convert.ToInt32(cbproveedor.SelectedValue.ToString());
                _recarga.Tipo = CbTipo.Text;
                _recarga.Empresa = Empresa;
                _recarga.CodigoBarras = TxtCodigoReferecia.Text;
                _recarga.Descripcion = TxtNomProducto.Text;
                _recarga.DescripcionCorta = TxtDescripcionCorta.Text;
                _recarga.Vigencia = TxtVigencia.Text;
                _recarga.PrecioVenta = TxtPrecioVenta.Text;
                return _recarga;
            }
                        
        }

        private bool ValidarCampos()
        {
            if (CbCategoria.SelectedValue == null)
            {
                KryptonMessageBox.Show("Debe seleccionar una Categoria", "Notificación");
                return false;
            }
            else
            if (cbproveedor.SelectedValue == null)
            {
                KryptonMessageBox.Show("Debe seleccionar un Proveedor", "Notificación");
                return false;
            }
            else
            if (string.IsNullOrEmpty(TxtNomProducto.Text))
            {
                KryptonMessageBox.Show("Debe ingresar una Descripcion", "Notificación");
                return false;
            }
            else
            if (RbTigo.Checked == false && RbClaro.Checked == false)
            {
                KryptonMessageBox.Show("Debe seleccionar una Compañía", "Notificación");
                return false;
            }
            if (!string.IsNullOrEmpty(TxtPrecioVenta.Text))
            {
                decimal compara = 0.00m;
                decimal preciov = Convert.ToDecimal(TxtPrecioVenta.Text);

                if (preciov <= compara)
                {
                    KryptonMessageBox.Show("Debe ingresar una cantidad válida en Precio Venta", "Notificación");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private void RbTigo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbTigo.Checked)
            {
                Empresa = "TIGO";
            }            
        }

        private void RbClaro_CheckedChanged(object sender, EventArgs e)
        {
            if(RbClaro.Checked)
            {
                Empresa = "CLARO";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    Recarga recarga = GetViewModel();
                    if (ModelState.IsValid(recarga))
                    {
                        if (!Edicion)
                        {
                            GuardarNuevo(recarga);
                        }
                        else
                        {
                            ActualizarRecarga(recarga);
                        }                        
                    }
                    else
                    {
                        KryptonMessageBox.Show("Datos ingresados inválidos.", "ERROR");
                    }
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Ha ocurrido un error interno con la información.", "ERROR");
            }
            
        }


        private void GuardarNuevo(Recarga recarga)
        {
            _recargasRepository.Add(recarga);
            
            this.Hide();
            EditarRecargas editarRecargas = new EditarRecargas();
            editarRecargas.MdiParent = this.MdiParent;
            editarRecargas.Show();
            this.Close();
        }
        
        private void ActualizarRecarga(Recarga recarga)
        {
            _recargasRepository.Update(recarga);
            KryptonMessageBox.Show("Cambios guardados Existosamente", "Notificación");
            _listadoRecargas.RefrescarDataGridProductos(true);
            Close();
        }
        
    }
}
