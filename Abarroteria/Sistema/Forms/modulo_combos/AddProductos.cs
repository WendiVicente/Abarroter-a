using CapaDatos.ListasPersonalizadas;
using CapaDatos.Repository;
using ComponentFactory.Krypton.Toolkit;
using POS.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Forms.modulo_combos
{
    public partial class AddProductos : BaseContext
    {
        private ProductosRepository _productosRepository = null;
        private readonly NuevoCombo _nuevoCombo = null;
        private ColoresRepository _coloresRepository = null;
       // public DbContextTransaction transaction = null;


        public AddProductos(NuevoCombo nuevoCombo)
        {
            _nuevoCombo = nuevoCombo;
            _productosRepository = new ProductosRepository(_context);
            _coloresRepository = new ColoresRepository(_context);
        //    transaction = _context.Database.BeginTransaction();
            InitializeComponent();
            CargarDgv();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddRowListaProductos();
            CargarDgv();
            //_nuevoCombo.ActualizarLabelTotal();
        }
        public void CargarDgv()
        {

            var recargarLista = _nuevoCombo.AccesoProductoRepository();

            ListadoProductosC.ListaDeProductos = recargarLista.GetList(UsuarioLogeadoSistemas.User.SucursalId);

            
            foreach (var item in ListadoProductosC.ListaDeProductos)
            {
                if(item.IncluyeColor == "Sí")
                {
                    var productoObtenerStock = _coloresRepository.GetColor(item.Id);
                    item.Stock = productoObtenerStock.Stock;
                }
                

            }

            BindingSource source = new BindingSource();
            source.DataSource = ListadoProductosC.ListaDeProductos;
            dgListaProductos.DataSource = typeof(List<>);
            dgListaProductos.DataSource = source;
            dgListaProductos.AutoResizeColumns();

        }
       
        public void AddRowListaProductos()
        {
            if (dgListaProductos.Rows.Count == 0) return;
            if (dgListaProductos.CurrentRow == null) return;


            var produc = (ListarProductos)dgListaProductos.CurrentRow.DataBoundItem;
            var producto = ListadoProductosC.GetProducto(produc.CodigoReferencia);
            var productoGet = _productosRepository.Get(producto.Id);
            
            if (producto == null) return;
            
            
           

            if (productoGet.TieneColor)
            {
                var detallecolor = _coloresRepository.GetColor(productoGet.Id);
                if (detallecolor.Stock > 0)
                {

                    detallecolor.Stock -= 1;
                     _coloresRepository.Update(detallecolor,true);
                    //transaction.Commit();
                }
                else { KryptonMessageBox.Show("El Producto Tiene Stock 0, no se puede agregar"); return; }
               
            }
            else
            {
                if (productoGet.Stock > 0)
                {

                    productoGet.Stock -= 1;
                    //  var prod = _productosRepository.Get(producto.Id);
                    _productosRepository.Update(productoGet, true);
                    
                }
                else
                {
                    KryptonMessageBox.Show("El Producto Tiene Stock 0, no se puede agregar"); return;
                }
                  
                //transaction.Commit();
            }
            




            // comprueba si el producto ya esta insertado en tabla.
         //   var comprobarEnTabla = new ComprobarExistenciaEnTabla(_nuevoCombo.ListaProductSelect);
           // _nuevoCombo.CargarDataGridView(producto, comprobarEnTabla.ComprobarProductoRepetidoFila(producto));

            //  _solicitudCompra.ActualizarLabels();
            txtbuscarP.Text = null;
        }

        private void AddProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnprueba_Click(object sender, EventArgs e)
        {
            //transaction.Commit()
        }

        private void txtbuscarP_TextChanged_1(object sender, EventArgs e)
        {
            var ProductoBuscado = ListadoProductosC.ListaDeProductos;

            var filter = ProductoBuscado.Where(a => a.Descripcion.Contains(txtbuscarP.Text) ||
            (a.CodigoReferencia != null && a.CodigoReferencia.Contains(txtbuscarP.Text)) ||
            (a.Categoria != null && a.Categoria.Contains(txtbuscarP.Text)) ||
            (a.Notas != null && a.Notas.Contains(txtbuscarP.Text)));
            dgListaProductos.DataSource = filter.ToList();

        }
    }
}
