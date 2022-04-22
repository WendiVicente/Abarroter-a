using CapaDatos.ListasPersonalizadas;
using CapaDatos.ListasPersonalizadas.VentasAcumuladas;
using CapaDatos.Models.Pedidos;
using CapaDatos.Models.ProductosToFacturar;
using CapaDatos.Repository;
using CapaDatos.Repository.SolicitudestoFacturar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sistema.Forms.modulo_Ccobrar
{
    public partial class VentaCredito : BaseContext
    {
        private SolicitudesRepository _solicitudesRepository = null;
        private DetalleProductoRepository _detalleProductosRepository = null;
        private List<ListarAcumuladasEncabezado> solicitudes = null;
        private ProductosRepository _productosRepository = null;
        private string NoDocumento = "";
        public VentaCredito()
        {
            _solicitudesRepository = new SolicitudesRepository(_context);
            _detalleProductosRepository = new DetalleProductoRepository(_context);
            _productosRepository = new ProductosRepository(_context);
            solicitudes = new List<ListarAcumuladasEncabezado>();            
            InitializeComponent();
        }

        private void VentaCredito_Load(object sender, EventArgs e)
        {
            CargarVentasCredito();
            dgvVentasCredito.ClearSelection();
        }

 
        private void CargarVentasCredito()
        {
            CargarDGV("VCR-", dgvVentasCredito, "");
            dgvVentasCredito.ClearSelection();
        }


        private void txtBuscarCredito_TextChanged(object sender, EventArgs e)
        {
            CargarDGV("VCR", dgvVentasCredito, txtBuscarCredito.Text);
        }

        private void CargarDGV(string tipo, DataGridView datag, string filtro)
        {
            solicitudes = _solicitudesRepository.GetAllSolicitudes(UsuarioLogeadoSistemas.User.SucursalId).OrderBy(x => x.NoSolicitud).ToList();
            var filter = solicitudes.Where(x => x.NoSolicitud.Contains(tipo)).ToList();
            if (filtro.Length > 0)
            {
                filter = filter.Where(x => x.NombreCliente.Contains(filtro) || x.NoSolicitud.Contains(filtro)).ToList();
            }
            datag.DataSource = typeof(List<>);
            datag.DataSource = filter;
            datag.Columns[0].Visible = false;
            datag.Columns[2].Visible = false;
            datag.Columns[3].Visible = false;
            datag.Columns[4].Visible = false;
            datag.Columns[8].Visible = false;
            datag.Columns[9].Visible = false;
            datag.Columns[10].Visible = false;        
            datag.ClearSelection();
        }

        private void dgvVentasCredito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDocumentoDGV(new List<ListarDetalleDocumento>());
            CargarDgvDetalles(new List<DetalleProducto>());
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                var fila = dgvVentasCredito.Rows[e.RowIndex];
                var solicitud = (ListarAcumuladasEncabezado)fila.DataBoundItem;
                CargarSolicitud(solicitud.Id);
            }
        }

        private void CargarDgvDetalles(List<DetalleProducto> list)
        {
            dgvDetalle.DataSource = typeof(List<>);
            dgvDetalle.DataSource = list;
            dgvDetalle.Columns[0].Visible = false;
            dgvDetalle.Columns[2].Visible = false;
            dgvDetalle.Columns[3].Visible = false;
            dgvDetalle.ClearSelection();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (NoDocumento.Length > 0)
                {
                    var fila = dgvProductos.Rows[e.RowIndex];
                    var detallesolicitud = (ListarDetalleDocumento)fila.DataBoundItem;
                    var detalles = _detalleProductosRepository.GetListNoDocumento(NoDocumento);
                    if (detalles.Count() > 0)
                    {
                        detalles = detalles.Where(x => x.ProductoId == detallesolicitud.ProductoId).ToList();
                        CargarDgvDetalles(detalles);
                    }
                }
            }
        }

        private void CargarSolicitud(Guid id)
        {
            try
            {
                var solicitud = _solicitudesRepository.Get(id);
                NoDocumento = solicitud.NoSolicitud;
                if (solicitud != null)
                {
                    var detallesolicitudes = _solicitudesRepository.GetDetallebySolicitud(solicitud.Id);
                    //detallesolicitudes = detallesolicitudes.Where(x => x.EstadoDevolucion == false || x.EstadoDevolucion == null).ToList();
                    List<ListarDetalleDocumento> listadoDet = new List<ListarDetalleDocumento>();
                    ListarDetalleDocumento detalleDoc = new ListarDetalleDocumento();
                    foreach (SolicitudDetalle item in detallesolicitudes)
                    {
                        var producto = _productosRepository.Get((int)item.ProductoId);
                        decimal pDescuento = 0.00m;
                        if (item.Descuento >= 1)
                        {
                            pDescuento = item.Precio - (item.Descuento / item.Cantidad);
                        }
                        detalleDoc.Documento = solicitud.NoSolicitud;
                        detalleDoc.DetalleDocumentoId = item.Id.ToString();
                        detalleDoc.ProductoId = producto.Id;
                        detalleDoc.Descripcion = producto.Descripcion;
                        detalleDoc.Cantidad = item.Cantidad;
                        detalleDoc.Precio = producto.PrecioVenta;
                        detalleDoc.Descuento = pDescuento;
                        detalleDoc.Subtotal = item.PrecioTotal;
                        detalleDoc.Devolver = item.EstadoDevolucion == null ? false : (bool)item.EstadoDevolucion;
                        listadoDet.Add(detalleDoc);
                        detalleDoc = new ListarDetalleDocumento();
                    }
                    CargarDocumentoDGV(listadoDet);
                }
                else
                {
                    MessageBox.Show("¡No se pudo obtener la venta!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡No se pudo obtener la venta! \n" + ex.Message);
            }
        }

        private void CargarDocumentoDGV(List<ListarDetalleDocumento> _listadoDetalles)
        {
            dgvProductos.DataSource = typeof(List<>);
            dgvProductos.DataSource = _listadoDetalles;
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[1].Visible = false;
            dgvProductos.Columns[2].Visible = false;
            //dgvProductos.Columns[8].Visible = false;
            dgvProductos.ClearSelection();
        }
    }
}