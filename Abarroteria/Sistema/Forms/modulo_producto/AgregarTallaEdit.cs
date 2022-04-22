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
    public partial class AgregarTallaEdit : BaseContext
    {

        private EditarProducto _editarProducto = null;
        private List<DetalleTalla> _detalleTallas = null;
        private List<DetalleTalla> _tallaslistalocal = null;
        private List<DetalleTalla> _listaTemp = null;
        private List<DetalleTalla> listadgvtemp = new List<DetalleTalla>();
        private List<DetalleTalla> _listaTemporal = new List<DetalleTalla>();
        private string tallaDetalle;
        private int stockTosave;
        bool enabledDeleteperman = false;
        public AgregarTallaEdit(EditarProducto EditarProducto, List<DetalleTalla> lista)
        {
            _editarProducto = EditarProducto;
            _tallaslistalocal = new List<DetalleTalla>();
            _detalleTallas = lista;
            //_listaTemp = lista; 
            stockTosave = _editarProducto.stockstockToValidar;
            listadgvtemp = new List<DetalleTalla>();
            InitializeComponent();
        }


        private void AgregarTalla_Load(object sender, EventArgs e)
        {
            CargarTallasCombo();
            OcultarSubCombo();
            limpiarDGV();
        }

        private void limpiarDGV()
        {
            if (_detalleTallas.Count == 0)
            {
                dgvtallaslist.DataSource = null;
            }
            else
            {
                _tallaslistalocal = _detalleTallas;
                CargaDgv(_tallaslistalocal);
                ValidarCantidadTallas(_tallaslistalocal);
            }
        }

        public void CargarTallasCombo()
        {

            List<String> tallaslitacombo = new List<string>();
            tallaslitacombo.Add(" Extra Extra Grande (XXL)");
            tallaslitacombo.Add(" Extra Grande (XL)");
            tallaslitacombo.Add(" Grande (L)");
            tallaslitacombo.Add(" Mediana (M)");
            tallaslitacombo.Add(" Pequeño (S)");
            tallaslitacombo.Add(" Extra Pequeño (XS)");
            comboTallas.DataSource = tallaslitacombo;

        }

        private void OcultarSubCombo()
        {
            lbTalla.Visible = false;
            txtTalla.Visible = false;
            comboTallas.Visible = false;

        }


        private void CargaDgv(List<DetalleTalla> lista)
        {
            BindingSource source = new BindingSource();
            source.DataSource = lista;
            dgvtallaslist.DataSource = typeof(List<>);
            dgvtallaslist.DataSource = source;
            dgvtallaslist.Columns[0].Visible = false;
            dgvtallaslist.Columns[1].Visible = false;
            for (int i = 4; i <= 12; i++)
            {
                dgvtallaslist.Columns[i].Visible = false;
            }
            dgvtallaslist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public DetalleTalla Tallas()
        {
            var Producto = _editarProducto._producto;
            var listaTallas = new DetalleTalla()
            {
                Talla = tallaDetalle,
                ProductoId = Producto.Id,
                Stock = int.Parse(txtCantidadTallas.Text)
            };


            return listaTallas;
        }
        
        private void btnAgregarlista_Click(object sender, EventArgs e)
        {
            
            if (dgvtallaslist.RowCount <= 0) { KryptonMessageBox.Show("No hay ninguna Talla añadida"); return; }

            if (stockTosave > 0) { KryptonMessageBox.Show("Debe de utilizar todo el Stock en las diferentes tallas\n le faltan: "
                                                           + stockTosave.ToString() +" para finalizar"); return; }
            DevolverList();
            _editarProducto._listaTallasProd = _listaTemporal;
            _editarProducto._listaTallasDel = listadgvtemp;
            _editarProducto.StockNuevo.ReadOnly = true;
            enabledDeleteperman = true;
            Close();

        }

        private void Limpiartxt()
        {
            txtCantidadTallas.Text = "0";
            //tallaDetalle = "";
            txtTalla.Text = "";
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidadTallas.Text) || txtCantidadTallas.Text == "0")
            {
                KryptonMessageBox.Show("¡Debe ingresar una cantidad valida!");
                return;
            }
          

            if (rbtallapersonaliz.Checked) {
               
                tallaDetalle = txtTalla.Text; 
            }

            var nuevoDetalle = Tallas();
            if (comprobarTalla(nuevoDetalle))
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
                        var det = listadgvtemp.Where(x => x.Talla == nuevoDetalle.Talla);
                        if (det.Count() > 0)
                        {
                            det.ElementAt(0).Stock = nuevoDetalle.Stock;
                            stockTosave -= nuevoDetalle.Stock;
                            _tallaslistalocal.Add(det.ElementAt(0));
                            listadgvtemp.Remove(det.ElementAt(0));
                            CargaDgv(_tallaslistalocal);
                        }
                        else
                        {
                            stockTosave -= nuevoDetalle.Stock;
                            _tallaslistalocal.Add(nuevoDetalle);
                            CargaDgv(_tallaslistalocal);
                        }
                    }
                    else
                    {
                        stockTosave -= nuevoDetalle.Stock;
                        _tallaslistalocal.Add(nuevoDetalle);
                        CargaDgv(_tallaslistalocal);
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
        public bool comprobarTalla(DetalleTalla tallatoAdd)
        {
            foreach (DataGridViewRow row in dgvtallaslist.Rows)
            {
                if (row.Cells[3].Value.ToString() == tallatoAdd.Talla)
                {
                    return true;
                }
            }

            return false;
        }

        private void rblistatallas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcomboTallas.Checked)
            {

                lbTalla.Visible = false;
                txtTalla.Visible = false;
                tallaDetalle = comboTallas.Text;
                comboTallas.Visible = true;
            }
            else
            {
              

            }

        }

        private void rbtallapersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtallapersonaliz.Checked)
            {
                lbTalla.Visible = true;
                txtTalla.Visible = true;
                tallaDetalle = txtTalla.Text;
                comboTallas.Visible = false;
            }
            else
            {
                lbTalla.Visible = false;
                txtTalla.Visible = false;

            }
        }

        private void comboTallas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tallaDetalle = comboTallas.SelectedItem.ToString();
        }

        private void AgregarTalla_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_tallaslistalocal = _editarProducto._listaTallas;
            //_detalleTallas = _editarProducto._listaTallas;
            //if (listadgvtemp != null && enabledDeleteperman==false)
            //{
            //    listadgvtemp.ForEach(item => _editarProducto._listaTallas.Add(item));

            //}
            //_editarProducto.checktalla.Checked = false;
            _editarProducto.mostrarDetalle = true;
        }  
       
        private void dgvtallaslist_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var filaeliminada = dgvtallaslist.CurrentRow;
            var filaActualEliminada = (DetalleTalla)dgvtallaslist.CurrentRow.DataBoundItem;
            listadgvtemp.Add(filaActualEliminada);
            stockTosave += (int)filaeliminada.Cells[2].Value;
        }

        private void ValidarCantidadTallas(List<DetalleTalla> lista)
        {
            if (lista != null)
            {
                var totaltallas = 0;
                foreach (var item in lista)
                {
                    totaltallas += item.Stock;
                }
                stockTosave -= totaltallas;
            }
        }

        private void DevolverList()
        {
            DetalleTalla dt = null;

            foreach (DataGridViewRow dc in dgvtallaslist.Rows)
            {
                dt = new DetalleTalla();
                dt.Id = (int)dc.Cells[0].Value;
                dt.ProductoId = (int)dc.Cells[1].Value;
                dt.Stock = (int)dc.Cells[2].Value;
                dt.Talla = (string)dc.Cells[3].Value;
                _listaTemporal.Add(dt);
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
