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
    public partial class AgregarColorTallaEdit : BaseContext
    {
        private List<DetalleColorTalla> _colortallalistalocal = null;
        private List<DetalleColorTalla> _detalleColorTallas = null;
        private List<DetalleColorTalla> _colortallalistaTemp = null;
        private List<DetalleColorTalla> listadgvtemp = null;
        private EditarProducto _productoEdit = null;
        private string tallaDetalle;
        public string colorDetalle;
        private int stockTosave;

        public AgregarColorTallaEdit(EditarProducto productoEdit, List<DetalleColorTalla> lista)
        {
            _productoEdit = productoEdit;
            _detalleColorTallas = lista;
            _colortallalistalocal = lista;
            _colortallalistaTemp = new List<DetalleColorTalla>();
            listadgvtemp = new List<DetalleColorTalla>();
            stockTosave = productoEdit.stockstockToValidar;
            InitializeComponent();

        }

        private void AgregarColorTallaEdit_Load(object sender, EventArgs e)
        {
            CargarTallasCombo();
            CargarComboColores();
            OcultarCombocolor();
            OcultarSubCombo();
            CargaDgv();
            ValidarCantidadCT(_colortallalistalocal);
        }

        private void limpiarDGV()
        {
            if (_detalleColorTallas.Count == 0)
            {
                dgvcolorestallas.DataSource = null;
            }
            else
            {
                _colortallalistalocal = _detalleColorTallas;
                CargaDgv();
                ValidarCantidadCT(_colortallalistalocal);
            }
        }

        private void CargaDgv()
        {
            BindingSource source = new BindingSource();
            source.DataSource = _colortallalistalocal;
            dgvcolorestallas.DataSource = typeof(List<>);
            dgvcolorestallas.DataSource = source;
            dgvcolorestallas.Columns[0].Visible = false;
            dgvcolorestallas.Columns[1].Visible = false;

            for (int i = 5; i <= 13; i++)
            {
                dgvcolorestallas.Columns[i].Visible = false;
            }
            //Ajustar el gridview al ancho del form
            dgvcolorestallas.AutoResizeColumns();
            dgvcolorestallas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void ValidarCantidadCT(List<DetalleColorTalla> lista)
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

        public void CargarTallasCombo()
        {
            List<String> tallaslitacombo = new List<string>();
            tallaslitacombo.Add("");
            tallaslitacombo.Add(" Extra Extra Grande (XXL)");
            tallaslitacombo.Add(" Extra Grande (XL)");
            tallaslitacombo.Add(" Grande (L)");
            tallaslitacombo.Add(" Mediana (M)");
            tallaslitacombo.Add(" Pequeño (S)");
            tallaslitacombo.Add(" Extra Pequeño (XS)");
            comboTallas.DataSource = tallaslitacombo;

        }

        public void CargarComboColores()
        {
            List<String> coloreslista = new List<string>();
            coloreslista.Add("");
            coloreslista.Add("Blanco");
            coloreslista.Add("Negro");
            coloreslista.Add("Azul");
            coloreslista.Add("Amarillo");
            coloreslista.Add("verde");
            coloreslista.Add("Rojo");
            cbcoloresba.DataSource = coloreslista;
        }
        private void OcultarCombocolor()
        {
            lbcolor.Visible = false;
            txtcolor.Visible = false;
            cbcoloresba.Visible = false;

        }
        private void OcultarSubCombo()
        {
            lbmedida.Visible = false;
            txtmedida.Visible = false;
            comboTallas.Visible = false;
        }
        public DetalleColorTalla TallasAndColor()
        {
            var producto = _productoEdit._producto;
            var listaColorTalla = new DetalleColorTalla()
            {
                ProductoId = producto.Id,
                Talla = tallaDetalle,
                Color = colorDetalle,
                Stock = int.Parse(txtcantidad.Text)
            };
            return listaColorTalla;
        }
        private void btnAgregarlista_Click(object sender, EventArgs e)
        {
            if (dgvcolorestallas.RowCount <= 0) { KryptonMessageBox.Show("No hay ninguna color añadido"); return; }
            if (stockTosave > 0)
            {
                KryptonMessageBox.Show("Debe de utilizar todo el Stock en los diferentes Tallas y Colores\n le faltan: "
                                        + stockTosave.ToString() + " para finalizar"); return;
            }
            
            DevolverList();
            _productoEdit._listaColorTallas = _colortallalistaTemp;
            _productoEdit._listaColorTallasDel = listadgvtemp;
            _productoEdit.StockNuevo.ReadOnly = true;
            Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (colorDetalle == "" || tallaDetalle == "")
            {
                KryptonMessageBox.Show("¡El campo talla y/o color estan vacios!"); return;
            }

            if (string.IsNullOrEmpty(txtcantidad.Text) || txtcantidad.Text == "0")
            {
                KryptonMessageBox.Show("¡Debe ingresar una cantidad valida!");
                return;
            }

            if (rbtallapersonaliz.Checked)
            {
                tallaDetalle = txtmedida.Text;
            }          

            var nuevoDetalle = TallasAndColor();
            if (comprobarTallaColor(nuevoDetalle))
            {
                KryptonMessageBox.Show("¡Talla ya ingresado!");
                return;
            }
            else
            {
                if (stockTosave >= nuevoDetalle.Stock)
                {
                    if (listadgvtemp.Count > 0)
                    {
                        var det = listadgvtemp.Where(x => x.Talla == nuevoDetalle.Talla && 
                                                          x.Color == nuevoDetalle.Color);

                        if (det.Count() > 0)
                        {
                            det.ElementAt(0).Stock = nuevoDetalle.Stock;
                            stockTosave -= nuevoDetalle.Stock;
                            _colortallalistalocal.Add(det.ElementAt(0));
                            listadgvtemp.Remove(det.ElementAt(0));
                            CargaDgv();
                        }
                        else
                        {
                            stockTosave -= nuevoDetalle.Stock;
                            _colortallalistalocal.Add(nuevoDetalle);
                            CargaDgv();
                        }
                    }
                    else
                    {
                        stockTosave -= nuevoDetalle.Stock;
                        _colortallalistalocal.Add(nuevoDetalle);
                        CargaDgv();
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
             

        private void Limpiartxt()
        {
            txtcantidad.Text = "0";
            //tallaDetalle = "";
            txtcolor.Text = "";
            txtmedida.Text = "";
        }
        public bool comprobarTallaColor(DetalleColorTalla ColorTallatoAdd)
        {
            //modificar celda para tomar la talla
            foreach (DataGridViewRow row in dgvcolorestallas.Rows)
            {
                if (row.Cells[3].Value.ToString() == ColorTallatoAdd.Color && row.Cells[4].Value.ToString() == ColorTallatoAdd.Talla)
                {
                    return true;
                }
            }

            return false;
        }

        private void rbcomboTallas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcomboTallas.Checked)
            {

                lbmedida.Visible = false;
                txtmedida.Visible = false;
                tallaDetalle = comboTallas.Text;
                comboTallas.Visible = true;
            }
        }

        private void rbtallapersonaliz_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtallapersonaliz.Checked)
            {
                lbmedida.Visible = true;
                txtmedida.Visible = true;
                tallaDetalle = txtmedida.Text;
                comboTallas.Visible = false;
            }
            else
            {
                lbmedida.Visible = false;
                txtmedida.Visible = false;

            }

        }

        private void rbcolorespersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcolorespersonal.Checked)
            {
                lbcolor.Visible = true;
                txtcolor.Visible = true;
                colorDetalle = txtcolor.Text;
            }
            else
            {
                lbcolor.Visible = false;
                txtcolor.Visible = false;
            }
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

        private void comboTallas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tallaDetalle = comboTallas.SelectedItem.ToString();
        }

        private void cbcoloresba_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorDetalle = cbcoloresba.SelectedItem.ToString();
        }

        private void AgregarColorTalla_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_colortallalistalocal = _productoEdit._listaColorTallas;
            //_coloresProductos = _EditarProducto._listacolores;
            //if (listadgvtemp != null)
            //{
            //    listadgvtemp.ForEach(item => _EditarProducto._listacolores.Add(item));

            //}
            //_productoEdit.checkcolorytalla.Checked = false;
            _productoEdit.mostrarDetalle = true;

        }

        private void dgvcolorestallas_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var filaeliminada = dgvcolorestallas.CurrentRow;
            var filaActualEliminada = (DetalleColorTalla)dgvcolorestallas.CurrentRow.DataBoundItem;
            listadgvtemp.Add(filaActualEliminada);
            stockTosave += (int)filaeliminada.Cells[2].Value;
        }

        private void DevolverList()
        {
            DetalleColorTalla dtc = null;

            foreach (DataGridViewRow dc in dgvcolorestallas.Rows)
            {
                dtc = new DetalleColorTalla();
                dtc.Id = (int)dc.Cells[0].Value;
                dtc.ProductoId = (int)dc.Cells[1].Value;
                dtc.Stock = (int)dc.Cells[2].Value;
                dtc.Color = (string)dc.Cells[3].Value;
                dtc.Talla = (string)dc.Cells[4].Value;
                _colortallalistaTemp.Add(dtc);
            }

        }

        private void txtmedida_TextChanged(object sender, EventArgs e)
        {
            tallaDetalle = txtmedida.Text;
        }

        private void txtcolor_TextChanged(object sender, EventArgs e)
        {
            colorDetalle = txtcolor.Text;
        }
    }
}
