using CapaDatos.Models.Productos;
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

namespace Sistema.Forms.modulo_producto
{
    public partial class AgregarEstiloEdit : BaseContext
    {
        private List<DetalleEstilo> _listadgvtemp = null;
        private List<DetalleEstilo> _estilosProductos = null;
        private List<DetalleEstilo> _estiloslistalocal = null;
        private List<DetalleEstilo> _listaTemporal = null;
        private EditarProducto _editarProducto = null;
        public string EstiloDetalle;
        private int stockTosave;

        public AgregarEstiloEdit(EditarProducto editarProducto, List<DetalleEstilo> lista)
        {
            stockTosave = editarProducto.stockstockToValidar;
            _estiloslistalocal = new List<DetalleEstilo>();
            _listadgvtemp = new List<DetalleEstilo>();
            _editarProducto = editarProducto;
            _estilosProductos = lista;
            InitializeComponent();
        }

        private void AgregarEstiloEdit_Load(object sender, EventArgs e)
        {
            CargarCombo();
            OcultarSubCombo();
            limpiarDGV();
        }

        public void CargarCombo()
        {
            List<String> lista = new List<string>();
            lista.Add("Hombre");
            lista.Add("Mujer");
            lista.Add("Niño");
            lista.Add("Niña");
            lista.Add("Matrimonio");
            lista.Add("Cumpleaños");
            CbEstilos.DataSource = lista;
        }

        private void OcultarSubCombo()
        {
            lbEstilo.Visible = false;
            TxtEstilo.Visible = false;
            CbEstilos.Visible = false;
        }

        private void limpiarDGV()
        {
            if (_estilosProductos.Count == 0)
            {
                DgvEstilos.DataSource = null;
            }
            else
            {
                _estiloslistalocal = _estilosProductos;
                CargaDgv(_estiloslistalocal);
                ValidarCantidad(_estiloslistalocal);
            }
        }

        private void CargaDgv(List<DetalleEstilo> lista)
        {
            BindingSource source = new BindingSource();
            source.DataSource = lista;
            DgvEstilos.DataSource = typeof(List<>);
            DgvEstilos.DataSource = source;
            DgvEstilos.AutoResizeColumns();
            DgvEstilos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ValidarCantidad(List<DetalleEstilo> lista)
        {
            if (lista != null)
            {
                var totalcolores = 0;
                foreach (var item in lista)
                {
                    totalcolores += item.Stock;
                }
                stockTosave -= totalcolores;
            }
        }

        private void Limpiartxt()
        {
            TxtCantidad.Text = "0";
            TxtEstilo.Text = "";
        }

        private void RbListado_CheckedChanged(object sender, EventArgs e)
        {
            if (RbListado.Checked)
            {
                lbEstilo.Visible = false;
                TxtEstilo.Visible = false;
                CbEstilos.Visible = true;
            }
        }

        private void CbEstilos_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstiloDetalle = CbEstilos.SelectedItem.ToString();
        }

        private void RbPersonalizado_CheckedChanged(object sender, EventArgs e)
        {
            if (RbPersonalizado.Checked)
            {
                lbEstilo.Visible = true;
                TxtEstilo.Visible = true;
                CbEstilos.Visible = false;
                EstiloDetalle = TxtEstilo.Text;
            }
            else
            {
                lbEstilo.Visible = false;
                TxtEstilo.Visible = false;
                CbEstilos.Visible = true;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCantidad.Text) || TxtCantidad.Text == "0")
            {
                KryptonMessageBox.Show("¡Debe ingresar una cantidad valida!");
                return;
            }
            if (RbPersonalizado.Checked) { EstiloDetalle = TxtEstilo.Text; }
            var nuevoDetalle = Estilo();

            if (comprobarEstilo(nuevoDetalle))
            {
                KryptonMessageBox.Show("¡Estilo ya ingresado!");
                return;
            }
            else
            {
                if (stockTosave >= nuevoDetalle.Stock)//cantidad
                {
                    if (_listadgvtemp.Count > 0)
                    {
                        var det = _listadgvtemp.Where(x => x.Estilo == nuevoDetalle.Estilo);
                        if (det.Count() > 0)
                        {
                            det.ElementAt(0).Stock = nuevoDetalle.Stock;
                            stockTosave -= nuevoDetalle.Stock;
                            _estiloslistalocal.Add(det.ElementAt(0));
                            _listadgvtemp.Remove(det.ElementAt(0));
                            CargaDgv(_estiloslistalocal);
                        }
                        else
                        {
                            stockTosave -= nuevoDetalle.Stock;
                            _estiloslistalocal.Add(nuevoDetalle);
                            CargaDgv(_estiloslistalocal);
                        }
                    }
                    else
                    {
                        stockTosave -= nuevoDetalle.Stock;
                        _estiloslistalocal.Add(nuevoDetalle);
                        CargaDgv(_estiloslistalocal);
                    }
                    Limpiartxt();
                }
                else
                {
                    KryptonMessageBox.Show("¡Cantidad mayor al Stock Ingresado!");
                    return;
                }
            }
        }

        public DetalleEstilo Estilo()
        {
            var Producto = _editarProducto._producto;
            var estilo = new DetalleEstilo()
            {
                Estilo = EstiloDetalle,
                ProductoId = Producto.Id,
                Stock = int.Parse(TxtCantidad.Text)
            };
            return estilo;
        }

        public bool comprobarEstilo(DetalleEstilo estilo)
        {
            foreach (DataGridViewRow row in DgvEstilos.Rows)
            {
                if (row.Cells[3].Value.ToString() == estilo.Estilo)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAgregarlista_Click(object sender, EventArgs e)
        {
            if (DgvEstilos.RowCount <= 0) { KryptonMessageBox.Show("No hay ningún diseño añadido"); return; }
            if (stockTosave > 0)
            {
                KryptonMessageBox.Show("Debe de utilizar todo el Stock en los diferentes estilos\n le faltan: " + stockTosave.ToString() + " para finalizar"); 
                return;
            }
            DevolverList();
            _editarProducto._listaEstilosProd = _listaTemporal;
            _editarProducto._listaEstilosDel = _listadgvtemp;
            _editarProducto._detalleEstilos = _listaTemporal;
            _editarProducto.StockNuevo.ReadOnly = true;
            Close();
        }

        private void DevolverList()
        {
            _listaTemporal = new List<DetalleEstilo>();
            foreach (DataGridViewRow detail in DgvEstilos.Rows)
            {
                DetalleEstilo estilo = (DetalleEstilo)detail.DataBoundItem;
                _listaTemporal.Add(estilo);
            }

        }

        private void DgvEstilos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var filaeliminada = DgvEstilos.CurrentRow;
            var filaActualEliminada = (DetalleEstilo)DgvEstilos.CurrentRow.DataBoundItem;
            _listadgvtemp.Add(filaActualEliminada);
            stockTosave += (int)filaeliminada.Cells[2].Value;
        }

        private void AgregarEstiloEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            _editarProducto.mostrarDetalle = true;
        }
    }
}
