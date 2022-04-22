using CapaDatos.Data;
using CapaDatos.ListasPersonalizadas;
using CapaDatos.ListasPersonalizadas.VentasAcumuladas;
using CapaDatos.Models.Cotizacion;
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
using ComponentFactory.Krypton.Toolkit;
using POS.Forms;
using POS.Helper;
using sharedDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace POS
{
    public partial class PrincipalV2 : BaseContext
    {
        private readonly CotizacionRepository _cotizacionRepository = null;
        private readonly PedidoRepository _pedidoRepository = null;
        private readonly ValesRepository _valesRepository = null;
        private ProductosRepository _productosRepository = null;
        private readonly CombosRepository _combosRepository = null;
        private readonly ColoresRepository _coloresRepository = null;
        private readonly TallasRepository _tallasRepository = null;
        private readonly TallasyColoresRepository _tallasyColoresRepository = null;
        private readonly SolicitudesRepository _solicitudesRepository = null;
        private readonly TipoPrecioRepository _tipoPrecioRepository = null;
        private readonly RecargasRepository _recargasRepository = null;
        private readonly DetalleEstiloRepository _estiloRespository = null;
        private readonly TiposClienteRepository _tiposRepository = null;
        private readonly DetalleGranoRepository _detalleGranoRepository = null;
        private readonly CategoriaProdRepository _categoriasProdRepository = null;

        //listas detalles
        public List<ListarDetalleCotiz> _listadetallesCotiz = new List<ListarDetalleCotiz>();
        public List<ListarDetallePedidos> _listadetallesPedidos = new List<ListarDetallePedidos>();
        public IList<ListarCombos> _listaCombos = new List<ListarCombos>();
        public IList<ListarProductos> _listaProductos = null, listareducidaDebusquedal = null;
        public List<ListarDetalleFacturas> _listaDetalleFacturas = new List<ListarDetalleFacturas>();
        public List<SolicitudDetalle> _listaSolicitudDetalles = null;
        public List<ListarAcumuladasEncabezado> _listaSolicitud = null;
        public List<Producto> _allProductosList = null, listatotalbusqueda = null;
        public List<DetalleRecarga> detalleRecargas = new List<DetalleRecarga>();
        public List<string> ventasPendientes = new List<string>();
        public List<ListarCotizaciones> cotizaciones = new List<ListarCotizaciones>();
        public List<ListarPedidos> pedidos = new List<ListarPedidos>();
        public List<ListarVales> vales = new List<ListarVales>();
        public List<ListarAcumuladasEncabezado> listadeVentasPendientes = new List<ListarAcumuladasEncabezado>();
        public ListarAcumuladasEncabezado ventaAcumuladaSelected = null;

        //variables
        public Guid idCotizacion;
        public Guid idPedido;
        private bool selectProducto = true;
        public ListarVales _valeSelected = null;
        public String colorSel = "";
        public String tallaSel = "";
        public int detcolorId = 0;
        public int dettallaId = 0;
        public int dettallacolorId = 0;
        public int cantidad = 1;
        public decimal TotalCobro = 0.00m;

        private readonly int colCantidad = 6;
        private readonly int colPrecio = 7;
        private readonly int colDescuento = 8;
        private readonly int colSubtotal = 9;
        private readonly int colTotal = 10;
        private readonly int colUtilidad = 21;


        public PrincipalV2(User user)
        {
            UsuarioLogeadoPOS.User = user;
            InitializeComponent();
            _cotizacionRepository = new CotizacionRepository(_context);
            _pedidoRepository = new PedidoRepository(_context);
            _valesRepository = new ValesRepository(_context);
            _productosRepository = new ProductosRepository(_context);
            _combosRepository = new CombosRepository(_context);
            _coloresRepository = new ColoresRepository(_context);
            _tallasRepository = new TallasRepository(_context);
            _tallasyColoresRepository = new TallasyColoresRepository(_context);
            _solicitudesRepository = new SolicitudesRepository(_context);
            _tipoPrecioRepository = new TipoPrecioRepository(_context);
            _recargasRepository = new RecargasRepository(_context);
            _estiloRespository = new DetalleEstiloRepository(_context);
            _tiposRepository = new TiposClienteRepository(_context);
            _detalleGranoRepository = new DetalleGranoRepository(_context);
            _categoriasProdRepository = new CategoriaProdRepository(_context);
            cargarUsuarioYSucursal();
        }

        private void PrincipalV2_Load(object sender, EventArgs e)
        {
            cargarListaVentasPendientes();
            var cargaCombo = ComboLoad();
            var cargaProducto = ProductosLoad1();
            _allProductosList = null;
            listatotalbusqueda = null;
            _listaCombos = cargaCombo;
            cargaProductosInit();
            cargarCateroriasb();
            CargarProductosGenerales(cargaProducto);
            CargarComboClientes();
            CargarButtonsCategoria();
        }

        private void CargarComboClientes()
        {
            var tiposClientes = _tiposRepository.GettiposCliente();
            CbTipoCliente.ComboBox.DataSource = tiposClientes.Where(x => x.Estado == "Activa").ToList();
            CbTipoCliente.ComboBox.DisplayMember = "TipoCliente";
            CbTipoCliente.ComboBox.ValueMember = "Id";
            CbTipoCliente.ComboBox.SelectedValue = 7;
        }

        private void cargarListaVentasPendientes()
        {
            _listaSolicitud = _solicitudesRepository.GetSolicitudesxUser(UsuarioLogeadoPOS.User.Privilegios,UsuarioLogeadoPOS.User.Id);
            CargarVentasSolicitadas(_listaSolicitud);  
        }

        private void CargarVentasSolicitadas(List<ListarAcumuladasEncabezado> lista)
        {
            BindingSource recurso = new BindingSource();
            recurso.DataSource = lista;
            dgVentasPendientes.DataSource = typeof(List<>);
            dgVentasPendientes.DataSource = recurso;
            dgVentasPendientes.AutoResizeColumns();
            dgVentasPendientes.Columns[0].Visible = false;
            dgVentasPendientes.Columns[3].Visible = false;
        }

        private void CargarProductosGenerales(IList<ListarProductos> lista)
        {
            //var lista= _productosRepository.GetList(UsuarioLogeadoPOS.User.SucursalId);
            BindingSource recurso = new BindingSource();

            recurso.DataSource = lista;
            dgvProductosBd.DataSource = typeof(List<>);
            dgvProductosBd.DataSource = recurso;
            //dgvProductosBd.AutoResizeColumns();
            _listaProductos = lista;
            int value = dgvProductosBd.ColumnCount;
            if (value > 0)
            {
                for (int i = 18; i <= 28; i++)
                {
                    dgvProductosBd.Columns[i].Visible = false;
                }
            }
            dgvProductosBd.ClearSelection();
        }

        private void CargarCombosGenerales(IList<ListarCombos> lista)
        {
            //var lista= _productosRepository.GetList(UsuarioLogeadoPOS.User.SucursalId);
            BindingSource recurso = new BindingSource();
            recurso.DataSource = lista;
            dgvProductosBd.DataSource = typeof(List<>);
            dgvProductosBd.DataSource = recurso;
            //dgvProductosBd.AutoResizeColumns();
            // _listaCombos = lista;
        }

        private void cargarCateroriasb()
        {
            //CargarButtonsCategoria(_categoriaProdRepository.GetListcategoriaToButton());
        }

        private void cargarUsuarioYSucursal()
        {
            lbsucursal.Text = UsuarioLogeadoPOS.User.Sucursal.NombreSucursal;
            lbusuariologeado.Text = UsuarioLogeadoPOS.User.UserName;
        }

        private IList<ListarCombos> ComboLoad()
        {
            var combosbd = _combosRepository.GetListarCombos(UsuarioLogeadoPOS.User.SucursalId);
            return combosbd;
        }

        private IList<ListarProductos> ProductosLoad1()
        {
            var productosbd = _productosRepository.GetList(UsuarioLogeadoPOS.User.SucursalId).Take(50).ToList();
            return productosbd;
        }

        private IList<ListarProductos> ProductosAll()
        {
            var productosbd = _productosRepository.GetList(UsuarioLogeadoPOS.User.SucursalId).ToList();
            return productosbd;
        }

        private void CargarPorCategoria(int catid) 
        {
            var productosbdcat = _productosRepository.GetListByCategoria(catid, UsuarioLogeadoPOS.User.SucursalId).ToList();
            _listaProductos = productosbdcat;
            cargaProductosInit();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarBD();
        }

        public void CargarBD()
        {
            cargarListaVentasPendientes();
        }

        public void cargarValeLabel()
        {
            if (_valeSelected != null)
            {
                lbnumeroVale.Text = _valeSelected.NoVale;
                lbvalename.Visible = true;
            }
            else
            {
                lbvalename.Visible = false;
                lbnumeroVale.Text = null;
            }
        }

        public ProductosRepository AccesoProductoRepository()
        {
            try
            {
                _context = null;
                _context = new Context();
                _productosRepository = null;
                _productosRepository = new ProductosRepository(_context);
            }
            catch (Exception io)
            {
                KryptonMessageBox.Show("Error en 'AccesoProductosRepository' " + io.Message);
            }
            return _productosRepository;
        }

        public ListarDetalleFacturas GetDetalleFactura()
        {
            return new ListarDetalleFacturas()
            {};
        }

        public void resetValues()
        {
            checkAll.Checked = false;
            SumaFilas();
            dgvproductosadd.ClearSelection();
        }

        public void eliminarDGVDetalleFactura(int id)
        {
            try
            {
                if (_listaDetalleFacturas.Count > 0)
                {
                    ListarDetalleFacturas detalle = _listaDetalleFacturas.Where(x => x.ProductoId == id).FirstOrDefault();
                    int index = _listaDetalleFacturas.IndexOf(detalle);
                    dgvproductosadd.Rows.RemoveAt(index);
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("No se pudo eliminar el producto del listado de Productos Agregados");
            }
        }

        public void cargarDGVDetalleFactura(List<ListarDetalleFacturas> lista)
        {
            BindingSource recurso = new BindingSource();
            recurso.DataSource = lista;
            dgvproductosadd.DataSource = typeof(List<>);
            dgvproductosadd.DataSource = recurso;
            dgvproductosadd.AutoResizeColumns();
            dgvproductosadd.ClearSelection();
        }

        public List<ListarDetalleFacturas> GetSolicitudToFacturaDetalle(List<ListaVentasAcumuladas> solicitudDetalleslista)
        {
            //  var list = new List<ListarDetalleFacturas>();
            foreach (var item in solicitudDetalleslista)
            {
                if (solicitudDetalleslista == null) { continue; }
                var detalleFactura = GetDetalleFactura();
                detalleFactura.Id = (int)item.Id;
                detalleFactura.DetalleColorId = (int)item.DetalleColorId;
                detalleFactura.DetalleTallaId = (int)item.DetalleTallaId;
                detalleFactura.TallayColorId = item.TallayColorId;
                detalleFactura.Color = item.Color;
                detalleFactura.Talla = item.Talla;
                detalleFactura.ProductoId = (int)item.ProductoId;
                detalleFactura.Descripcion = item.Descripcion;
                detalleFactura.Cantidad = item.Cantidad;
                detalleFactura.Precio = item.Precio;
                detalleFactura.Descuento = item.Descuento;
                detalleFactura.PrecioTotal = item.PrecioTotal;
                detalleFactura.SubTotal = detalleFactura.PrecioTotal;
                detalleFactura.ComboId = item.ComboId;
                _listaDetalleFacturas.Add(detalleFactura);
            }
            return _listaDetalleFacturas;
        }

        public List<ListarDetalleFacturas> GetCotizacionToFacturaDetalle()
        {
            //  var list = new List<ListarDetalleFacturas>();
            foreach (var item in _listadetallesCotiz)
            {
                if (_listadetallesCotiz == null) { continue; }
                var detalleFactura = GetDetalleFactura();
                detalleFactura.DetalleColorId = item.DetalleColorId;
                detalleFactura.DetalleTallaId = item.DetalleTallaId;
                detalleFactura.TallayColorId = item.TallayColorId;
                detalleFactura.EstiloId = item.DetalleEstiloId;
                detalleFactura.Estilo = item.Estilo;
                detalleFactura.Color = item.Color;
                detalleFactura.Talla = item.Talla;
                detalleFactura.ProductoId = (int)item.ProductoId;
                detalleFactura.Descripcion = item.Descripcion;
                detalleFactura.Cantidad = item.Cantidad;
                detalleFactura.Precio = item.Precio;
                detalleFactura.Descuento = 0;
                detalleFactura.PrecioTotal = item.Total;
                detalleFactura.SubTotal = detalleFactura.PrecioTotal;
                detalleFactura.ComboId = item.ComboId;
                _listaDetalleFacturas.Add(detalleFactura);
            }
            return _listaDetalleFacturas;
        }

        public List<ListarDetalleFacturas> GetPedidoToFacturaDetalle()
        {
            // var list = new List<ListarDetalleFacturas>();
            foreach (var item in _listadetallesPedidos)
            {
                if (_listadetallesPedidos == null) { continue; }
                var detalleFactura = GetDetalleFactura();
                detalleFactura.DetalleColorId = item.DetalleColorId;
                detalleFactura.DetalleTallaId = item.DetalleTallaId;
                detalleFactura.TallayColorId = item.TallayColorId;
                detalleFactura.Color = item.Color;
                detalleFactura.Talla = item.Talla;
                detalleFactura.ProductoId = (int)item.ProductoId;
                detalleFactura.Descripcion = item.Descripcion;
                detalleFactura.Cantidad = item.Cantidad;
                detalleFactura.Precio = item.Precio;
                detalleFactura.Descuento = 0;
                detalleFactura.PrecioTotal = item.Total;
                detalleFactura.SubTotal = detalleFactura.PrecioTotal;
                detalleFactura.ComboId = item.ComboId;
                detalleFactura.EstiloId = item.DetalleEstiloId;
                detalleFactura.Estilo = item.Estilo;
                _listaDetalleFacturas.Add(detalleFactura);
            }
            return _listaDetalleFacturas;
        }        

        private void cargarProdToDgvFact(ListarProductos producto)
        {
            var detallefactura = GetDetalleFactura();
            detallefactura.ProductoId = producto.Id;
            detallefactura.Cantidad = 1;
            detallefactura.Descripcion = producto.Descripcion;
            detallefactura.Precio = producto.PrecioVenta;
            detallefactura.SubTotal = detallefactura.Cantidad * detallefactura.Precio;
            detallefactura.PrecioTotal = detallefactura.SubTotal;
            _listaDetalleFacturas.Add(detallefactura);
            cargarDGVDetalleFactura(_listaDetalleFacturas);
        }        

        private void btncotizacion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AgregarCotizacion"] == null)
            {
                AgregarCotizacion AddCotizacion = new AgregarCotizacion(this);
                AddCotizacion.Show();
            }
            else
            {
                Application.OpenForms["AgregarCotizacion"].Activate();
            }
        }

        private void btnpedidos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AgregarPedido"] == null)
            {
                AgregarPedido AddCotizacion = new AgregarPedido(this);
                AddCotizacion.Show();
            }
            else
            {
                Application.OpenForms["AgregarPedido"].Activate();
            }
        }

        private void btnVales_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AgregarVale"] == null)
            {
                AgregarVale AddCotizacion = new AgregarVale(this);
                AddCotizacion.Show();
            }
            else
            {
                Application.OpenForms["AgregarVale"].Activate();
            }
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            var listado = ProductosAll();
            CargarProductosGenerales(listado);
            selectProducto = true;
        }

        private void cargaProductosInit()
        {
            //  tablaProductos.Controls.Clear();
            CargarProductosGenerales(_listaProductos);
            selectProducto = true;
        }

        private void btncombos_Click(object sender, EventArgs e)
        {
            // tablaProductos.Controls.Clear();
            // CargaImgProductos(_listaProductos, false);
            CargarCombosGenerales(_listaCombos);
            selectProducto = false;
        }

        private void btnCatGenerico_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox PicCatGeneric = sender as PictureBox;
                var filtro = _listaProductos.Where(x => x.Categoria.Contains(PicCatGeneric.Name));
                var contadorproductos = _listaProductos.Count;
                dgvProductosBd.DataSource = filtro.ToList();
                selectProducto = true;
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error btnCatGenerico " + ex.Message);
            }
        }

        private void txtbuscarcombo_TextChanged(object sender, EventArgs e)
        {
            BuscarCombos();
        }

        private void txtbuscar2_TextChanged(object sender, EventArgs e)
        {
            BuscarProductos();
        }

        private void txtcodreferencia_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                var codigoReferencia = txtcodreferencia.Text.Trim();
                //var productox = listareducidaDebusquedal.Where(x => x.CodigoReferencia == codigoReferencia).FirstOrDefault();
                var productox = _productosRepository.GetProductByBarCode(codigoReferencia, UsuarioLogeadoPOS.User.SucursalId);
                // var comprobarEnTabla = new ComprobarExistenciaEnTabla(ListaProductSelect);

                if (productox == null) return;
                if (e.KeyCode == Keys.Enter)
                {
                    var detallefactura = GetDetalleFactura();
                    detallefactura.Cantidad = 1;
                    detallefactura.Descripcion = productox.Descripcion;
                    detallefactura.Precio = productox.PrecioVenta;
                    detallefactura.SubTotal = detallefactura.Cantidad * detallefactura.Precio;
                    detallefactura.ProductoId = productox.Id;
                    _listaDetalleFacturas.Add(detallefactura);
                    txtcodreferencia.Text = "";
                    cargarDGVDetalleFactura(_listaDetalleFacturas);
                }
            }
            catch (Exception ex)
            {

                KryptonMessageBox.Show("Error en Codigo de referencia" + ex.Message);
                return;
            }
        }

        private void BuscarProductos()
        {
            try
            {
                String txt = txtbuscar2.Text.ToUpper();
                var filter = _listaProductos.Where(a => a.Descripcion.Contains(txt));
                dgvProductosBd.DataSource = filter.ToList();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("BuscarProductos() ha fallado! " + ex.Message);
            }
        }

        private void BuscarCombos()
        {
            try
            {
                var filter = _listaCombos.Where(a => a.CodigoBarras != null && a.CodigoBarras.Contains(txtbuscarcombo.Text) ||
                           (a.Descripcion != null && a.Descripcion.Contains(txtbuscarcombo.Text))).ToList();
                dgvProductosBd.DataSource = filter.ToList();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("BuscarCombos() ha fallado! " + ex.Message);
            }
        }

        private void dgvproductosadd_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            KryptonMessageBox.Show("¡No se introdujo ningún valor valido en la celda!");
        }

        private void dgvproductosadd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {           
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                OperacionPorFila();
                SumaFilas();
            }            
        }

        private void dgvproductosadd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SumaFilas();
        }

        private void dgvproductosadd_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var fila = dgvproductosadd.CurrentRow;
            decimal ttal = 0.00m;
            ttal = Convert.ToDecimal(txttotalf.Text);
            ttal = ttal - Convert.ToDecimal(fila.Cells[8].Value);
            txttotalf.Text = ttal.ToString();
        }

        private void SumaFilas()
        {            
            try
            {
                decimal cantidad = 0.00m;
                if (dgvproductosadd.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvproductosadd.Rows)
                    {
                        cantidad = cantidad + Convert.ToDecimal(row.Cells[10].Value);
                    }                    
                }
                txttotalf.Text = cantidad.ToString();
            }
            catch (Exception io)
            {
                KryptonMessageBox.Show("Error en SumaFilas() " + io.Message);
            }            
        }

        private void dgvproductosadd_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            SumaFilas();
        }

        private void OperacionPorFila()
        {
            try
            {
                if (dgvproductosadd.CurrentRow.DataBoundItem != null)
                {
                    var filaActual = (ListarDetalleFacturas)dgvproductosadd.CurrentRow.DataBoundItem;
                    if (dgvproductosadd.CurrentCell.ColumnIndex == 6)
                    {
                        var prodtmp = _productosRepository.Get(filaActual.ProductoId);

                        if (prodtmp != null)
                        {
                            if (prodtmp.TieneEscalas)

                            {
                                decimal PrecioEscala = 0.00m;
                                var tipoprecio = _tipoPrecioRepository.Get(prodtmp.Id);
                                var detalles = _tipoPrecioRepository.GetDetallePrecios(tipoprecio.Id);
                                if (detalles.Count > 0)
                                {
                                    int TiposId = Convert.ToInt32(CbTipoCliente.ComboBox.SelectedValue);
                                    detalles = detalles.OrderBy(x => x.TiposId).ToList();
                                    foreach (DetallePrecio detalle in detalles)
                                    {
                                        if (detalle.TiposId == TiposId)
                                        {
                                            if (filaActual.Cantidad >= detalle.RangoInicio && filaActual.Cantidad <= detalle.RangoFinal)
                                            {
                                                PrecioEscala = detalle.Precio;
                                            }
                                        }
                                    }
                                    if (PrecioEscala > 0.01m)
                                    {
                                        filaActual.Precio = PrecioEscala;
                                        filaActual.SubTotal = filaActual.Cantidad * PrecioEscala;
                                        filaActual.PrecioTotal = filaActual.Cantidad * PrecioEscala;
                                    }
                                    else
                                    {
                                        filaActual.Precio = prodtmp.PrecioVenta;
                                        filaActual.SubTotal = filaActual.Cantidad * prodtmp.PrecioVenta;
                                        filaActual.PrecioTotal = filaActual.Cantidad * prodtmp.PrecioVenta;
                                    }
                                }
                                else
                                {
                                    filaActual.Precio = prodtmp.PrecioVenta;
                                    filaActual.SubTotal = filaActual.Cantidad * filaActual.Precio;
                                    filaActual.PrecioTotal = filaActual.SubTotal - filaActual.Descuento;
                                }

                                filaActual.SubTotal = filaActual.Cantidad * filaActual.Precio;
                                filaActual.PrecioTotal = filaActual.SubTotal - filaActual.Descuento;
                            }
                        }
                        else
                        {
                            filaActual.SubTotal = filaActual.Cantidad * filaActual.Precio;
                            filaActual.PrecioTotal = filaActual.SubTotal - filaActual.Descuento;
                        }
                    }
                    else
                    {
                        filaActual.SubTotal = filaActual.Cantidad * filaActual.Precio;
                        filaActual.PrecioTotal = filaActual.SubTotal - filaActual.Descuento;
                    }                  
  
                }

            }
            catch (Exception io)
            {
                KryptonMessageBox.Show("Error en SumaFilas() " + io.Message);
            }
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            if (dgvproductosadd.RowCount == 0)
            {
                KryptonMessageBox.Show("¡No hay productos agregados al listado!", "Notificación");
            }
            else
            {
                VentanaCajeroyVendedor();
            }
        }        

        public int validarDetalle(Producto producto)
        {
            int value = 0;
            if (producto.TieneColor == true && producto.TieneTalla == false)
            {
                //tiene solamente color
                value = 1;
            }
            else if (producto.TieneColor == false && producto.TieneTalla == true)
            {
                //tiene solamente talla
                value = 2;
            }
            else if (producto.TieneColor == true && producto.TieneTalla == true)
            {
                //tiene talla y color
                value = 3;
            }
            else if (producto.TieneEstilo == true)
            {
                //tiene estilo 
                value = 4;
            }
            else 
            {
                //no tiene ninguno
                value = 0;
            }
            return value;
        }

        private void VentanaCajeroyVendedor()
        {
            try
            {
                if (dgvproductosadd.RowCount <= 0) return;
                var listaErrores = new List<String>();
                var cadenadeError = "";
                var listaobtenidaDetalle = CrearListaBySelected(dgvproductosadd, 19);
                if (listaobtenidaDetalle.Count == 0) { KryptonMessageBox.Show("Debe seleccionar un producto a facturar"); return; }

                foreach (var item in _listaDetalleFacturas)
                {
                    if (!ValidarExistencias(item, false))
                    {
                        cadenadeError += "No hay suficiente stock del producto: "
                                      + item.Descripcion + " " + item.Color + " " + item.Talla + " " + "Revise existencias!\n";
                        listaErrores.Add(cadenadeError);
                        continue;
                    }
                }
                if (listaErrores.Count > 0)
                {
                    KryptonMessageBox.Show(cadenadeError);
                }
                else
                {
                    /*
                     * Administrador
                       Usuario Estandar
                       Solo Venta
                       Solo Caja
                       Solo POS
                       solo Administracion
                    */
                    if (UsuarioLogeadoPOS.User.Privilegios == "Solo Venta" || UsuarioLogeadoPOS.User.Privilegios == "Usuario Estandar" || UsuarioLogeadoPOS.User.Privilegios == "Solo POS")
                    {
                        CargarFormsAcumuladas(listaobtenidaDetalle);

                    }
                    if (UsuarioLogeadoPOS.User.Privilegios == "Administrador" || UsuarioLogeadoPOS.User.Privilegios == "Solo Caja")
                    {
                        CargarFormsPago(listaobtenidaDetalle);
                    }
                }
            }
            catch (IOException ex)
            {
                KryptonMessageBox.Show("Error en cobro " + ex.Message);
            }
        }

        private void CargarFormsPago(List<ListarDetalleFacturas> listaobtenidaDetalle)
        {
            if (Application.OpenForms["Pago"] != null) return;
            Pago childForm = new Pago(this, listaobtenidaDetalle, listadeVentasPendientes);
            childForm.Show();
        }

        private void CargarFormsAcumuladas(List<ListarDetalleFacturas> listaobtenidaDetalle)
        {
            if (Application.OpenForms["VentaAcumulada"] != null) return;
            VentaAcumulada childForm = new VentaAcumulada(this, listaobtenidaDetalle);
            childForm.Show();
        }

        public bool ValidarExistencias(ListarDetalleFacturas detallefactura, bool save = false)
        {
            int Cantidad = detallefactura.Cantidad;
            bool validacion = false;
            try
            {
                //validaciones de existencias para el producto
                if (detallefactura.ProductoId != 0)
                {
                    Producto producto = new Producto();
                    producto = _productosRepository.Get(detallefactura.ProductoId);
                  
                        if (producto.Stock > producto.stockMinimo)
                        {
                            int _stockRestante = producto.Stock - producto.stockMinimo;
                            //valida si hay sufiente stock 
                            if (_stockRestante >= Cantidad)
                            {
                                //si se quiere actualizar en la bd save debe ser true
                                if (save)
                                {
                                    //obtiene las propiedades del producto color/talla/color y talla
                                    int opc = validarDetalle(producto);

                                    switch (opc)
                                    {
                                        case 1:
                                            var listaobtenidaDetalleColor = _coloresRepository.GetProductoListaColor(producto.Id);
                                            var detalleColorToLess = listaobtenidaDetalleColor.Where(x => x.Id == detallefactura.DetalleColorId).FirstOrDefault();
                                            validacion = actualizarStock(Cantidad, detalleColorToLess, producto, 1);
                                            break;
                                        case 2:
                                            var listTallabyProducto = _tallasRepository.GetTallaListaProducto(producto.Id);
                                            var detalleTallaToLess = listTallabyProducto.Where(x => x.Id == detallefactura.DetalleTallaId).FirstOrDefault();
                                            validacion = actualizarStock(Cantidad, detalleTallaToLess, producto, 2);
                                            break;
                                        case 3:
                                            var tallasyColores = _tallasyColoresRepository.GetTallaColorListaProducto(producto.Id);
                                            var colorytallatoLess = tallasyColores.Where(x => x.Id == detallefactura.TallayColorId).FirstOrDefault();
                                            validacion = actualizarStock(Cantidad, colorytallatoLess, producto, 3);
                                            break;
                                        case 4:
                                            var estilos = _estiloRespository.GetProductoListaEstilo(producto.Id);
                                            var estilosToLess = estilos.Where(x => x.Id == detallefactura.EstiloId).FirstOrDefault();
                                            validacion = actualizarStock(Cantidad, estilosToLess, producto, 4);
                                            break;
                                        default:
                                            validacion = actualizarStock(Cantidad, null, producto, 0);
                                            break;
                                    }
                                }
                                //si no solo mostrara que si puede continuar pero que no seran acutalizada la info
                                else
                                {
                                    validacion = true;
                                }
                            }
                            else
                            {
                                validacion = false;
                            }
                        }
                        else if (producto.EsGrano)
                        {
                            DetalleGrano detalleGrano = _detalleGranoRepository.GetGranosProd(detallefactura.ProductoId);
                            ConvertirPeso peso = new ConvertirPeso();
                            if (save)
                            {
                                if (detallefactura.Descripcion.Contains("Q"))
                                {
                                    detalleGrano.Quintal -= detallefactura.Cantidad;
                                    detalleGrano.Libras = peso.ConvertirQLibra(detalleGrano.Quintal);
                                    detalleGrano.Onzas = peso.ConvertirQOnza(detalleGrano.Quintal);
                                }
                                else if (detallefactura.Descripcion.Contains("LB"))
                                {
                                    detalleGrano.Libras -= detallefactura.Cantidad;
                                    detalleGrano.Quintal = peso.ConvertirLQuintal(detalleGrano.Libras);
                                    detalleGrano.Onzas = peso.ConvertirLOnza(detalleGrano.Libras);
                                }
                                else if (detallefactura.Descripcion.Contains("ONZ"))
                                {
                                    detalleGrano.Onzas -= detallefactura.Cantidad;
                                    detalleGrano.Quintal = peso.ConvertirOQuintal(detalleGrano.Onzas);
                                    detalleGrano.Libras = peso.ConvertirOLibra(detalleGrano.Onzas);
                                }
                                _detalleGranoRepository.Update(detalleGrano);
                                validacion = true;
                            }
                            else
                            {
                                validacion = true;
                            }                           
                        }
                        else
                        {
                            validacion = false;
                        }
                  
                }
                else if (detallefactura.EsRecarga)
                {
                    if (save)
                    {
                        SaldoRecarga saldoRecarga = _recargasRepository.LastSaldoRecarga(UsuarioLogeadoPOS.User.SucursalId, detallefactura.Empresa);
                        DetalleRecarga detalleRecarga = _recargasRepository.GetDetalleRecarga(detallefactura.DetalleRecargaId);
                        SaldoRecarga saldo = new SaldoRecarga
                        {
                            SucursalId = UsuarioLogeadoPOS.User.SucursalId,
                            Empresa = detallefactura.Empresa,
                            SaldoInicial = saldoRecarga.SaldoActual,
                            Saldo = detallefactura.PrecioTotal,
                            SaldoActual = (saldoRecarga.SaldoActual - detallefactura.PrecioTotal),
                            FechaTransferencia = DateTime.Now
                        };
                        detalleRecarga.Estado = true;
                        _recargasRepository.UpdateDetalleRecarga(detalleRecarga);
                        _recargasRepository.AddSaldo(saldo);
                        validacion = true;
                    }
                    else
                    {
                        validacion = true;
                    }
                }
                //validaciones de existencias para los combos
                else if (detallefactura.ComboId != null)
                {
                    Combo ncombo = _combosRepository.Get(detallefactura.ComboId);
                    if (ncombo != null)
                    {
                        if (ncombo.Stock > Cantidad)
                        {
                            if (save)
                            {
                                var comboToLess = _combosRepository.Get(detallefactura.ComboId);
                                validacion = actualizarStock(Cantidad, comboToLess, null, 4);
                            }
                            else
                            {
                                validacion = true;
                            }
                        }
                        else
                        {
                            validacion = false;
                        }
                    }
                }                
            }
            catch (Exception io)
            {
                KryptonMessageBox.Show("Error en ValidarExistencias() " + io.Message);
                validacion = false;
            }
            return validacion;
        }

        public bool actualizarStock(int Cantidad, Object detalle, Producto producto, int opc)
        {
            bool actualizado = false;
            if (detalle != null)
            {
                switch (opc)
                {
                    case 1:
                        var _detalleC = (DetalleColor)detalle;
                        _detalleC.Stock -= Cantidad;
                        _coloresRepository.Update(_detalleC);
                        producto.Stock -= Cantidad;
                        _productosRepository.Update(producto);
                        actualizado = true;
                        break;
                    case 2:
                        var _detalleT = (DetalleTalla)detalle;
                        _detalleT.Stock -= Cantidad;
                        _tallasRepository.Update(_detalleT);
                        producto.Stock -= Cantidad;
                        _productosRepository.Update(producto);
                        actualizado = true;
                        break;
                    case 3:
                        var _detalleTC = (DetalleColorTalla)detalle;
                        _detalleTC.Stock -= Cantidad;
                        _tallasyColoresRepository.Update(_detalleTC);
                        producto.Stock -= Cantidad;
                        _productosRepository.Update(producto);
                        actualizado = true;
                        break;
                    case 4:
                        var _detalleE = (DetalleEstilo)detalle;
                        _detalleE.Stock -= Cantidad;
                        _estiloRespository.Update(_detalleE);
                        producto.Stock -= Cantidad;
                        _productosRepository.Update(producto);
                        actualizado = true;
                        break;
                    case 5:
                        var _combos = (Combo)detalle;
                        _combos.Stock -= Cantidad;
                        _combosRepository.Update(_combos);
                        actualizado = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if (producto != null)
                {
                    producto.Stock -= Cantidad;
                    _productosRepository.Update(producto);
                    actualizado = true;
                }
                else
                {
                    actualizado = false;
                }
            }

            return actualizado;
        }

        public List<ListarDetalleFacturas> CrearListaBySelected(DataGridView datagrid, int colAcciones)
        {
            var listaDetalles = new List<ListarDetalleFacturas>();
            foreach (DataGridViewRow rows in datagrid.Rows)
            {
                ListarDetalleFacturas fila = (ListarDetalleFacturas)rows.DataBoundItem;
                if (fila.Acciones)
                {
                    
                    listaDetalles.Add(fila);
                }
            }
            return listaDetalles;
        }

        private void btnborrarvale_Click(object sender, EventArgs e)
        {
            _valeSelected = null;
            cargarValeLabel();
        }

        private void dgvproductosadd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarFila(dgvproductosadd, 19);
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

        private void btnVentasPendientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VentasPendientes"] == null)
            {
                VentasPendientes VentasPendientesFACT = new VentasPendientes(this);

                VentasPendientesFACT.Show();
            }
            else
            {
                Application.OpenForms["VentasPendientes"].Activate();
            }

        }

        private bool VerificarExiste(int idProducto)
        {
            bool existe = false;
            
            foreach (DataGridViewRow row in dgvproductosadd.Rows)
            {
                if (Convert.ToInt32(row.Cells[10].Value) == idProducto)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        private void dgvproductosadd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvproductosadd.CurrentCell.ColumnIndex == 19)
                {
                    bool value = Convert.ToBoolean(dgvproductosadd.CurrentCell.Value);
                    if (value)
                    {
                        dgvproductosadd.CurrentCell.Value = false;
                    }
                    else
                    {
                        dgvproductosadd.CurrentCell.Value = true;
                    }
                }
            }
            catch (Exception ex)
            {

                KryptonMessageBox.Show(ex.Message);
            }
        }

       

        private void dgvProductosBd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                checkAll.Checked = false;
                if (selectProducto == true)
                {
                    var selectFila = (ListarProductos)dgvProductosBd.CurrentRow.DataBoundItem;

                    if (!VerificarExiste(Convert.ToInt32(selectFila.Id)))
                    {
                        var detallefactura = GetDetalleFactura();
                        detallefactura.Cantidad = 1;
                        detallefactura.Descripcion = selectFila.Descripcion;
                        detallefactura.Precio = selectFila.PrecioVenta;
                        detallefactura.SubTotal = detallefactura.Cantidad * detallefactura.Precio;
                        detallefactura.PrecioTotal = detallefactura.Cantidad * detallefactura.Precio;
                        detallefactura.ProductoId = selectFila.Id;
                        detallefactura.Acciones = checkAll.Checked;
                        if (detallefactura.Precio > 0 && selectFila.Stock > 0 || selectFila.Escalas)
                        {
                            if (selectFila.Escalas)
                            {
                                decimal Precio = ObtenerPrecio(selectFila.Id);
                                detallefactura.Precio = Precio;
                                detallefactura.SubTotal = Precio;
                                detallefactura.PrecioTotal = Precio;
                            }

                            if (selectFila.IncluyeColor == "Sí" && selectFila.Talla == "No")
                            {
                                //cargar list de color   
                                DetalleProductoVenta(1, detallefactura.ProductoId);
                            }
                            else if (selectFila.IncluyeColor == "No" && selectFila.Talla == "Sí")
                            {
                                //cargar list de talla
                                DetalleProductoVenta(2, detallefactura.ProductoId);
                            }
                            else if (selectFila.IncluyeColor == "Sí" && selectFila.Talla == "Sí")
                            {
                                //cargar listado de colores y tallas
                                DetalleProductoVenta(3, detallefactura.ProductoId);
                            }
                            else if (selectFila.Estilo == "Sí")
                            {
                                //cargar listado de estilos
                                DetalleProductoVenta(4, detallefactura.ProductoId);
                            }
                            else if (selectFila.EsGrano == "Sí")
                            {                                
                                if (Application.OpenForms["ProductoGrano"] == null)
                                {
                                    ProductoGrano productoGrano = new ProductoGrano(this, detallefactura.ProductoId);
                                    productoGrano.Show();
                                }
                                else
                                {
                                    Application.OpenForms["ProductoGrano"].Activate();
                                }
                            }
                            else
                            {
                                _listaDetalleFacturas.Add(detallefactura);
                                cargarDGVDetalleFactura(_listaDetalleFacturas);
                            }                            
                        }
                        else
                        {
                            KryptonMessageBox.Show("El producto contiene informacion que no es valida (precio/stock)\npor favor revisar el Detalle del Producto.");
                            return;
                        }
                    }
                    else
                    {
                        KryptonMessageBox.Show("¡El producto ya ha sido Agregado!");
                        return;
                    }
                }
                else
                {
                    var selectFila = (ListarCombos)dgvProductosBd.CurrentRow.DataBoundItem;
                    var detallefactura = GetDetalleFactura();
                    detallefactura.Cantidad = 1;
                    detallefactura.Descripcion = selectFila.Descripcion;
                    detallefactura.Precio = selectFila.Precioventa;
                    detallefactura.SubTotal = detallefactura.Cantidad * detallefactura.Precio;
                    detallefactura.ComboId = selectFila.IdCombo;
                    detallefactura.PrecioTotal = detallefactura.Cantidad * detallefactura.Precio;
                    _listaDetalleFacturas.Add(detallefactura);
                    cargarDGVDetalleFactura(_listaDetalleFacturas);
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error: dgvprodbd_Cellclick " + ex.Message);
            }
        }

        private decimal ObtenerPrecio(int id)
        {
            decimal PrecioEscala = 0.00m;
            int tipoClienteId = Convert.ToInt32(CbTipoCliente.ComboBox.SelectedValue.ToString());
            var tipoprecio = _tipoPrecioRepository.Get(id);
            List<DetallePrecio> detalles = new List<DetallePrecio>();
            if (tipoprecio != null)
            {
                detalles = _tipoPrecioRepository.GetDetallePrecios(tipoprecio.Id);
            }

            if (detalles.Count > 0)
            {
                detalles.OrderByDescending(x => x.TiposId);
                foreach (DetallePrecio detalle in detalles)
                {
                    if (detalle.TiposId == tipoClienteId)
                    {
                        if (1 >= detalle.RangoInicio && 1 <= detalle.RangoFinal)
                        {
                            PrecioEscala = detalle.Precio;
                        }
                    }
                }
            }
            return PrecioEscala;
        }

        private void DetalleProductoVenta(int opcion, int ProdId)
        {
            if (Application.OpenForms["DetalleProductos"] == null)
            {
                int tipoCliente = Convert.ToInt32(CbTipoCliente.ComboBox.SelectedValue);
                DetalleProductos sel = new DetalleProductos(opcion, this, ProdId, tipoCliente);
                sel.Show();
            }
            else
            {
                Application.OpenForms["DetalleProductos"].Activate();
            }
        }

        public void EliminarUltima()
        {
            int rows = dgvproductosadd.Rows.Count;
            if (rows > 0)
            {
                var lastRow = dgvproductosadd.Rows[rows - 1];
                var llastRow = _listaDetalleFacturas.LastOrDefault();

                dgvproductosadd.Rows.Remove(lastRow);
                _listaDetalleFacturas.Remove(llastRow);
            }
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {            
            try
            {
                int acciones = 19;
                if (checkAll.Checked == true)
                {
                    if (dgvproductosadd.RowCount > 0)
                    {
                        foreach (DataGridViewRow row in dgvproductosadd.Rows)
                        {
                            row.Cells[acciones].Value = true;
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvproductosadd.Rows)
                    {
                        row.Cells[acciones].Value = true;
                    }
                }
                dgvproductosadd.ClearSelection();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message);
            }
        }      

        private void dgVentasPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var filaObj = (ListarAcumuladasEncabezado)dgVentasPendientes.CurrentRow.DataBoundItem;
            ventaAcumuladaSelected = filaObj;
            if (ValidarRol())
            {
                if (!listadeVentasPendientes.Contains(ventaAcumuladaSelected))
                {
                    CargarDetalleToFactura(filaObj);
                    listadeVentasPendientes.Add(ventaAcumuladaSelected);
                }                    
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Calculadora"] == null)
            {
                Calculadora calc = new Calculadora();
                calc.Show();
            }
            else { Application.OpenForms["Calculadora"].Activate(); }
        }

        private void BtbRecargas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Recargas"] == null)
            {
                RecargasPOS recarga = new RecargasPOS(this);
                recarga.Show();
            }
            else 
            { 
                Application.OpenForms["Recargas"].Activate(); 
            }
        }

        private bool ValidarRol()
        {
            if (UsuarioLogeadoPOS.User.UserName == "admin@admin")
            {
                return true;
            }
            else { return false; }
        }

        private void CargarDetalleToFactura(ListarAcumuladasEncabezado encabezado)
        {
            Guid idSolicitud = encabezado.Id;
            var detalleObtenido = _solicitudesRepository.GetListaVentasAcumuladasbyUser(idSolicitud);
            if (detalleObtenido != null)
            {           
                cargarDGVDetalleFactura(GetSolicitudToFacturaDetalle(detalleObtenido));
            }
        }

        public void ActualizarDocumentos()
        {
            if (cotizaciones.Count() > 0)
            {
                foreach (ListarCotizaciones cotz in cotizaciones)
                {
                    Cotizacion cotizacion = _cotizacionRepository.GetCotizacion(cotz.Id);
                    if (cotizacion != null)
                    {
                        cotizacion.IsActive = true;
                        _cotizacionRepository.Updatecotizacion(cotizacion);
                    }
                }
            }
            if (pedidos.Count() > 0)
            {
                foreach (ListarPedidos ped in pedidos)
                {
                    Pedido pedido = _pedidoRepository.GetPedido(ped.Id);
                    if (pedido != null)
                    {
                        pedido.IsActive = true;
                        _pedidoRepository.UpdatePedido(pedido);
                    }                    
                }
            }
            if (vales.Count() > 0)
            {                
                foreach (ListarVales val in vales)
                {
                    Vale vale = _valesRepository.GetVale(val.Id);
                    if (val != null)
                    {
                        vale.IsActive = true;
                        _valesRepository.Update(vale);                        
                    }
                }
            }
        }

        private void CargarButtonsCategoria()
        {
            var listaCategoria = _categoriasProdRepository.GetListcategoria().Where(x => x.Estado == "Activa" && 
                                                                                         x.Categoria.ToUpper() != "RECARGAS").ToList();
            if (listaCategoria == null) { KryptonMessageBox.Show("Debera crear las categorias para continuar"); Close(); }
            var contadory = 0;
            
            float percent = 100 / listaCategoria.Count;
            tblEncabezadoCat.ColumnCount = listaCategoria.Count;
            foreach (var item in listaCategoria)
            {
                var buttonActual = CrearPictureCategory(item.Imagen, item.Categoria);
                var labelActual = CrearLabelCategory(item.Categoria.ToLower());
                tblEncabezadoCat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, percent));
                tblEncabezadoCat.Controls.Add(buttonActual, contadory, 0);
                tblEncabezadoCat.Controls.Add(labelActual, contadory, 1);
                contadory++;
            }
        }

        private void CbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvproductosadd.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvproductosadd.Rows)
                {
                    ListarDetalleFacturas det = (ListarDetalleFacturas)row.DataBoundItem;
                    if (det.ProductoId > 0)
                    {                        
                        PrecioEscala(det.ProductoId, row, 3);
                        //if (row.Cells[colDescuento].Value != null && row.Cells[colPrecio].Value != null)
                        //{
                        //    decimal RebajaD = Convert.ToDecimal(row.Cells[colRebajaD].Value);
                        //    if (RebajaD > 0.00m)
                        //    {
                        //        decimal subtotal = RebajaD * Convert.ToInt32(row.Cells[colCantidad].Value);
                        //        row.Cells[colPrecioD].Value = subtotal;
                        //        row.Cells[colSubtotal].Value = subtotal;
                        //    }
                        //}
                    }
                }
            }
        }

        private void PrecioEscala(int ProductoId, DataGridViewRow fila, int Index)
        {
            try
            {
                var prodtmp = _productosRepository.Get(ProductoId);
                if (fila != null)
                {
                    if (Index == 3)
                    {
                        if (prodtmp.TieneEscalas)
                        {
                            decimal PrecioEscala = 0.00m;
                            int Cantidad = Convert.ToInt32(fila.Cells[colCantidad].Value);
                            int tipoClienteId = Convert.ToInt32(CbTipoCliente.ComboBox.SelectedValue.ToString());
                            decimal precioActual = Convert.ToDecimal(fila.Cells[colPrecio].Value);
                            var tipoprecio = _tipoPrecioRepository.Get(prodtmp.Id);
                            List<DetallePrecio> detalles = new List<DetallePrecio>();
                            if (tipoprecio != null)
                            {
                                detalles = _tipoPrecioRepository.GetDetallePrecios(tipoprecio.Id);
                            }

                            if (detalles.Count > 0)
                            {
                                detalles = detalles.OrderByDescending(x => x.TiposId).ToList();
                                foreach (DetallePrecio detalle in detalles)
                                {
                                    if (detalle.TiposId == tipoClienteId)
                                    {
                                        if (Cantidad >= detalle.RangoInicio && Cantidad <= detalle.RangoFinal)
                                        {
                                            PrecioEscala = detalle.Precio;
                                        }
                                    }
                                }
                                if (PrecioEscala > 0.01m)
                                {
                                    fila.Cells[colPrecio].Value = PrecioEscala;
                                    fila.Cells[colSubtotal].Value = Cantidad * PrecioEscala;
                                    fila.Cells[colTotal].Value = Cantidad * PrecioEscala;
                                }
                                else
                                {
                                    fila.Cells[colPrecio].Value = prodtmp.PrecioVenta;
                                    fila.Cells[colSubtotal].Value = Cantidad * prodtmp.PrecioVenta;
                                    fila.Cells[colTotal].Value = Cantidad * prodtmp.PrecioVenta;
                                }
                            }
                            else
                            {
                                fila.Cells[colPrecio].Value = prodtmp.PrecioVenta;
                                fila.Cells[colSubtotal].Value = Cantidad * prodtmp.PrecioVenta;
                                fila.Cells[colTotal].Value = Cantidad * prodtmp.PrecioVenta;
                            }

                        }
                        else
                        {
                            fila.Cells[colPrecio].Value = prodtmp.PrecioVenta;
                            fila.Cells[colSubtotal].Value = Convert.ToInt32(fila.Cells[colCantidad].Value) * prodtmp.PrecioVenta;
                            fila.Cells[colTotal].Value = fila.Cells[colSubtotal].Value;
                        }
                    }
                    else
                    {
                        fila.Cells[colPrecio].Value = prodtmp.PrecioVenta;
                        fila.Cells[colSubtotal].Value = Convert.ToInt32(fila.Cells[colCantidad].Value) * prodtmp.PrecioVenta;
                        fila.Cells[colTotal].Value = fila.Cells[colSubtotal].Value;
                    }
                }
            }
            catch (Exception io)
            {
                KryptonMessageBox.Show("Error en escalas de precios " + io.Message);
            }
        }

        private PictureBox CrearPictureCategory(byte[] img, string name = "C")
        {
            MemoryStream mStream = new MemoryStream(img);
            Bitmap mybitmap = new Bitmap(mStream);
            mybitmap.MakeTransparent();
            PictureBox picture = new PictureBox
            {
                Dock = DockStyle.Fill,
                Location = new Point(2, 397),
                Margin = new Padding(1),
                Name = name,
                Size = new Size(118, 66),
                Image = mybitmap,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent
            };
            picture.Click += new EventHandler(this.btnCatGenerico_Click);
            return picture;
        }

        private Label CrearLabelCategory(string name = "C")
        {
            string c = name[0].ToString().ToUpper();
            string cat = c + name.Substring(1);
            Label label = new Label
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(1),
                TabIndex = 5,
                Text = cat,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 8)
            };
            return label;
        }
    }
}
