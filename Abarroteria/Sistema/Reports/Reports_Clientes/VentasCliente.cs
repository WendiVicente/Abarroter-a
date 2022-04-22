using CapaDatos.ListasPersonalizadas;
using CapaDatos.ListasPersonalizadas.VentasAcumuladas;
using CapaDatos.Models.CuentaCobrar;
using CapaDatos.Repository;
using CapaDatos.Repository.SolicitudestoFacturar;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Reporting.WinForms;
using sharedDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Reports.Reports_Clientes
{
    public partial class VentasCliente : BaseContext
    {
        private readonly ProductosRepository _productoRepository = null;
        private readonly FacturasRepository _facturasRepository = null;
        private readonly CategoriaProdRepository _categoriaProdRepository = null;
        private readonly DetalleProductoRepository _detalleProdRepository = null;
        private readonly ClientesRepository _clientesRepository = null;
        private readonly FacturasRepository _facturaRepository = null;
        private IList<DetalleFactura> listdetalleFac = null;

        DateTime FechaInicio;
        DateTime FechaFin;

        private Cliente _cliente = null;
        public VentasCliente()
        {
            _productoRepository = new ProductosRepository(_context);
            _clientesRepository = new ClientesRepository(_context);
            _productoRepository = new ProductosRepository(_context);
            _facturasRepository = new FacturasRepository(_context);
            _categoriaProdRepository = new CategoriaProdRepository(_context);
            _detalleProdRepository = new DetalleProductoRepository(_context);
            InitializeComponent();
        }

        private void ReportePagos_Load(object sender, EventArgs e)
        {
            cargarclienteCombo();
            CargarFecha();
            rvVentas.RefreshReport();
        }

        private void CargarFecha()
        {
            DateTime dt = DateTime.Now;
            dtpFechaInicio.Value = new DateTime(dt.Year, dt.Month, 1);
            dtpFechaFinal.Value = dt;
        }

        private void cargarclienteCombo()
        {
            var _clientesWithCuentas = _clientesRepository.GetClientes();
            cbCliente.DataSource = _clientesWithCuentas;
            cbCliente.ValueMember = "Id";
            cbCliente.DisplayMember = "Nombres";
            cbCliente.SelectedIndex = 0;
        }
        
        private List<ListadoVentasProducto> GetListadoVentaCliente()
        {
            //GetFacturasPorFechaCliente
            FechaInicio = dtpFechaInicio.Value.Date + new TimeSpan(0, 0, 0);
            FechaFin = dtpFechaFinal.Value.Date + new TimeSpan(23, 59, 59);
            var listadoDetalleObtenido = new List<ListarDetalleFacturas>();
            listdetalleFac = new List<DetalleFactura>();
            var listaventastosee = new List<ListadoVentasProducto>();
            var listaventadetail = new List<ListadoVentasProducto>();
            var listadoFacturaEncabezado = _facturasRepository.GetFacturastoReporte(FechaInicio, FechaFin, chktodasf.Checked);
            if (listadoFacturaEncabezado != null)
            {
                foreach (var item1 in listadoFacturaEncabezado)
                {
                    var detalleVenta = _facturasRepository.getdetallelista(item1.Id, 0);
                    if (detalleVenta != null)
                    {
                        foreach (var item in detalleVenta)
                        {
                            listdetalleFac.Add(item);
                        }
                    }
                }
            }

            if (listdetalleFac != null)
            {
                foreach (var item in listdetalleFac)
                {
                    var detalle = new ListadoVentasProducto();
                    var fact = _facturasRepository.Get(item.FacturaId);
                    Producto producto = new Producto();
                    if (item.ProductoId != null)
                    {
                        detalle = GetModelVenta(item, fact.NoFactura);
                        var detailsproducto = _detalleProdRepository.GetListNoDocumento(fact.NoFactura);
                        if (detailsproducto.Count() > 0)
                        {
                            detailsproducto = detailsproducto.Where(x => x.ProductoId == item.ProductoId).ToList();
                            if (detailsproducto.Count() > 0)
                            {
                                foreach (var detailprod in detailsproducto)
                                {
                                    if (detailprod.Detalle == "Azul")
                                    {
                                        string d = detailprod.Detalle;
                                    }

                                    detalle = GetModelVenta(item, fact.NoFactura);
                                    decimal preciounidad = item.SubTotal / item.Cantidad;
                                    detalle.Detalle = detailprod.Detalle;
                                    detalle.UnidadesVendidas = detailprod.Cantidad;
                                    detalle.Subtotal = preciounidad * detailprod.Cantidad;
                                    //AgregarDetalleProdListado(listaventastosee, detalle, item);
                                    listaventadetail.Add(detalle);
                                    detalle = new ListadoVentasProducto();
                                }
                            }
                            else
                            {
                                AgregarProductoListado(listaventastosee, detalle, item);
                            }
                        }
                        else
                        {
                            AgregarProductoListado(listaventastosee, detalle, item);
                        }
                    }
                }
            }

            GetListado(listaventastosee, listaventadetail);

            foreach (var item in listaventastosee)
            {
                var prod = _productoRepository.Get(item.ProductoId);
                if (item.Subtotal > 0)
                {
                    decimal ventaSinIVA = item.Subtotal - (item.Subtotal * 0.12m);
                    decimal totalCosto = prod.Coste * item.UnidadesVendidas;
                    item.Subtotal = decimal.Round(ventaSinIVA, 3);
                    item.Utilidad = decimal.Round((ventaSinIVA - totalCosto), 3);
                    item.CostoVenta = decimal.Round(totalCosto, 3);
                    item.Porcentaje = decimal.Round(((item.Utilidad * 100) / item.Subtotal), 2);
                }
                else
                {
                    item.Subtotal = 0.00m;
                    item.Utilidad = 0.00m;
                    item.CostoVenta = prod.Coste * item.UnidadesVendidas;
                    item.Porcentaje = 0.00m;
                }
            }

            return listaventastosee;
        }

        private ListadoVentasProducto GetModelVenta(DetalleFactura item, string fact)
        {
            ListadoVentasProducto detalle = new ListadoVentasProducto();
            detalle.Factura = fact;
            detalle.Categoria = item.Producto.Categoria.Nombre;
            detalle.Descripcion = item.ProductoId == null ? item.Combo.Descripcion : item.Producto.Descripcion;
            detalle.ProductoId = item.ProductoId == null ? 0 : (int)item.ProductoId;
            detalle.comboid = item.ProductoId == null ? (Guid)item.ComboId : Guid.Empty;
            detalle.Subtotal = item.PrecioTotal;
            detalle.UnidadesVendidas = item.Cantidad;
            detalle.Utilidad = _productoRepository.Get(detalle.ProductoId).Utilidad * item.Cantidad;
            detalle.CostoVenta = _productoRepository.Get(detalle.ProductoId).Coste * item.Cantidad;
            detalle.UnidadMedida = _productoRepository.Get(detalle.ProductoId).UnidadMedida;
            return detalle;
        }

        private string ObtenerCliente(int idcliente)
        {
            var cliente = _clientesRepository.Get(idcliente);
            string nombrecli = "";
            if (cliente != null)
            {
                nombrecli = cliente.Nombres + " " + cliente.Apellidos;
            }
            return nombrecli;
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargartextCliente();
        }

        private void cargartextCliente()
        {
            if (!(cbCliente.SelectedValue is VentasCliente))
            {
                var clienteSeleccionado = int.Parse(cbCliente.SelectedValue.ToString());
                var clienteObtenido = _clientesRepository.Get(clienteSeleccionado);
                if (clienteObtenido != null)
                {
                    _cliente = clienteObtenido;
                }
            }
        }

        private void btnGeneraReporte_Click(object sender, EventArgs e)
        {
            try 
            {
                CargarTabla();
                cargarTextbox();
            }
            catch
            {
                KryptonMessageBox.Show("Ha ocurrido un error interno. ", "Notificación");
            }           
        }

        private void CargarTabla()
        {
            List<ListadoVentasProducto> listaventastosee = GetListadoVentaCliente();
            rvVentas.LocalReport.ReportEmbeddedResource = "Sistema.Reports.Reports_Clientes.Cliente.rdlc";
            var rds1 = new ReportDataSource("DataSetVentas", listaventastosee);
            rvVentas.LocalReport.DataSources.Clear();
            rvVentas.LocalReport.DataSources.Add(rds1);
        }

        public void cargarTextbox()
        {
            string fechainicio = FechaInicio.Day + "/" + FechaInicio.Month + "/" + FechaInicio.Year;
            string fechafin = FechaFin.Day + "/" + FechaFin.Month + "/" + FechaFin.Year;
            ReportParameterCollection reportParameters = new ReportParameterCollection
            {
                 new ReportParameter("usuario",UsuarioLogeadoSistemas.User.Name),
                 new ReportParameter("nombreVendedor",UsuarioLogeadoSistemas.User.UserName),
                 new ReportParameter("sucursal",UsuarioLogeadoSistemas.User.Sucursal.NombreSucursal),
                 new ReportParameter("fechaInicio", fechainicio),
                 new ReportParameter("fechaFin", fechafin),
                 new ReportParameter("nombreCliente", _cliente.Nombres+" "+_cliente.Apellidos),
                 new ReportParameter("direccionCliente", _cliente.Direccion),
                 new ReportParameter("nitCliente", _cliente.Nit)
            };
            rvVentas.LocalReport.SetParameters(reportParameters);
        }


        private string GetFecha(DateTime datatime)
        {
            string fecha = "";
            fecha = datatime.Day + "/" + datatime.Month + "/" + datatime.Year;
            return fecha;
        }

        private void AgregarProductoListado(List<ListadoVentasProducto> listaventastosee, ListadoVentasProducto detalle, DetalleFactura item)
        {
            if (listaventastosee.Where(x => x.ProductoId == detalle.ProductoId).FirstOrDefault() == null)
            {
                listaventastosee.Add(detalle);
            }
            else
            {
                foreach (var detalletoUpdate in listaventastosee.Where(x => x.ProductoId == detalle.ProductoId))
                {
                    detalletoUpdate.UnidadesVendidas += item.Cantidad;
                    detalletoUpdate.Subtotal += item.PrecioTotal;
                }
            }
        }

        private void GetListado(List<ListadoVentasProducto> listado, List<ListadoVentasProducto> listadodetail)
        {
            var ventasProd = listadodetail.GroupBy(x => x.Detalle).ToList();
            foreach (var item in ventasProd)
            {
                var ventap = item.FirstOrDefault();
                ventap.UnidadesVendidas = item.Sum(x => x.UnidadesVendidas);
                ventap.Subtotal = item.Sum(x => x.Subtotal);
                listado.Add(ventap);
            }
        }
    }
}
