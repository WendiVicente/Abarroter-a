using CapaDatos.ListasPersonalizadas;
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

namespace POS.Forms
{
    public partial class ItemLista : BaseContext
    {
        public ItemLista()
        {
            InitializeComponent();
        }

        public TableLayoutPanel listadoImagen(List<ListarProductos> listado)
        {
            List<TableLayoutPanel> _listado = new List<TableLayoutPanel>();
            //PictureBox imagen = (PictureBox)tblItem.Controls[0].Controls[0];
            //var ControlsTableProd = tblItem.Controls[0].Controls[1];
            //Label nombreprod = (Label)ControlsTableProd.Controls[6];
            //var ContorlsTablePrecios = ControlsTableProd.Controls[4];
            //Label Stock = (Label)ContorlsTablePrecios.Controls[3];
            //Label pVenta = (Label)ContorlsTablePrecios.Controls[4];
            //Label codigo = (Label)ContorlsTablePrecios.Controls[5];
            int i = 0;
            foreach (ListarProductos prod in listado)
            {
                TableLayoutPanel tab = new TableLayoutPanel();
                if (prod.Imagen != null)
                {
                    byte[] imageData = prod.Imagen;
                    MemoryStream mStream = new MemoryStream(imageData);
                    pbProducto.Image = Image.FromStream(mStream);

                }
                lbExistencias.Text = prod.Stock.ToString();
                lbPrecioVenta.Text = "Q " + prod.PrecioVenta.ToString();
                lbCodigo.Text = prod.CodigoReferencia;
                lbNombreProducto.Text = prod.Descripcion.ToString();

                tab.Controls.Add(tblItem, 0, i);
                i++;
            }

            return tblItem;
            
        }
    }
}
