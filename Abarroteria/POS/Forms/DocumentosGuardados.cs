using CapaDatos.ListasPersonalizadas;
using CapaDatos.ListasPersonalizadas.VentasAcumuladas;
using CapaDatos.Models.ProductosToFacturar;
using CapaDatos.Repository;
using CapaDatos.Repository.SolicitudestoFacturar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms
{
    public partial class DocumentosGuardados : BaseContext
    {
        private SolicitudesRepository _solicitudesRepository = null;
        private ValesRepository _valesRepository = null;
        private CotizacionRepository _cotizacionRepository = null;
        private ProductosTempRepository _productosTempRepository = null;
        private List<ListaProductosTmp> listaTemporales = null;
        List<ListarAcumuladasEncabezado> solicitudes = null;
        IList<ListarCotizaciones> cotizaciones = null;
        IList<ListarVales> vales = null;
        PuntoDeVenta _puntoDeVenta = null;

        public DocumentosGuardados(PuntoDeVenta pos)
        {
            _solicitudesRepository = new SolicitudesRepository(_context);
            _valesRepository = new ValesRepository(_context);
            _cotizacionRepository = new CotizacionRepository(_context);
            _productosTempRepository = new ProductosTempRepository(_context);
            _puntoDeVenta = pos;
            solicitudes = new List<ListarAcumuladasEncabezado>();
            cotizaciones = new List<ListarCotizaciones>();
            vales = new List<ListarVales>();
            
            InitializeComponent();
        }


        private void DocumentosGuardados_Load(object sender, EventArgs e)
        {
            CargarVentasContado();
            CargarVentasCredito();
            CargarCotizaciones();
            CargarVales();
            CargarProductos();
        }

        private void CargarVentasContado()
        {
            CargarDGV("VCN-", dgvVentasContado, "");            
        }

        private void CargarVentasCredito()
        {
            CargarDGV("VCR-", dgvVentasCredito, "");
        }

        private void CargarCotizaciones()
        {
            CargarDGVCot("");
        }

        private void CargarVales()
        {
            CargarDGVVale("");
        }

        private void CargarProductos()
        {
            CargarDGVProductosAcumulados("");
        }

        private void txtBuscarContado_TextChanged(object sender, EventArgs e)
        {
            CargarDGV("VCN", dgvVentasContado, txtBuscarContado.Text);
        }

        private void txtBuscarCredito_TextChanged(object sender, EventArgs e)
        {
            CargarDGV("VCR", dgvVentasCredito, txtBuscarCredito.Text);
        }

        private void txtBuscarCotizacion_TextChanged(object sender, EventArgs e)
        {
            CargarDGVCot(txtBuscarCotizacion.Text);
        }

        private void txtBuscarVale_TextChanged(object sender, EventArgs e)
        {
            CargarDGVVale(txtBuscarCotizacion.Text);
        }

        private void txtbuscarProducto_TextChanged(object sender, EventArgs e)
        {
            CargarDGVProductosAcumulados(txtbuscarProducto.Text);
        }

        private void CargarDGV(string tipo, DataGridView datag, string filtro)
        {
            solicitudes = _solicitudesRepository.GetSolicitudes(UsuarioLogeadoPOS.User.SucursalId);
            if (solicitudes.Count() > 0)
            {
                solicitudes = solicitudes.Where(x => x.Estado != "Facturado").ToList();
            }
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
            datag.AutoResizeColumns();
        }

        private void CargarDGVCot(string filtro)
        {
            cotizaciones = _cotizacionRepository.GetListGenerales(UsuarioLogeadoPOS.User.SucursalId);
            if (cotizaciones.Count > 0)
            {
                cotizaciones = _cotizacionRepository.GetListGenerales(0).Where(x => x.Estado != "Comprado").ToList();
            }
            if (filtro.Length > 0)
            {
                cotizaciones = cotizaciones.Where(x => x.Nombre.Contains(filtro) || x.Nit.Contains(filtro) || x.NoCotizacion.Contains(filtro)).ToList();
            }
            dgvCotizacion.DataSource = typeof(List<>);
            dgvCotizacion.DataSource = cotizaciones;
            dgvCotizacion.Columns[0].Visible = false;
            dgvCotizacion.Columns[13].Visible = false;
            dgvCotizacion.Columns[14].Visible = false;
        }

        private void CargarDGVVale(string filtro)
        {
            vales = _valesRepository.GetListaVales(UsuarioLogeadoPOS.User.SucursalId);
            if (vales.Count() > 0)
            {
                vales = vales.Where(x => x.Estado != true).ToList();
            }
            if (filtro.Length > 0)
            {
                vales = vales.Where(x => x.Descripcion.Contains(filtro) || x.NoVale.Contains(filtro)).ToList();
            }
            dgvVales.DataSource = typeof(List<>);
            dgvVales.DataSource = vales;
            dgvVales.Columns[0].Visible = false;
            dgvVales.Columns[4].Visible = false;
            dgvVales.Columns[5].Visible = false;
            dgvVales.Columns[9].Visible = false;
            dgvVales.Columns[10].Visible = false;
            dgvVales.Columns[11].Visible = false;
        }

        private void CargarDGVProductosAcumulados(string filtro)
        {
            var lista = _productosTempRepository.GetTemporalProductosLista()
                                                    .Where(x => x.IsActive == false).ToList();
            if (filtro.Length > 0)
            {
                lista = lista.Where(x => x.Descripcion.Contains(filtro)).ToList();
            }
            BindingSource source = new BindingSource();
            source.DataSource = lista;
            dgvProdAcumulados.DataSource = typeof(List<>);
            dgvProdAcumulados.DataSource = lista;
            dgvProdAcumulados.Columns[1].Visible = false;
            dgvProdAcumulados.Columns[2].Visible = false;
            dgvProdAcumulados.Columns[11].Visible = false;
            dgvProdAcumulados.Columns[12].Visible = false;
            dgvProdAcumulados.Columns[13].Visible = false;
            dgvProdAcumulados.Columns[15].Visible = false;
            dgvProdAcumulados.ClearSelection();
        }

        private void dgvVentasCredito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dgvVentasCredito.CurrentRow;
            _puntoDeVenta.CargarDocumento(17, (Guid)fila.Cells[0].Value);
            Close();
        }

        private void dgvVentasContado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dgvVentasContado.CurrentRow;
            _puntoDeVenta.CargarDocumento(16, (Guid)fila.Cells[0].Value);
            Close();
        }

        private void dgvCotizacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dgvCotizacion.CurrentRow;
            _puntoDeVenta.CargarDocumento(21, (Guid)fila.Cells[0].Value);
            Close();
        }

        private void dgvVales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dgvVales.CurrentRow;
            _puntoDeVenta.CargarDocumento(22, (Guid)fila.Cells[0].Value);
            Close();
        }

        private void dgvProdAcumulados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarFila(dgvProdAcumulados, 14);
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            CrearListaBySelected();
            if (listaTemporales.Count > 0)
            {
                _puntoDeVenta.cargarDGVDetalle(listaTemporales);
                _puntoDeVenta.ProductosTemporales = true;
                Close();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar al menos un producto"); return;
            }            
        }

        private void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            int acciones = 14;
            if (chbSelectAll.Checked == true)
            {
                if (dgvProdAcumulados.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvProdAcumulados.Rows)
                    {
                        row.Cells[acciones].Value = true;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvProdAcumulados.Rows)
                {
                    row.Cells[acciones].Value = false;
                }
            }
        }

        private void SeleccionarFila(DataGridView datagrid, int acciones)
        {
            bool estadoActual = Convert.ToBoolean(datagrid.CurrentRow.Cells[acciones].Value);
            if (estadoActual)
            {
                datagrid.CurrentRow.Cells[acciones].Value = false;
            }
            else
            {
                datagrid.CurrentRow.Cells[acciones].Value = true;
            }
        }

        private void CrearListaBySelected()
        {
            int colAcciones = 14;
            int filasSeleccion = 0;
            int contador = 0;
            listaTemporales = new List<ListaProductosTmp>();
            try
            {
                foreach (DataGridViewRow rows in dgvProdAcumulados.Rows)
                {
                    bool acciones = Convert.ToBoolean(rows.Cells[colAcciones].Value);
                    if (!acciones)
                    {
                        filasSeleccion += 1;
                    }
                    else
                    {
                        var fila = (ListaProductosTmp)dgvProdAcumulados.Rows[contador].DataBoundItem;
                        listaTemporales.Add(fila);
                    }
                    contador += 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                return;
            }
        }
    }
}