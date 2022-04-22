using CapaDatos.Data;
using CapaDatos.ListasPersonalizadas;
using CapaDatos.ListasPersonalizadas.VentasAcumuladas;
using CapaDatos.Models.Cotizacion;
using CapaDatos.Models.CuentaCobrar;
using CapaDatos.Models.Pedidos;
using CapaDatos.Models.Precios;
using CapaDatos.Models.Productos;
using CapaDatos.Models.Productos.Combos;
using CapaDatos.Models.ProductosToFacturar;
using CapaDatos.Models.Usuarios;
using CapaDatos.Models.Vales;
using CapaDatos.Repository;
using CapaDatos.Repository.PreciosRepository;
using CapaDatos.Repository.SolicitudestoFacturar;
using CapaDatos.Validation;
using ComponentFactory.Krypton.Toolkit;
using POS.Forms;
using POS.Forms.Complementos;
using sharedDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sistema.Forms.modulo_Ccobrar
{
    public partial class CreditosCliente : BaseContext
    {
        private ClientesRepository _clientesRepository = null;
        private CuentasCobrarRepository _cuentasCRepository = null;
        private ProductosRepository _productosRepository = null;
        private SolicitudesRepository _solicitudesRepository = null;
        private CotizacionRepository _cotizacionRepository = null;
        private ValesRepository _valesRepository = null;
        private ColoresRepository _coloresRepository = null;
        private TallasRepository _tallasRepository = null;
        private TomoEdicionRepository _tomoEdicionRepository = null;
        private List<ListarAcumuladasEncabezado> solicitudes = null;
        private DetalleProductoRepository _detalleProductoRepository = null;
        private ClienteCreditoRepository _clienteCreditoRepository = null;

        private IList<ListarCotizaciones> cotizaciones = null;
        private IList<ListarVales> vales = null;
        private List<ListaFacturacion> _listado = null;
        private Cliente _clienteUpdate = null;
        private Guid CuentaCBId;
        private Layout _Layout = null;

        private List<Cliente> _clientesWithCuentas = new List<Cliente>();

        public CreditosCliente(Layout layout)
        {
            CargarRepositories();
            solicitudes = new List<ListarAcumuladasEncabezado>();
            cotizaciones = new List<ListarCotizaciones>();
            vales = new List<ListarVales>();
            _listado = new List<ListaFacturacion>();
            _Layout = layout;
            InitializeComponent();
        }
        private void CreditosCliente_Load(object sender, EventArgs e)
        {
            cargarclienteCombo();
            cargarMovimientoCombo();
            CargarPago();
            dtpFecha.Value = DateTime.Now;
        }

        private void CargarPago()
        {
            cbPagos.Items.Insert(0, "Efectivo");
            cbPagos.Items.Insert(1, "Cheque");
            cbPagos.Items.Insert(2, "Tarjeta de Crédito");
            cbPagos.Items.Insert(3, "Tarjeta de Débito");
            cbPagos.SelectedIndex = 0;

        }
        private void cargarclienteCombo()
        {
            _clientesWithCuentas = _clientesRepository.GetClientesbyCredi();
            cbCliente.DataSource = _clientesWithCuentas;
            cbCliente.ValueMember = "Id";
            cbCliente.DisplayMember = "Nombres";
            cbCliente.SelectedIndex = 0;
        }
        private void cargarMovimientoCombo()
        {
            var tipomovimiento = _cuentasCRepository.GetlistaMovimientos();
            var filtromovi = tipomovimiento.Where(x => x.tipoMovimiento == "Pago").ToList();
            cbMovimiento.DataSource = filtromovi;
            cbMovimiento.ValueMember = "Id";
            cbMovimiento.DisplayMember = "tipoMovimiento";
        }

        private void cargartextCliente()
        {
            if (!(cbCliente.SelectedValue is Cliente))
            {
                var clienteSeleccionado = int.Parse(cbCliente.SelectedValue.ToString());
                var clienteObtenido = _clientesRepository.Get(clienteSeleccionado);
                if (clienteObtenido != null)
                {
                    lbNit.Text = clienteObtenido.Nit;
                    lbNombre.Text = clienteObtenido.Nombres + " " + clienteObtenido.Apellidos;
                    lbDireccion.Text = clienteObtenido.Direccion;
                    _clienteUpdate = clienteObtenido;

                    var cuenta = _cuentasCRepository.GetCcbyCliente(clienteObtenido.Id);
                    if (cuenta != null)
                    {
                        CuentaCBId = cuenta.Id;
                        lbCuentaPorCobrar.Text = cuenta.NoCuenta;
                    }
                }
            }
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            _listado.Clear();
            cargartextCliente();
            CargarDocumentos(_listado);
            CargaDGV(_listado);
            if (_listado.Count() > 0)
            {
                btnPagar.Enabled = true;
                pbMostrarDetalle.Visible = true;
            }
            else
            {
                btnPagar.Enabled = false;
                btnDevolver.Enabled = false;
                pbMostrarDetalle.Visible = false;
            }
        }

        private void CargarDocumentos(List<ListaFacturacion> listado)
        {
            CargarRepositories();
            decimal total = 0.00m;
            ListaFacturacion documento = new ListaFacturacion();
            var solicitudes = solicitudesByCuenta();
            foreach (var item in solicitudes)
            {
                decimal totalsol = ObtenerTotalSol(item.Id);
                documento.idDocumento = item.Id;
                documento.idTipoDocumento = 17;
                documento.Documento = item.NoSolicitud;
                documento.Fecha = item.FechaVenta;
                if (item.ClienteId <= 0)
                {
                    documento.Nit = item.NitCliente;
                    documento.Nombre = item.NombreCliente;
                }
                else
                {
                    ObtenerCliente(item.ClienteId, documento);
                }
                documento.Vendedor = item.Vendedor;
                documento.Valor = "Q " + totalsol;
                total += totalsol;
                documento.Facturar = false;
                listado.Add(documento);
                documento = new ListaFacturacion();
            }
            lbSaldoTotal.Text = total.ToString();
        }
        private void ObtenerCliente(int idcliente, ListaFacturacion documento)
        {
            var cliente = _clientesRepository.Get(idcliente);
            if (cliente != null)
            {
                documento.ClienteId = cliente.Id;
                documento.Nombre = cliente.Nombres + " " + cliente.Apellidos;
                documento.Nit = cliente.Nit;
            }
        }

        private void CargaDGV(List<ListaFacturacion> listado)
        {
            dgvDocs.DataSource = typeof(List<>);
            dgvDocs.DataSource = listado;
            dgvDocs.Columns[0].Visible = false;
            dgvDocs.Columns[1].Visible = false;
            dgvDocs.Columns[8].Visible = false;
            dgvDocs.Columns[9].Visible = false;
            dgvDocs.Columns[10].Visible = false;
            dgvDocs.ClearSelection();
        }

        public decimal ObtenerTotalSol(Guid id)
        {
            decimal Total = 0.00m;
            try
            {
                var solicitudes = _solicitudesRepository.GetDetallebySolicitud(id);
                if (solicitudes.Count > 0)
                {
                    Total = solicitudes.Sum(x => x.PrecioTotal);
                }
            }
            catch
            {
                MessageBox.Show("No pudo obtener valor Total del documento.", "Advertencia");
                Total = 0.00m;
            }
            return Total;
        }

        public List<SolicitudToFacturar> solicitudesByCuenta()
        {
            List<SolicitudToFacturar> solicitudes = new List<SolicitudToFacturar>();
            var documentos = _clienteCreditoRepository.GetByCuenta(CuentaCBId);
            foreach (var item in documentos)
            {
                var solicitud = _solicitudesRepository.Get(item.DocumentoId);
                solicitudes.Add(solicitud);
            }
            return solicitudes;
        }


        private void CargarSolicitud(Guid id)
        {
            try
            {
                var solicitud = _solicitudesRepository.Get(id);
                if (solicitud != null)
                {
                    var detallesolicitudes = _solicitudesRepository.GetDetallebySolicitud(solicitud.Id);
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

                        detalleDoc.ProductoId = producto.Id;
                        detalleDoc.Descripcion = producto.Descripcion;
                        detalleDoc.Cantidad = item.Cantidad;
                        detalleDoc.Precio = producto.PrecioVenta;
                        detalleDoc.Descuento = pDescuento;
                        detalleDoc.Subtotal = item.PrecioTotal;
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
			dgvDetails.DataSource = typeof(List<>);
			dgvDetails.DataSource = _listadoDetalles;
			dgvDetails.ClearSelection();
		}

        


        private void CargarRepositories()
        {
            if (_context == null)
            {
                _context = null;
                _context = new Context();
                ContextRepositores(_context);
            }
            else
            {
                ContextRepositores(_context);
            }
        }

        private void ContextRepositores(Context ctx)
        {
            _productosRepository = new ProductosRepository(ctx);
            _clientesRepository = new ClientesRepository(ctx);
            _solicitudesRepository = new SolicitudesRepository(ctx);
            _cotizacionRepository = new CotizacionRepository(ctx);
            _valesRepository = new ValesRepository(ctx);
            _coloresRepository = new ColoresRepository(ctx);
            _tallasRepository = new TallasRepository(ctx);
            _tomoEdicionRepository = new TomoEdicionRepository(ctx);
            _detalleProductoRepository = new DetalleProductoRepository(ctx);
            _clienteCreditoRepository = new ClienteCreditoRepository(ctx);
            _cuentasCRepository = new CuentasCobrarRepository(ctx);
        }

        private void dgvDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarRepositories();
            
        }
    }
}
