using CapaDatos.Models.Productos;
using ComponentFactory.Krypton.Toolkit;
using sharedDatabase.Models;
using Sistema.Forms.Extras;
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
    public partial class AgregarColorEdit : BaseContext
    {
        private EditarProducto _EditarProducto = null;
        private List<DetalleColor> _coloresProductos = null;
        private List<DetalleColor> _coloreslistalocal = null;
        private List<DetalleColor> _listaTemporal = new List<DetalleColor>();
        private List<DetalleColor> listadgvtemp = new List<DetalleColor>();
        public string colorDetalle;
        private int stockTosave;

        public AgregarColorEdit(EditarProducto ditarProducto, List<DetalleColor> lista)
        {
            _EditarProducto = ditarProducto;
            _coloreslistalocal = new List<DetalleColor>();
            _coloresProductos = lista;
            stockTosave = _EditarProducto.stockstockToValidar;
            listadgvtemp = new List<DetalleColor>();
            InitializeComponent();
        }

        private void AgregarColor_Load(object sender, EventArgs e)
        {      
            CargarComboColores();
            OcultarSubCombo();
            cargarListaColoresSaves();
            limpiarDGV();
        }

        private void limpiarDGV()
        {
            if (_coloresProductos.Count == 0)
            {
                dgvColoresadd.DataSource = null;
            }
            else
            {
                _coloreslistalocal = _coloresProductos;
                CargaDgv(_coloreslistalocal);
                ValidarCantidadColores(_coloreslistalocal);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidadColores.Text) || txtCantidadColores.Text == "0")
            {
                KryptonMessageBox.Show("¡Debe ingresar una cantidad valida!");
                return;
            }
            if (rbcolorespersonal.Checked) { colorDetalle = txtColor.Text; }
            var nuevoDetalle = Colores();

            if (comprobarColor(nuevoDetalle))
            {
                KryptonMessageBox.Show("¡Color ya ingresado!");
                return;
            }
            else
            {
                if (stockTosave >= nuevoDetalle.Stock)//cantidad)
                {
                    
                    if (listadgvtemp.Count > 0)
                    {
                        var det = listadgvtemp.Where(x => x.Color == nuevoDetalle.Color);
                        if (det.Count() > 0)
                        {
                            det.ElementAt(0).Stock = nuevoDetalle.Stock;
                            stockTosave -= nuevoDetalle.Stock;
                            _coloreslistalocal.Add(det.ElementAt(0));
                            listadgvtemp.Remove(det.ElementAt(0));
                            CargaDgv(_coloreslistalocal);
                        }
                        else
                        {
                            stockTosave -= nuevoDetalle.Stock;
                            _coloreslistalocal.Add(nuevoDetalle);
                            CargaDgv(_coloreslistalocal);
                        } 
                    }
                    else
                    {
                        stockTosave -= nuevoDetalle.Stock;
                        _coloreslistalocal.Add(nuevoDetalle);
                        CargaDgv(_coloreslistalocal);
                    }
                    Limpiartxt();
                }
                else
                {
                    KryptonMessageBox.Show("¡Cantidad mayor al Stock Ingresado !");
                    return;
                }
            }   
        }

        public DetalleColor Colores()
        {

            var Producto = _EditarProducto._producto;
            var listacolores = new DetalleColor()
            {
                //ColorDescripcion = colorDetalle,
                //cantidad = int.Parse(txtCantidadColores.Text)
                Color = colorDetalle,
                ProductoId = Producto.Id,
                PrecioMayorista = Producto.PrecioMayorista,
                PrecioEntidadGubernamental= Producto.PrecioEntidadGubernamental,
                PrecioCuentaClave = Producto.PrecioCuentaClave,
                PrecioRevendedor = Producto.PrecioRevendedor,
                Stock = int.Parse(txtCantidadColores.Text)
            };
              

        return listacolores;
        }

        private void CargaDgv(List<DetalleColor> listacoloresAc)
        {
            BindingSource source = new BindingSource();
            source.DataSource = listacoloresAc;
            dgvColoresadd.DataSource = typeof(List<>);
            dgvColoresadd.DataSource = source;
            dgvColoresadd.Columns[0].Visible = false;
            for (int i = 4; i <= 18; i++)
            {
                dgvColoresadd.Columns[i].Visible = false;
            }
            dgvColoresadd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cargarListaColoresSaves()
        {/*
            if (_coloresProductos != null)
            {
                CargaDgv();
            }
            */
        }

        private void Limpiartxt()
        {
            txtCantidadColores.Text = "0";
          // ColorDetalle = "";
        }
       
        private void rbcolorespaleta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcolorespaleta.Checked)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string colorName;
                    if (dialog.Color.IsKnownColor)
                        colorName = dialog.Color.ToKnownColor().ToString();
                    else if (dialog.Color.IsNamedColor)
                        colorName = dialog.Color.Name;
                    else
                        colorName = dialog.Color.ToString();
                    //   MessageBox.Show(colorName);
                    colorDetalle = colorName;
                    btPaleta.BackColor = dialog.Color;
                    btPaleta.Visible = true;
                }

            }
            else
            {
                btPaleta.Visible = false;
                // paleta.ShowDialog();
            }
        }

        private void rbcolorespersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcolorespersonal.Checked)
            {
                lbColor.Visible = true;
                txtColor.Visible = true;
                colorDetalle = txtColor.Text;
            }
            else
            {
                lbColor.Visible = false;
                txtColor.Visible = false;
            }
        }

        private void rblistacolores_CheckedChanged(object sender, EventArgs e)
        {
            if (rblistacolores.Checked)
            {
                cbcoloresba.Visible = true;
                colorDetalle = cbcoloresba.SelectedItem.ToString();
            }
            else
            {
                cbcoloresba.Visible = false;
            }
        }

        public void CargarComboColores()
        {
            List<String> coloreslista = new List<string>();
            coloreslista.Add("Blanco");
            coloreslista.Add("Negro");
            coloreslista.Add("Azul");
            coloreslista.Add("Amarillo");
            coloreslista.Add("verde");
            coloreslista.Add("Rojo");
            cbcoloresba.DataSource = coloreslista; 
        }

        private void OcultarSubCombo()
        {
            lbColor.Visible = false;
            txtColor.Visible = false;
            cbcoloresba.Visible = false;
        }

        private void cbcoloresba_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorDetalle = cbcoloresba.SelectedItem.ToString();
        }

        private void btnAgregarlista_Click(object sender, EventArgs e)
        {
            if (dgvColoresadd.RowCount <= 0) { KryptonMessageBox.Show("No hay ninguna color añadido"); return; }
            if (stockTosave > 0)
            {
                KryptonMessageBox.Show("Debe de utilizar todo el Stock en los diferentes Colores\n le faltan: "
                                        + stockTosave.ToString() + " para finalizar"); return;
            }
            DevolverList();            
            _EditarProducto._listacoloresProd = _listaTemporal;
            _EditarProducto._listacoloresDel = listadgvtemp;
            _EditarProducto.StockNuevo.ReadOnly = true;
            Close();
        }   
      
        public bool comprobarColor(DetalleColor colortoAdd)
        {
            foreach (DataGridViewRow row in dgvColoresadd.Rows)
            {
                if (row.Cells[3].Value.ToString() == colortoAdd.Color)//ColorDescripcion)
                {
                    return true;
                }
            }

            return false;
        }

        private void AgregarColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_coloreslistalocal = _EditarProducto._listacolores;
            //_coloresProductos = _EditarProducto._listacolores;
            //if (listadgvtemp != null)
            //{
            //    listadgvtemp.ForEach(item => _EditarProducto._listacolores.Add(item));

            //}
            //_EditarProducto.checkColor.Checked = false;
            // Close();
            _EditarProducto.mostrarDetalle = true;
        }

        private void dgvColoresadd_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
          //  KryptonMessageBox.Show("Este color se eliminara permanentemente");
            var filaeliminada = dgvColoresadd.CurrentRow;
            var filaActualEliminada = (DetalleColor)dgvColoresadd.CurrentRow.DataBoundItem;
            listadgvtemp.Add(filaActualEliminada);
            stockTosave += (int)filaeliminada.Cells[2].Value;
        }

        private void ValidarCantidadColores(List<DetalleColor> lista)
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


        private void DevolverList()
        {
            DetalleColor dt = null; 
        
            foreach (DataGridViewRow dc in dgvColoresadd.Rows)
            {
                dt = new DetalleColor();
                dt.Id = (int)dc.Cells[0].Value;
                dt.ProductoId = (int)dc.Cells[1].Value;
                dt.Stock = (int)dc.Cells[2].Value;
                dt.Color = (string)dc.Cells[3].Value;
                dt.PrecioMayorista = (decimal)dc.Cells[5].Value;
                dt.PrecioRevendedor = (decimal)dc.Cells[7].Value;
                _listaTemporal.Add(dt);
            }
        
        }
               
    }
}
