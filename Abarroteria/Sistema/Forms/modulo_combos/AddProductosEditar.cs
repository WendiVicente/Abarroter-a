using CapaDatos.ListasPersonalizadas;
using CapaDatos.Repository;
using ComponentFactory.Krypton.Toolkit;
using POS.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Forms.modulo_combos
{
    public partial class AddProductosEditar : BaseContext
    {
        private ProductosRepository _productosRepository = null;
        private readonly EditarCombos _editarCombo = null;
        private ColoresRepository _coloresRepository = null;
        public AddProductosEditar(EditarCombos editCombo)
        {
            _editarCombo = editCombo;
            _productosRepository = new ProductosRepository(_context);
            _coloresRepository = new ColoresRepository(_context);
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

            var recargarLista = _editarCombo.AccesoProductoRepository();

            ListadoProductosC.ListaDeProductos = recargarLista.GetList(UsuarioLogeadoSistemas.User.SucursalId);

            BindingSource source = new BindingSource();
            source.DataSource = ListadoProductosC.ListaDeProductos;
            dgListaProductos.DataSource = typeof(List<>);
            dgListaProductos.DataSource = source;
            dgListaProductos.AutoResizeColumns();

        }
        private void txtbuscarP_TextChanged(object sender, EventArgs e)
        {
            var ProductoBuscado = ListadoProductosC.ListaDeProductos;

            var filter = ProductoBuscado.Where(a => a.Descripcion.Contains(txtbuscarP.Text) ||
            (a.CodigoReferencia != null && a.CodigoReferencia.Contains(txtbuscarP.Text)) ||
            (a.Categoria != null && a.Categoria.Contains(txtbuscarP.Text)) ||
            (a.Notas != null && a.Notas.Contains(txtbuscarP.Text)));
            dgListaProductos.DataSource = filter.ToList();
        }
        public void AddRowListaProductos()
        {
            if (dgListaProductos.Rows.Count == 0) return;
            if (dgListaProductos.CurrentRow == null) return;

            var produc = (ListarProductos)dgListaProductos.CurrentRow.DataBoundItem;
            var producto = ListadoProductosC.GetProducto(produc.CodigoReferencia);
            if (producto == null) return;

            if (producto.Stock <= 0) { KryptonMessageBox.Show("El Producto Tiene Stock 0, no se puede agregar"); return; }
            if (producto.IncluyeColor == "Sí")
            {
                var detallecolor = _coloresRepository.GetColor(producto.Id);
                if (detallecolor.Stock > 0)
                {

                    detallecolor.Stock -= 1;
                    _coloresRepository.Update(detallecolor);
                    //transaction.Commit();
                }
                else { KryptonMessageBox.Show("El Producto Tiene Stock 0, no se puede agregar"); return; }

            }
            else
            {
                producto.Stock -= 1;
                var prod = _productosRepository.Get(producto.Id);
                _productosRepository.Update(prod);
                //transaction.Commit();
            }

            // crea un nuevo objeto de tipo Detalle Compra

            ComboDetalleLista nuevodetalle = new ComboDetalleLista();
           
            nuevodetalle.Id = 0;
            //nuevodetalle.ComboId = ;
            nuevodetalle.Cantidad = 1;
            nuevodetalle.Descripcion = produc.Descripcion;
            nuevodetalle.Referencia = produc.Id.ToString();
           // nuevodetalle.productoId = produc.Id;

            // valido si el nuevo producto ya esta en la lista
            var resultado = _editarCombo.detalleListsObtenida.FirstOrDefault(s => s.Referencia == nuevodetalle.Referencia);

            //cambio los datos y actualizo la lista del Form anterior
            if (resultado != null)
            {
                resultado.Cantidad += 1;

                _editarCombo.CargarAddProductos();
            }
            else
            {
                _editarCombo.detalleListsObtenida.Add(nuevodetalle);
                _editarCombo.CargarAddProductos();

            }

            // _editarSolicitud.ActualizarLabelTotal();
            //_editarSolicitud.ListaProductSelect.CurrentRow.Cells[0].Selected = true;
            _editarCombo.ListaProductSelect.ClearSelection();
            txtbuscarP.Text = null;
        }


        private void AddProductosEditar_Load(object sender, EventArgs e)
        {

        }

        
    }
}
