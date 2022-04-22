using CapaDatos.ListasPersonalizadas;
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

namespace Sistema.Reports.Reporte_Creditos
{
    public partial class ReportePagos : BaseContext
    {        
        private ProductosRepository _prodRepository = null;
        private ClientesRepository _clientesRepository = null;
        private CuentasCobrarRepository _cuentasCRepository = null;
        private SolicitudesRepository _solicitudesRepository = null;
        private DetallePagoRepository _detallePagoRepostitory = null;
        private ClienteCreditoRepository _clientecreditoRepository = null;
        private IList<Cliente> _clientesWithCuentas = null;

        private Cliente _cliente = null;
        private CuentaCB _cuenta = null;
        private decimal SaldoActual = 0.00m;
        private decimal totalCredito = 0.00m;
        private decimal totalAbono = 0.00m;
        private string fechaInicio = "";
        private string fechaFin = "";
        public ReportePagos()
        {
            _prodRepository = new ProductosRepository(_context);
            _clientesRepository = new ClientesRepository(_context);
            _cuentasCRepository = new CuentasCobrarRepository(_context);
            _solicitudesRepository = new SolicitudesRepository(_context);
            _detallePagoRepostitory = new DetallePagoRepository(_context);
            _clientecreditoRepository = new ClienteCreditoRepository(_context);
            _clientesWithCuentas = new List<Cliente>();
            InitializeComponent();
        }

        private void ReportePagos_Load(object sender, EventArgs e)
        {
            cargarclienteCombo();
            this.rvPagos.RefreshReport();
        }

        private void cargarclienteCombo()
        {
            _clientesWithCuentas = _clientesRepository.GetClientesbyCredi();
            cbCliente.DataSource = _clientesWithCuentas;
            cbCliente.ValueMember = "Id";
            cbCliente.DisplayMember = "Nombres";
            cbCliente.SelectedIndex = 0;
        }

        private List<ListaVentasProductos> GetListadoPago()
        {
            List<ListaVentasProductos> listado = new List<ListaVentasProductos>();
            List<ListaVentasProductos> creditos = new List<ListaVentasProductos>();
            List<ListaVentasProductos> abono = new List<ListaVentasProductos>();
            ListaVentasProductos detalle = new ListaVentasProductos();

            var creditosCliente = _clientecreditoRepository.GetByCuenta(_cuenta.Id);
            foreach (var item in creditosCliente)
            {
                var solicitud = _solicitudesRepository.Get(item.DocumentoId);
                string cliente = "";
                if (solicitud.ClienteId <= 0)
                {
                    cliente = solicitud.NombreCliente;
                }
                else
                {
                    cliente = ObtenerCliente(solicitud.ClienteId);
                }

                var detallesolicitudes = _solicitudesRepository.GetDetallebySolicitud(item.DocumentoId);
                if (detallesolicitudes.Count() > 0)
                {
                    detallesolicitudes = detallesolicitudes.Where(x => x.EstadoDevolucion == false || x.EstadoDevolucion == null).ToList();
                }
                foreach (var element in detallesolicitudes)
                {
                    var producto = _prodRepository.Get((int)element.ProductoId);
                    detalle = new ListaVentasProductos
                    {
                        Cliente = cliente,
                        Fecha = GetFecha(solicitud.FechaVenta),
                        Documento = solicitud.NoSolicitud,
                        Cantidad = element.Cantidad.ToString(),
                        Descripcion = producto.Descripcion,
                        Valor = element.SubTotal
                    };
                    creditos.Add(detalle);
                }                
            }
            totalCredito = creditos.Sum(x => x.Valor);
            var notaspago = _cuentasCRepository.Getlistadepagoscreditos(_cuenta.Id);
           
            foreach (var notapago in notaspago)
            {
                detalle = new ListaVentasProductos
                {
                    Cliente = "",
                    Cantidad = "",
                    Fecha = GetFecha(notapago.FechaTransaccion),
                    Documento = notapago.NoDocumento,
                    Descripcion = notapago.Descripcion,
                    Valor = notapago.Monto
                };
                abono.Add(detalle);
            }


            totalAbono = abono.Sum(x => x.Valor);
            listado = listado.Concat(creditos).Concat(abono).ToList();
            listado = listado.OrderBy(x => x.Fecha).ToList();
            if(listado.Count() > 0)
            {
                fechaInicio = listado.FirstOrDefault().Fecha;
                fechaFin = listado.LastOrDefault().Fecha;
            }
            
            return listado;
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
            if (!(cbCliente.SelectedValue is Cliente))
            {
                var clienteSeleccionado = int.Parse(cbCliente.SelectedValue.ToString());
                var clienteObtenido = _clientesRepository.Get(clienteSeleccionado);
                if (clienteObtenido != null)
                {
                    _cliente = clienteObtenido;
                    var cuenta = _cuentasCRepository.GetCcbyCliente(clienteObtenido.Id);
                    if (cuenta != null)
                    {
                        _cuenta = cuenta;
                        lbCuentaPorCobrar.Text = cuenta.NoCuenta;
                        SaldoActual = cuenta.SaldoActual;
                    }
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
            List<ListaVentasProductos> listadoPagos = GetListadoPago();
            this.rvPagos.LocalReport.DataSources.Clear();
            this.rvPagos.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetPagos", listadoPagos));           
            this.rvPagos.RefreshReport();
        }

        public void cargarTextbox()
        {

            ReportParameterCollection reportParameters = new ReportParameterCollection
            {
                 new ReportParameter("usuario",UsuarioLogeadoSistemas.User.Name),
                 new ReportParameter("nombreVendedor",UsuarioLogeadoSistemas.User.UserName),
                 new ReportParameter("sucursal",UsuarioLogeadoSistemas.User.Sucursal.NombreSucursal),
                 new ReportParameter("fechaInicio", fechaInicio),
                 new ReportParameter("fechaFin", fechaFin),
                 new ReportParameter("totalCredito", totalCredito.ToString()),
                 new ReportParameter("totalAbono",totalAbono.ToString()),
                 new ReportParameter("saldoActual", SaldoActual.ToString()),
                 new ReportParameter("nombreCliente", _cliente.Nombres+" "+_cliente.Apellidos),
                 new ReportParameter("direccionCliente", _cliente.Direccion),
                 new ReportParameter("nitCliente", _cliente.Nit)
            };
            rvPagos.LocalReport.SetParameters(reportParameters);
        }


        private string GetFecha(DateTime datatime)
        {
            string fecha = "";
            fecha = datatime.Day + "/" + datatime.Month + "/" + datatime.Year;
            return fecha;
        }
    }
}
