using CapaDatos.Data;
using CapaDatos.ListasPersonalizadas;
using CapaDatos.Models.Productos.Combos;
using CapaDatos.Repository;
using CapaDatos.Validation;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Forms.modulo_combos
{
    public partial class EditarCombos : BaseContext
    {
        private CombosRepository _combosRepository = null;
        private VerCombos _vercomboform = null;
        private Combo _comboSet = null;
        public List<ComboDetalleLista> detalleListsObtenida = null;
        private int codDetalle = 0;
        private int comboidcol = 1;
        private int idproductocol = 2;
        private int descripcionCol = 4;
        private int cantidadcol = 5;
        //private int colorIdcol = 6;
        private int colordetailcol = 7;
        //private int tallaIdcol = 8;
        private int talladetailcol = 9;
        private ProductosRepository _productosRepository = null;
        byte[] filefoto = null;

        public EditarCombos(Combo comboget, VerCombos verCombos)
        {
            _productosRepository = new ProductosRepository(_context);
            _comboSet = comboget;
            _vercomboform = verCombos;
            InitializeComponent();
            cargarImg();
        }
        private void cargarImg()
        {
            if (_comboSet.Imagen == null) { return; }
            byte[] imageData = _comboSet.Imagen;
            MemoryStream mStream = new MemoryStream(imageData);
            pBox.Image = Image.FromStream(mStream);
        }
        public ProductosRepository AccesoProductoRepository()
        {
            _context = null;
            _context = new Context();
            _productosRepository = null;
            _productosRepository = new ProductosRepository(_context);
            //  _recepcionesRepository = new RecepcionesRepository(_context);

            return _productosRepository;
        }
        private void EditarCombos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarDg();
            //SetWidthDatagrid();
            ListaProductSelect.ClearSelection();
        }

        private void CargarDatos()
        {
            txtcosto.Text = _comboSet.PrecioCompra.ToString();
            txtdescripcion.Text= _comboSet.Descripcion;
            txtpreciocuentaclave.Text = _comboSet.PrecioCuentaClave.ToString();
            txtprecioentidad.Text = _comboSet.PrecioEntidadGubernamental.ToString();
            txtpreciomayorista.Text = _comboSet.PrecioMayorista.ToString();
            txtprecioventa.Text = _comboSet.Precioventa.ToString();
            txtrevendedor.Text = _comboSet.PrecioRevendedor.ToString();
            txtstock.Text = _comboSet.Stock.ToString();

        }

        public void CargarDg(bool loadNewContext = true)
        {

            if (loadNewContext)
            {
                _context = null;
                _context = new Context();
                _combosRepository = null;
                _combosRepository = new CombosRepository(_context);
            }

            BindingSource source = new BindingSource();
            detalleListsObtenida = _combosRepository.GetListDetalleCombo(_comboSet.Id);
            source.DataSource = detalleListsObtenida;
            ListaProductSelect.DataSource = typeof(List<>);
            ListaProductSelect.DataSource = source;
            ListaProductSelect.AutoResizeColumns();
            //ListaProductSelect.Columns[codDetalle].Visible = false;
            //ListaProductSelect.Columns[comboidcol].Visible = false;
            //ListaProductSelect.Columns[2].Visible = false;
            //ListaProductSelect.Columns[6].Visible = false;
            //ListaProductSelect.Columns[8].Visible = false;       

            //SetWidthDatagrid();
        }

        public void CargarAddProductos()
        {
            BindingSource source = new BindingSource();
            source.DataSource = detalleListsObtenida;
            ListaProductSelect.DataSource = typeof(List<>);
            ListaProductSelect.DataSource = source;
            ListaProductSelect.AutoResizeColumns();
            ListaProductSelect.Columns[codDetalle].Visible = false;
            ListaProductSelect.Columns[comboidcol].Visible = false;
            ListaProductSelect.Columns[2].Visible = false;
            ListaProductSelect.Columns[6].Visible = false;
            ListaProductSelect.Columns[8].Visible = false;
            //SetWidthDatagrid();
            ListaProductSelect.ClearSelection();
        }

        public Combo GetComboModel(Combo combo)
        {
            combo.Descripcion = txtdescripcion.Text;
            combo.PrecioCompra = decimal.Parse(txtcosto.Text);
            combo.PrecioCuentaClave = decimal.Parse(txtpreciocuentaclave.Text);
            combo.PrecioEntidadGubernamental = decimal.Parse(txtprecioentidad.Text);
            combo.PrecioMayorista = decimal.Parse(txtpreciomayorista.Text);
            combo.PrecioRevendedor = decimal.Parse(txtrevendedor.Text);
            combo.Precioventa = decimal.Parse(txtprecioventa.Text);
            combo.Stock = int.Parse(txtstock.Text);
            combo.Imagen = filefoto;
            combo.FechaMovimiento = DateTime.Now;
            return combo;
        }

        private void ActualizarCambios()
        {
            var editarCombo = _combosRepository.Get(_comboSet.Id);
            var encabezadoCompra = GetComboModel(editarCombo); // encabezado
            if (!ModelState.IsValid(encabezadoCompra)) { return; }

            ActualizarDetalles();
            _combosRepository.Update(encabezadoCompra);
            _vercomboform.RefrescarDataGridProductos(true);

            KryptonMessageBox.Show("Registro actualizado correctamente");

            Close();
        }

        private void ActualizarDetalles()
        {
            foreach (DataGridViewRow item in ListaProductSelect.Rows)
            {
                if (item == null)
                {
                    continue;
                }

                if (_combosRepository.Getdetalle(int.Parse(item.Cells[codDetalle].Value.ToString())) != null)
                {

                    var detallecombos = _combosRepository.Getdetalle(int.Parse(item.Cells[codDetalle].Value.ToString()));
                    detallecombos.Referencia = item.Cells[idproductocol].Value.ToString();
                    detallecombos.Descripcion = item.Cells[descripcionCol].Value.ToString();
                    detallecombos.Cantidad = int.Parse(item.Cells[cantidadcol].Value.ToString());
                    _combosRepository.UpdateDetalleCombo(detallecombos, true);

                }
                else
                {
                    DetalleCombo nuevodetalle = new DetalleCombo()
                    {
                        ComboId = _comboSet.Id,
                        Referencia = item.Cells[idproductocol].Value.ToString(),
                        Descripcion= item.Cells[descripcionCol].Value.ToString(),
                        Cantidad = int.Parse(item.Cells[cantidadcol].Value.ToString()),
                    };
                    _combosRepository.AddDetalle(nuevodetalle);

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProductosEditar childForm = new AddProductosEditar(this);
            childForm.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarCambios();
        }

        private void SetWidthDatagrid()
        {
            DataGridViewColumn colDescripcion = ListaProductSelect.Columns[descripcionCol];
            DataGridViewColumn colReferencia = ListaProductSelect.Columns[idproductocol];
            DataGridViewColumn colCantidad = ListaProductSelect.Columns[cantidadcol];
            DataGridViewColumn colColor = ListaProductSelect.Columns[colordetailcol];
            DataGridViewColumn colTalla = ListaProductSelect.Columns[talladetailcol];

            colDescripcion.Width = 310;
            colCantidad.Width = 100;
            colReferencia.Width = 150;
            colColor.Width = 100;
            colTalla.Width = 100;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            eliminarFila();            
        }

        private void eliminarFila()
        {
            if (ListaProductSelect.CurrentRow == null)
            {
                KryptonMessageBox.Show("No tiene ningun producto seleccionado");
                return;
            }

            var dialog = KryptonMessageBox.Show("¿Éste Producto sera Eliminado permanentemente del combo,Desea continuar?", "Eliminar producto",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2);

            if (dialog == DialogResult.Yes)
            {
                var rowSeleccionada = (ComboDetalleLista)ListaProductSelect.CurrentRow.DataBoundItem;
                var codigoFila = rowSeleccionada.Id;
                if (codigoFila != 0)
                {
                    detalleListsObtenida.RemoveAll(x => x.Id == codigoFila);
                    _combosRepository.DeleteProductoDetalle(_combosRepository.Getdetalle(codigoFila));
                }
                else
                {
                    detalleListsObtenida.RemoveAll(x => x.Id == codigoFila);
                }

                CargarAddProductos();
            }
        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtpreciomayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtpreciocuentaclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtrevendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

       

        private void txtprecioentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.Filter = "Archivos JPG (*.jpg)|*.jpg| Archivos png(*.png)|*.png";
            DialogResult filestream = imagen.ShowDialog();

            if (filestream == DialogResult.OK)
            {
                pBox.Image = Image.FromFile(imagen.FileName);
                filestreamImagen();
            }
        }

        private void filestreamImagen()
        {
            filefoto = null;
            MemoryStream memoryStream = new MemoryStream();
            pBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            memoryStream.GetBuffer();
            filefoto = memoryStream.GetBuffer();

        }
    }
}
