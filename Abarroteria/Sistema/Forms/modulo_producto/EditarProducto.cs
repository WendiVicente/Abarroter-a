using CapaDatos.ListasPersonalizadas;
using CapaDatos.Models.Precios;
using CapaDatos.Models.Productos;
using CapaDatos.Repository;
using CapaDatos.Repository.PreciosRepository;
using CapaDatos.Validation;
using ComponentFactory.Krypton.Toolkit;
using sharedDatabase.Models;
using sharedDatabase.Models.Proveedores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sistema.Forms.modulo_producto
{
    public partial class EditarProducto : BaseContext

    {
        private readonly ProductosRepository _productosRepository = null;
        private readonly ProveedoresRepository _proveedoresRepository = null;
        private readonly ClientesRepository _clientesRepository = null;
        private readonly ColoresRepository _detalleColor = null;
        private readonly TipoPrecioRepository _tipoPrecioRepository = null;
        private readonly TiposClienteRepository _tiposClienteRepository = null;
        private readonly TallasRepository _tallasRepository = null;
        private readonly DetalleEstiloRepository _estilosRepository = null;
        private readonly TallasyColoresRepository _tallasyColoresRepository = null;
        private readonly DetalleGranoRepository _granosRepository = null;
        // variables

        public int stockstockToValidar = 0;
        int ingreso;
        byte[] filefoto = null;
        public Producto _producto = null;
        //listas
        private List<ListarDetallePrecios> lista1 = null, lista2 = null, lista3 = null, lista4 = null, lista5 = null, listaPrecioDel = null;
        private List<DetallePrecio> _listaPreciosDel = new List<DetallePrecio>();
        private readonly ListaProductos _listaProductos;
        private Proveedor proveedor1 = new Proveedor();
        private DetalleGrano detallegrano = new DetalleGrano();
        //colores tallas y ambos

        public List<DetalleColor> _listacolores = new List<DetalleColor>();
        public List<DetalleColor> _listacoloresProd = new List<DetalleColor>();
        public List<DetalleColor> _listacoloresDel = new List<DetalleColor>();
        public List<DetalleTalla> _listaTallas = new List<DetalleTalla>();
        public List<DetalleTalla> _listaTallasProd = new List<DetalleTalla>();
        public List<DetalleTalla> _listaTallasDel = new List<DetalleTalla>();
        public List<DetalleEstilo> _detalleEstilos = new List<DetalleEstilo>();
        public List<DetalleEstilo> _listaEstilosProd = new List<DetalleEstilo>();
        public List<DetalleEstilo> _listaEstilosDel = new List<DetalleEstilo>();
        public List<DetalleColorTalla> _listaColorTallas = new List<DetalleColorTalla>();
        public List<DetalleColorTalla> _listaColorTallasDel = new List<DetalleColorTalla>();
        public int _idProducto = 0;
        public bool mostrarDetalle = false;
        const decimal ConversionQLb = 220.46m;
        const decimal ConversionQOnz = 3527.40m;
        const int ConversionLOnz = 16;
        int unidadGrano = 0;
        int opcionDetalle = 0;
        decimal sActual = 0.00m;
        decimal sNuevo = 0.00m;
        decimal sTotal = 0.00m;
        private bool ingresoValidacionDetalle { get; set; }

        public EditarProducto(Producto producto, ListaProductos listaProductos)
        {
            _listaProductos = listaProductos;
            _producto = producto;
            _detalleColor = new ColoresRepository(_context);

            _productosRepository = new ProductosRepository(_context);
            _tipoPrecioRepository = new TipoPrecioRepository(_context);
            _clientesRepository = new ClientesRepository(_context);
            _proveedoresRepository = new ProveedoresRepository(_context);
            _tiposClienteRepository = new TiposClienteRepository(_context);
            _tallasyColoresRepository = new TallasyColoresRepository(_context); //
            _estilosRepository = new DetalleEstiloRepository(_context);
            _tallasRepository = new TallasRepository(_context);
            _detalleColor = new ColoresRepository(_context);
            _granosRepository = new DetalleGranoRepository(_context);

            lista1 = new List<ListarDetallePrecios>();
            lista2 = new List<ListarDetallePrecios>();
            lista3 = new List<ListarDetallePrecios>();
            lista4 = new List<ListarDetallePrecios>();
            lista5 = new List<ListarDetallePrecios>();
            listaPrecioDel = new List<ListarDetallePrecios>();
            ingresoValidacionDetalle = false;
            InitializeComponent();
            cargarcombos();
        }

        public void CargarTextBoxs()
        {
            try
            {
                _idProducto = _producto.Id;
                nomproductotxt.Text = _producto.Descripcion;
                txtdescripcorta.Text = _producto.DescripcionCorta;
                puedeservendido.Checked = _producto.PermitirVenta;
                puedesercmprado.Checked = _producto.PermitirCompra;
                controlarstock.Checked = _producto.StockControl;
                checkColor.Checked = _producto.TieneColor;
                ubicaciontxt.Text = _producto.Ubicacion;
                codigoreferencia.Text = _producto.CodigoBarras;
                txtprecioventa.Text = _producto.PrecioVenta.ToString();
                costetxt.Text = _producto.Coste.ToString();
                StockNuevo.Text = _producto.Stock.ToString();
                notasinternas.Text = _producto.Notas;
                labelFechaingreso.Text = _producto.FechaIngreso.ToString();
                txtpreciomayorista.Text = _producto.PrecioMayorista.ToString();
                txtpreciocuentaclave.Text = _producto.PrecioCuentaClave.ToString();
                txtpreciogobierno.Text = _producto.PrecioEntidadGubernamental.ToString();
                txtpreciorevendedor.Text = _producto.PrecioRevendedor.ToString();
                stockstockToValidar = _producto.Stock;
                txtmarca.Text = _producto.Marca;
                txtnumeral.Text = _producto.Numeral;
                StockActual.Text = _producto.Stock.ToString();
                StockTotal.Text = _producto.Stock.ToString();
                checkGrano.Checked = _producto.EsGrano;
                checkEscala.Visible = !_producto.EsGrano;
                pnlGrano.Visible = _producto.EsGrano;
                pnlDetalle.Enabled = !_producto.EsGrano;
                checkEscala.Checked = _producto.TieneEscalas;
                groupEscala.Visible = _producto.TieneEscalas;
                groupPrecios.Visible = !_producto.TieneEscalas;
                btnAddPrecio.Visible = _producto.TieneEscalas;
                if (_producto.EsGrano)
                {
                    CargarGrano(_producto.UnidadMedida);
                }
                if (_producto.TieneEscalas)
                {                    
                    OcultarGrupos();
                }
                TraerEscalasPrecios();
                if (_producto.TieneColor == true && _producto.TieneTalla == false)
                {
                    TraerColor();
                }
                else if (_producto.TieneColor == false && _producto.TieneTalla == true)
                {
                    TraerTalla();
                }
                else if (_producto.TieneColor == true && _producto.TieneTalla == true)
                {
                    TraerTallayColor();
                }
                if (_producto.TieneEstilo == true)
                {
                    TraerEstilos();
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message);
            }
        }

        private void CargarGrano(string unidadMedida)
        {
            detallegrano = _granosRepository.GetGranosProd(_producto.Id);
            switch (unidadMedida)
            {
                case "q":
                    StockActual.Text = detallegrano.Quintal.ToString();
                    StockTotal.Text = detallegrano.Quintal.ToString();
                    CheckQuintal.Checked = true;
                    break;
                case "lb":
                    StockActual.Text = detallegrano.Libras.ToString();
                    StockTotal.Text = detallegrano.Libras.ToString();
                    CheckLibra.Checked = true;
                    break;
                case "onz":
                    StockActual.Text = detallegrano.Onzas.ToString();
                    StockTotal.Text = detallegrano.Onzas.ToString();
                    CheckOnza.Checked = true;
                    break;
            }
        }

        public void TraerColor()
        {
            if (_detalleColor.GetColor(_producto.Id) != null)
            {
                var productodetalleColor = _detalleColor.GetProductoListaColor(_producto.Id);
                StockNuevo.Text = productodetalleColor.Sum(x => x.Stock).ToString();
                _listacolores = productodetalleColor;
            }
        }
        public void TraerTalla()
        {
            if (_tallasRepository.GetTallaListaProducto(_producto.Id) != null)
            {
                var productodetalleTalla = _tallasRepository.GetTallaListaProducto(_producto.Id);
                StockNuevo.Text = productodetalleTalla.Sum(x => x.Stock).ToString();
                _listaTallas = productodetalleTalla;
            }
        }
        public void TraerTallayColor()
        {
            if (_tallasyColoresRepository.GetTallaColorListaProducto(_producto.Id) != null)
            {
                var listatallaycolorbyproduc = _tallasyColoresRepository.GetTallaColorListaProducto(_producto.Id);
                StockNuevo.Text = listatallaycolorbyproduc.Sum(x => x.Stock).ToString();
                _listaColorTallas = listatallaycolorbyproduc;
            }
        }
        public void TraerEstilos()
        {
            if (_estilosRepository.GetProductoListaEstilo(_producto.Id) != null)
            {
                var listaestilos = _estilosRepository.GetProductoListaEstilo(_producto.Id);
                StockNuevo.Text = listaestilos.Sum(x => x.Stock).ToString();
                _detalleEstilos = listaestilos.ToList();
            }
        }

        private void TraerEscalasPrecios()
        {
            if (_producto.TieneEscalas != false)
            {
                var tipo = _tipoPrecioRepository.Get(_producto.Id);
                if (tipo != null)
                {
                    var detalleprecioslista = _tipoPrecioRepository.GetDetallePrecioListar(tipo.Id, 0);
                    if (detalleprecioslista != null)
                    {
                        foreach (var item in detalleprecioslista)
                        {
                            var tipoObtendio = _tiposClienteRepository.GetTipo(item.TiposId);
                            if (tipoObtendio.TipoCliente == "Mayorista")
                            {
                                lista1.Add(item);
                            }
                            if (tipoObtendio.TipoCliente == "Minorista")
                            {
                                lista2.Add(item);
                            }
                            if (tipoObtendio.TipoCliente == "Cuenta Clave")
                            {
                                lista3.Add(item);
                            }
                            if (tipoObtendio.TipoCliente == "Revendedor")
                            {
                                lista4.Add(item);
                            }
                            if (tipoObtendio.TipoCliente == "Gubernamental")
                            {
                                lista5.Add(item);
                            }
                        }

                        cargarDGVPrecios(lista1, dgvmayorista);
                        cargarDGVPrecios(lista2, Dgvunitario);
                        cargarDGVPrecios(lista3, dgvcuentaclave);
                        cargarDGVPrecios(lista4, dgvrevendedor);
                        cargarDGVPrecios(lista5, dgvgubernamental);

                    }

                }

            }

        }
        private void cargarDGVPrecios(List<ListarDetallePrecios> lista, DataGridView datag)
        {
            BindingSource source = new BindingSource();

            source.DataSource = lista;
            datag.DataSource = typeof(List<>);
            datag.DataSource = source;
            datag.AutoResizeColumns();
            datag.Columns[0].Visible = false;
            datag.Columns[1].Visible = false;

        }

        private void cargarcombos()
        {

            OcultarMovimiento();
            OcultarAlertaStock();
            CargarEscala();
            CargarTipos();
            //OcultarGrupos();
            Cargarproveedores();

        }

        private void cargarCategoria()
        {

            categoriaprod.DataSource = _productosRepository.GetCategoriasList();
            categoriaprod.DisplayMember = "Nombre";
            categoriaprod.ValueMember = "Id";
            categoriaprod.SelectedValue = _producto.CategoriaId;
            categoriaprod.Invalidate();


        }

        private void cargarImg()
        {
            if (_producto.Imagen == null) { return; }
            byte[] imageData = _producto.Imagen;
            MemoryStream mStream = new MemoryStream(imageData);
            pBox.Image = Image.FromStream(mStream);
            filefoto = imageData;
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            CargarTextBoxs();
            cargarCategoria();
            Ocultarcolor();
            cargarImg();
            CargarCheck();
        }

        private void CargarCheck()
        {
            mostrarDetalle = false;
            if (_producto.TieneColor && _producto.TieneTalla)
            {
                rdcolorytalla.Checked = true;
            }
            else if (_producto.TieneColor == false && _producto.TieneTalla == true)
            {
                checktalla.Checked = true;
            }
            else if (_producto.TieneColor == true && !_producto.TieneTalla == false)
            {
                checkColor.Checked = true;
            }
            else if (_producto.TieneEstilo)
            {
                checkEstilo.Checked = true;
            }
            mostrarDetalle = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = _productosRepository.Get(_producto.Id);
                proveedor1 = _proveedoresRepository.Get(Convert.ToInt32(cbproveedor.SelectedValue.ToString()));
                var GetProducto = GetModelProducto(producto);               
                
                if (!ModelState.IsValid(GetProducto)) return;
                GuardarDetallesProducto(GetProducto);
                _productosRepository.Update(GetProducto);

                GuardarTipoyDetalles(GetProducto);
                GuardarDetalleGrano(GetProducto);
                _listaProductos.RefrescarDataGridProductos(true);

                Close();
            }
            catch (Exception ex)
            {

                KryptonMessageBox.Show(ex.Message);
            }
        }

        private void GuardarDetallesProducto(Producto producto)
        {
            switch (opcionDetalle)
            {
                case 1:
                    guardarColores(producto);
                    producto.TieneColor = true;
                    producto.TieneTalla = false;
                    producto.TieneEstilo = false;
                    break;
                case 2:
                    guardarTallas(producto);
                    producto.TieneTalla = true;
                    producto.TieneColor = false;
                    producto.TieneEstilo = false;
                    break;
                case 3:
                    guardarColoresTallas(producto);
                    producto.TieneColor = true;
                    producto.TieneTalla = true;
                    producto.TieneEstilo = false;
                    break;
                case 4:
                    guardarEstilos(producto);
                    producto.TieneEstilo = true;
                    producto.TieneColor = false;
                    producto.TieneTalla = false;
                    break;
            }
        }

        private void GuardarDetalleGrano(Producto producto)
        {
            if (checkGrano.Checked)
            {
                var detalleg = _granosRepository.GetGranosProd(producto.Id);
                switch (unidadGrano)
                {
                    case 1:
                        detalleg.Quintal = producto.StockGrano;
                        detalleg.Libras = ConvertirOLibra(producto.StockGrano);
                        detalleg.Onzas = ConvertirQOnza(producto.StockGrano);
                        break;
                    case 2:
                        detalleg.Libras = producto.StockGrano;
                        detalleg.Quintal = ConvertirLQuintal(producto.StockGrano);
                        detalleg.Onzas = ConvertirLOnza(producto.StockGrano);
                        break;
                    case 3:
                        detalleg.Onzas = producto.StockGrano;
                        detalleg.Quintal = ConvertirOQuintal(producto.StockGrano);
                        detalleg.Libras = ConvertirOLibra(producto.StockGrano);
                        break;
                }

                if (detalleg != null)
                {                    
                    _granosRepository.Update(detalleg);
                }
            }
        }

        public void guardarColores(Producto producto)
        {
            if (_listacoloresProd.Count > 0)
            {
                producto.TieneColor = true;
                foreach (DetalleColor dc in _listacoloresProd)
                {
                    if (!ModelState.IsValid(dc)) return;
                    var detalleColor = _detalleColor.GetDetalleColor(dc.Id);
                    if (detalleColor != null)
                    {
                        detalleColor.Stock = dc.Stock;
                        _detalleColor.Update(detalleColor);
                    }
                    else
                    {
                        _detalleColor.Add(dc);
                    }
                }
            }
            eliminarColores();

        }

        public void guardarTallas(Producto producto) {
            if (_listaTallasProd.Count > 0)
            {
                producto.TieneTalla = true;
                foreach (DetalleTalla dt in _listaTallasProd)
                {
                    if (!ModelState.IsValid(dt)) return;
                    var detalleTalla = _tallasRepository.GetDetalleTalla(dt.Id);
                    if (detalleTalla != null)
                    {
                        detalleTalla.Stock = dt.Stock;
                        _tallasRepository.Update(detalleTalla);
                    }
                    else
                    {
                        _tallasRepository.Add(dt);
                    }
                }
            }
            eliminarTallas();
        }

        public void guardarColoresTallas(Producto producto)
        {

            if (_listaColorTallas.Count > 0)
            {
                producto.TieneColor = true;
                producto.TieneTalla = true;
                foreach (DetalleColorTalla dct in _listaColorTallas)
                {
                    if (!ModelState.IsValid(dct)) return;
                    var detalleColorTalla = _tallasyColoresRepository.GetColorTalla(dct.Id);
                    if (detalleColorTalla != null)
                    {
                        detalleColorTalla.Stock = dct.Stock;
                        _tallasyColoresRepository.Update(detalleColorTalla);
                    }
                    else
                    {
                        _tallasyColoresRepository.Add(dct);
                    }
                }
            }
            eliminarColoresTallas();
        }
        
        public void guardarEstilos(Producto producto)
        {
            if (_listaEstilosProd.Count > 0)
            {
                producto.TieneEstilo = true;
                foreach (DetalleEstilo estilo in _listaEstilosProd)
                {
                    if (!ModelState.IsValid(estilo)) return;
                    var detalleEstilo = _estilosRepository.GetDetalleEstilo(estilo.Id);
                    if (detalleEstilo != null)
                    {
                        detalleEstilo.Stock = estilo.Stock;
                        _estilosRepository.Update(detalleEstilo);
                    }
                    else
                    {
                        _estilosRepository.Add(estilo);
                    }
                }
            }
            eliminarEstilos();
        }

        private void eliminarColores()
        {
            if (_listacoloresDel.Count > 0)
            {
                foreach (DetalleColor dc in _listacoloresDel)
                {
                    if (!ModelState.IsValid(dc)) return;
                    _detalleColor.DeleteDetalleColor(dc);
                }
            }
        }

        private void eliminarTallas()
        {
            if (_listaTallasDel.Count > 0)
            {
                foreach (DetalleTalla dt in _listaTallasDel)
                {
                    if (!ModelState.IsValid(dt)) return;
                    _tallasRepository.DeleteDetalleTalla(dt);
                }
            }
        }

        private void eliminarColoresTallas()
        {
            if (_listaColorTallasDel.Count > 0)
            {
                foreach (DetalleColorTalla dt in _listaColorTallasDel)
                {
                    if (!ModelState.IsValid(dt)) return;
                    _tallasyColoresRepository.DeleteDetalleTallaColor(dt);
                }
            }
        }

        private void eliminarEstilos()
        {
            if (_listaEstilosDel.Count > 0)
            {
                foreach (DetalleEstilo dt in _listaEstilosDel)
                {
                    if (!ModelState.IsValid(dt)) return;
                    _estilosRepository.DeleteDetalleEstilo(dt);
                }
            }
        }

        public Producto GetModelProducto(Producto producto)
        {

            producto.CodigoBarras = codigoreferencia.Text;
            producto.ProveedorId = Convert.ToInt32(cbproveedor.SelectedValue.ToString());
            producto.CategoriaId = Convert.ToInt32(categoriaprod.SelectedValue.ToString());
            producto.Descripcion = nomproductotxt.Text;
            producto.DescripcionCorta = txtdescripcorta.Text;
            producto.PermitirVenta = puedeservendido.Checked;
            producto.PermitirCompra = puedesercmprado.Checked;
            producto.StockControl = controlarstock.Checked;
            producto.Ubicacion = ubicaciontxt.Text;
            producto.PrecioVenta = Convert.ToDecimal(txtprecioventa.Text);
            producto.Coste = Convert.ToDecimal(costetxt.Text);
            if (!producto.EsGrano)
            {
                producto.Stock = Convert.ToInt32(StockTotal.Text);
                producto.StockGrano = 0.00m;
            }
            else
            {
                producto.StockGrano = Convert.ToDecimal(StockTotal.Text);
                producto.Stock = 0;
            }
            producto.Notas = notasinternas.Text;
            producto.PrecioRevendedor = Convert.ToDecimal(txtpreciorevendedor.Text);
            producto.PrecioMayorista = Convert.ToDecimal(txtpreciomayorista.Text);
            producto.PrecioEntidadGubernamental = Convert.ToDecimal(txtpreciogobierno.Text);
            producto.PrecioCuentaClave = Convert.ToDecimal(txtpreciocuentaclave.Text);
            producto.FechaModificacion = DateTime.Now;
            producto.Imagen = filefoto;
            producto.Proveedor = proveedor1;
            producto.Utilidad = producto.Utilidad;
            producto.Marca = txtmarca.Text;
            producto.Numeral = txtnumeral.Text;
            producto.UnidadMedida = txtunidadmedida.Text;
            producto.TieneEscalas = checkEscala.Checked;
            return producto;
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.Filter = "Archivos JPG (*.jpg)|*.jpg| Archivos png(*.png)|*.png";
            DialogResult filestream = imagen.ShowDialog();

            if (filestream == DialogResult.OK)
            {
                pBox.Image = Image.FromFile(imagen.FileName);

                filestreamImagen();
            }
        }

        private void filestreamImagen()
        {
            filefoto = null;
            MemoryStream memoryStream = new MemoryStream();
            pBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            memoryStream.GetBuffer();
            filefoto = memoryStream.GetBuffer();

        }

        private void Cargarproveedores()
        {
            try
            {
                cbproveedor.DataSource = _proveedoresRepository.GetList();
                cbproveedor.DisplayMember = "Nombre";
                cbproveedor.ValueMember = "Id";
                cbproveedor.SelectedValue = _producto.ProveedorId;
                cbproveedor.Invalidate();
            }
            catch (Exception ex)
            {

                KryptonMessageBox.Show("no hay ningun proveedor,deberá ingresar uno", ex.Message);
            }

        }

        private void OcultarForm()
        {
            AgregarColorEdit formColor = null;
            AgregarTallaEdit formTalla = null;
            AgregarEstiloEdit formEstilo = null;
            AgregarColorTallaEdit formColorTalla = null;


            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(AgregarColorEdit))
                {
                    formColor = (AgregarColorEdit)frm;
                }
                if (frm.GetType() == typeof(AgregarTallaEdit))
                {
                    formTalla = (AgregarTallaEdit)frm;
                }
                if (frm.GetType() == typeof(AgregarColorTallaEdit))
                {
                    formColorTalla = (AgregarColorTallaEdit)frm;
                }
                if (frm.GetType() == typeof(AgregarEstiloEdit))
                {
                    formEstilo = (AgregarEstiloEdit)frm;
                }
            }

            if (formColor != null)
            {
                formColor.Close();
            }
            if (formTalla != null)
            {
                formTalla.Close();
            }
            if (formColorTalla != null)
            {
                formColorTalla.Close();
            }
            if (formEstilo != null)
            {
                formEstilo.Close();
            }
        }

        private void Ocultarcolor()
        {
            //lbColor.Visible = false;
            //txtColor.Visible = false;
            //txtColor.Text = "";
        }

        private void OcultarAlertaStock()
        {

            lbcantidadmin.Visible = false;
            txtcantidadmin.Visible = false;

        }

        private void OcultarMovimiento()
        {
            rbcuatro.Visible = false;
            rbochosem.Visible = false;
            rbpersonal.Visible = false;
            Ocultartiempos();
        }

        private void OcultarGrupos()
        {
            if (checkEscala.Checked == true)
            {
                groupEscala.Visible = true;
                btnAddPrecio.Visible = true;
            }
            else
            {
                groupEscala.Visible = false;
                btnAddPrecio.Visible = false;
            }
        }

        private void Ocultartiempos()
        {
            dtpfechafinal.Visible = false;
            dtpfechainicio.Visible = false;
            lbfechafinal.Visible = false;
            lbfechainicio.Visible = false;
        }



        private void VerTiempos()
        {
            dtpfechafinal.Visible = true;
            dtpfechainicio.Visible = true;
            lbfechafinal.Visible = true;
            lbfechainicio.Visible = true;

        }

        private void VerMovimiento()
        {
            rbcuatro.Visible = true;
            rbochosem.Visible = true;
            rbpersonal.Visible = true;

        }

        private void CargarTipos()
        {
            var tipos = _clientesRepository.GetTipos();

            cbTiposClientes.DataSource = tipos;
            cbTiposClientes.DisplayMember = "TipoCliente";
            cbTiposClientes.ValueMember = "Id";
            //cbsucursales.Text = "Seleccione una Sucursal"; 
            cbTiposClientes.SelectedIndex = 0;
            cbTiposClientes.Invalidate();
        }

        private void CargarEscala()
        {
            cbEscala.Items.Insert(0, "E1");
            cbEscala.Items.Insert(1, "E2");
            cbEscala.Items.Insert(2, "E3");
            cbEscala.Items.Insert(3, "E4");
            cbEscala.SelectedIndex = 0;
        }

        private ListarDetallePrecios GetDetallePreciosModel()
        {
            var DetallePrecios = new ListarDetallePrecios()
            {
                Id = Guid.NewGuid(),
                Escala = cbEscala.Text,
                Precio = decimal.Parse(txtprecioVar.Text),
                Tipos = cbTiposClientes.Text, //
                TiposId = int.Parse(cbTiposClientes.SelectedValue.ToString()),
                RangoFinal = int.Parse(txtRangoFinal.Text),
                RangoInicio = int.Parse(txtRangoInic.Text),
            };
            return DetallePrecios;
        }

        public void RefrescarDetallePrecios(DataGridView data, List<ListarDetallePrecios> lista)
        {
            BindingSource source = new BindingSource();
            source.DataSource = lista;
            data.DataSource = typeof(List<>);
            data.DataSource = source;
            data.AutoResizeColumns();
            data.Columns[0].Visible = false;
            data.Columns[1].Visible = false;
            data.ClearSelection();
        }

        private void AllCheckFalse()
        {
            checkColor.Checked = false;
            checktalla.Checked = false;
            rdcolorytalla.Checked = false;
            checkEstilo.Checked = false;
        }

        private bool ValidacionesDetalle(int detalle)
        {
            if (string.IsNullOrEmpty(StockNuevo.Text) || int.Parse(StockNuevo.Text) <= 0)
            {
                if (ingreso == 0)
                {
                    KryptonMessageBox.Show("Por favor ingrese el stock, antes de continuar..");
                    ingreso += 1;
                    AllCheckFalse();
                    return false;
                }
                AllCheckFalse();
            }

           return validarListadosDetalle(detalle);
        }

        private void checkcolorPropertis()
        {     
            if (checkColor.Checked == true && ValidacionesDetalle(1))
            {
                ingreso = 0;
                if (_listacolores == null)
                {
                    _listacolores = new List<DetalleColor>();
                }
                if (Application.OpenForms["AgregarColorEdit"] == null)
                {
                    _listacolores = _detalleColor.GetProductoListaColor(_producto.Id);
                    AgregarColorEdit agregarColor = new AgregarColorEdit(this, _listacolores);
                    agregarColor.Show();
                    ingresoValidacionDetalle = false;
                }
                else { Application.OpenForms["AgregarColorEdit"].Activate(); }
            }
            else
            {
                _listacolores.Clear();
            }
        }

        private void checktallaPropertis()
        {
            if (checktalla.Checked == true && ValidacionesDetalle(2))
            {
                ingreso = 0;
                if (_listaTallas == null)
                {
                    _listaTallas = new List<DetalleTalla>();
                }
                if (Application.OpenForms["AgregarTallaEdit"] == null)
                {
                    _listaTallas = _tallasRepository.GetTallaListaProducto(_producto.Id);
                    AgregarTallaEdit agregarTalla = new AgregarTallaEdit(this, _listaTallas);
                    agregarTalla.Show();
                    ingresoValidacionDetalle = false;
                }
                else { Application.OpenForms["AgregarTallaEdit"].Activate(); }
            }
            else
            {
                _listaTallas.Clear();
            }
        }

        private void checkcolorytallaProperties()
        {
            if (rdcolorytalla.Checked == true && ValidacionesDetalle(3))
            {
                ingreso = 0;
                if (_listaColorTallas == null)
                {
                    _listaColorTallas = new List<DetalleColorTalla>();
                }

                if (Application.OpenForms["AgregarColorTallaEdit"] == null)
                {
                    _listaColorTallas = _tallasyColoresRepository.GetTallaColorListaProducto(_producto.Id);
                    AgregarColorTallaEdit agregarColorTalla = new AgregarColorTallaEdit(this, _listaColorTallas);
                    agregarColorTalla.Show();
                    ingresoValidacionDetalle = false;
                }
                else
                { Application.OpenForms["AgregarColorTallaEdit"].Activate(); }
            }
            else
            {
                _listaColorTallas.Clear();
            }
        }


        private void checkEstilos()
        {
            if (checkEstilo.Checked == true && ValidacionesDetalle(4))
            {
                ingreso = 0;
                if (_detalleEstilos == null)
                {
                    _detalleEstilos = new List<DetalleEstilo>();
                }

                if (Application.OpenForms["AgregarEstiloEdit"] == null)
                {
                    _detalleEstilos = _estilosRepository.GetProductoListaEstilo(_producto.Id);
                    AgregarEstiloEdit agregarEstilo = new AgregarEstiloEdit(this, _detalleEstilos);
                    agregarEstilo.Show();
                    ingresoValidacionDetalle = false;
                }
                else
                { Application.OpenForms["AgregarEstiloEdit"].Activate(); }
            }
            else
            {
                _detalleEstilos.Clear();
            }
        }

        private void checkColor_CheckedChanged(object sender, EventArgs e)
        {

            if (checkColor.Checked && mostrarDetalle)
            {
                opcionDetalle = 1;
                checkcolorPropertis();
                mostrarDetalle = false;

            }
            else
            {
                OcultarForm();
                mostrarDetalle = true;

            }
        }

        private void checktalla_CheckedChanged(object sender, EventArgs e)
        {
            if (checktalla.Checked && mostrarDetalle)
            {
                opcionDetalle = 2;
                checktallaPropertis();
                mostrarDetalle = false;
            }
            else
            {
                OcultarForm();
                mostrarDetalle = true;
            }
        }

        private void rdcolorytalla_CheckedChanged(object sender, EventArgs e)
        {
            if (checktalla.Checked && mostrarDetalle)
            {
                opcionDetalle = 3;
                checkcolorytallaProperties();
                mostrarDetalle = false;

            }
            else
            {
                OcultarForm();
                mostrarDetalle = true;
            }
        }

        private void checkEstilo_CheckedChanged(object sender, EventArgs e)
        {
            if (checktalla.Checked && mostrarDetalle)
            {
                opcionDetalle = 4;
                checkEstilos();
                mostrarDetalle = false;
            }
            else
            {
                OcultarForm();
                mostrarDetalle = true;
            }
        }

        private void checkColor_Click(object sender, EventArgs e)
        {
            if(mostrarDetalle)
                checkcolorPropertis();
        }

        private void checktalla_Click(object sender, EventArgs e)
        {
            if (mostrarDetalle)
                checktallaPropertis();
        }

        private void rdcolorytalla_Click(object sender, EventArgs e)
        {
            if (mostrarDetalle)
                checkcolorytallaProperties();
        }

        private void checkEstilo_Click(object sender, EventArgs e)
        {
            if (mostrarDetalle)
                checkEstilos();
        }

        private bool validarListadosDetalle(int check)
        {
            bool validacion = true;   
            //if(ingresoValidacionDetalle)
            //{ return true; }
            var dtallacolortmp = _tallasyColoresRepository.GetTallaColorListaProducto(_producto.Id);
            var dtallastmp = _tallasRepository.GetTallaListaProducto(_producto.Id);
            var dcolortmp = _detalleColor.GetProductoListaColor(_producto.Id);
            var destilos = _estilosRepository.GetProductoListaEstilo(_producto.Id);

            //validacion para eliminar la informacion de color 
            if (dcolortmp.Count > 0 && check != 1)
            {
                DialogResult dialogResult = KryptonMessageBox.Show("Se ha encontrado un listado en Color, si continua con el proceso se eliminará.\n¿Desea Continuar?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _listacoloresDel = dcolortmp;
                    eliminarColores();
                    validacion = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    validacion = false;
                    AllCheckFalse();
                }
            }

            //validacion para eliminar la informacion de talla
            if (dtallastmp.Count > 0 && check != 2)
            {
                DialogResult dialogResult = KryptonMessageBox.Show("Se ha encontrado un listado en Talla, si continua con el proceso se eliminará.\n¿Desea Continuar?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _listaTallasDel = dtallastmp;
                    eliminarTallas();
                    validacion = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    validacion = false;
                    AllCheckFalse();
                }
            }

            //validacion para eliminar la informacion de talla/color 
            if (dtallacolortmp.Count > 0 && check != 3)
            {
                DialogResult dialogResult = KryptonMessageBox.Show("Se ha encontrado un listado en Talla y Color, si continua con el proceso se eliminará.\n¿Desea Continuar?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _listaColorTallasDel = dtallacolortmp;
                    eliminarColoresTallas();
                    validacion = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    validacion = false;
                    AllCheckFalse();
                }
            }

            //validacion para eliminar informacion de estilos 
            if (destilos.Count > 0 && check != 4)
            {
                DialogResult dialogResult = KryptonMessageBox.Show("Se ha encontrado un listado en Estilos, si continua con el proceso se eliminará.\n¿Desea Continuar?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _detalleEstilos = destilos;
                    eliminarEstilos();
                    validacion = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    validacion = false;
                    AllCheckFalse();
                }
            }

            //ingresoValidacionDetalle = true;
            return validacion;
        }

        private void checkEscala_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEscala.Checked == false)
            {
                groupEscala.Visible = false;
                groupPrecios.Visible = true;
                btnAddPrecio.Visible = false;
            }
            else
            {
                groupPrecios.Visible = false;
                groupEscala.Visible = true;
                btnAddPrecio.Visible = true;
            }
        }

        public bool comprobarEscala(DataGridView dataGrid, ListarDetallePrecios detallePrecio, int opc)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[3].Value.ToString() == detallePrecio.Escala)
                {
                    if (opc == 1)
                    {
                        KryptonMessageBox.Show("¡La escala ya existe!");
                    }
                    return true;
                }
            }

            return false;
        }

        private void btnAddPrecio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtprecioVar.Text) || decimal.Parse(txtprecioVar.Text) <= 0)
            {
                KryptonMessageBox.Show("Debe ingresar un Precio valido para continuar");
                return;
            }
            if (cbTiposClientes.Text == "Minorista")
            {
                var Detalle1 = GetDetallePreciosModel();
                if (!comprobarEscala(Dgvunitario, Detalle1, 1))
                {
                    obtenerPrecioIngresado(lista1, Detalle1);
                    RefrescarDetallePrecios(Dgvunitario, lista1);
                }
            }
            if (cbTiposClientes.Text == "Mayorista")
            {
                var Detalle2 = GetDetallePreciosModel();
                if (!comprobarEscala(dgvmayorista, Detalle2, 1))
                {
                    obtenerPrecioIngresado(lista2, Detalle2);
                    RefrescarDetallePrecios(dgvmayorista, lista2);
                }


            }
            if (cbTiposClientes.Text == "Cuenta Clave")
            {
                var Detalle3 = GetDetallePreciosModel();
                if (!comprobarEscala(dgvcuentaclave, Detalle3, 1))
                {
                    obtenerPrecioIngresado(lista3, Detalle3);
                    RefrescarDetallePrecios(dgvcuentaclave, lista3);
                }


            }
            if (cbTiposClientes.Text == "Revendedor")
            {
                var Detalle4 = GetDetallePreciosModel();
                if (!comprobarEscala(dgvrevendedor, Detalle4, 1))
                {
                    obtenerPrecioIngresado(lista4, Detalle4);
                    RefrescarDetallePrecios(dgvrevendedor, lista4);
                }
            }
            if (cbTiposClientes.Text == "Gubernamental")
            {
                var Detalle5 = GetDetallePreciosModel();
                if (!comprobarEscala(dgvgubernamental, Detalle5, 1))
                {
                    obtenerPrecioIngresado(lista5, Detalle5);
                    RefrescarDetallePrecios(dgvgubernamental, lista5);
                }
            }
        }

        private void obtenerPrecioIngresado(List<ListarDetallePrecios> listado, ListarDetallePrecios detalleP)
        {
            if (listaPrecioDel.Count > 0)
            {
                var _tmp = listaPrecioDel.Where(x => x.Escala == detalleP.Escala && x.Tipos == detalleP.Tipos);
                if (_tmp.Count() > 0)
                {
                    var tmp = _tmp.ElementAt(0);
                    tmp.Precio = detalleP.Precio;
                    tmp.RangoInicio = detalleP.RangoInicio;
                    tmp.RangoFinal = detalleP.RangoFinal;
                    listado.Add(tmp);
                    listaPrecioDel.Remove(tmp);
                }
                else
                {
                    listado.Add(detalleP);
                }
            }
            else
            {
                listado.Add(detalleP);
            }
        }

        private void cbEscala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEscala.SelectedIndex == 0)
            {
                txtRangoInic.Text = "1";
                txtRangoFinal.Text = "11";

            }
            if (cbEscala.SelectedIndex == 1)
            {
                txtRangoInic.Text = "12";
                txtRangoFinal.Text = "49";

            }
            if (cbEscala.SelectedIndex == 2)
            {
                txtRangoInic.Text = "50";
                txtRangoFinal.Text = "1000";

            }
            if (cbEscala.SelectedIndex == 3)
            {
                txtRangoInic.Text = "1001";
                txtRangoFinal.Text = "10000";

            }

        }        

        private void stockproducto_TextChanged(object sender, EventArgs e)
        {
            if (StockNuevo.Text.Length > 0)
            {
                if (!Int32.TryParse(StockNuevo.Text, out var n) && !_producto.EsGrano)
                {
                    KryptonMessageBox.Show("Por favor, revise los carácteres ingresados", "Notificación");
                }
                else
                {
                    if (_producto.EsGrano)
                    {
                        decimal stocktotal = Convert.ToDecimal(StockNuevo.Text) + Convert.ToDecimal(StockActual.Text);
                        StockTotal.Text = stocktotal.ToString();
                    }
                    else
                    {
                        int stocktotal = Convert.ToInt32(StockNuevo.Text) + Convert.ToInt32(StockActual.Text);
                        stockstockToValidar = stocktotal;
                        StockTotal.Text = stocktotal.ToString();
                    }

                    //if (Convert.ToInt32(StockNuevo.Text) > 0)
                    //{
                    //    StockTotal.Text = stocktotal.ToString();
                    //    checkColor.Checked = false;
                    //    checktalla.Checked = false;
                    //    rdcolorytalla.Checked = false;
                    //    checkEstilo.Checked = false;
                    //}
                }
            }
            else
            {
                StockTotal.Text = StockActual.Text;
            }
        }

        private void checkExistencia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkExistencia.Checked)
            {
                txtcantidadmin.Visible = true;
                lbcantidadmin.Visible = true;
            }
            else
            {
                txtcantidadmin.Visible = false;
                lbcantidadmin.Visible = false;
            }
        }

        private void checkmovimiento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmovimiento.Checked == false)
            {
                rbcuatro.Visible = false;
                rbcuatro.Checked = false;
                rbochosem.Visible = false;
                rbochosem.Checked = false;
                rbpersonal.Visible = false;
                rbpersonal.Checked = false;
                dtpfechainicio.Visible = false;
                dtpfechafinal.Visible = false;
                lbfechainicio.Visible = false;
                lbfechafinal.Visible = false;
            }
            else
            {
                rbcuatro.Visible = true;
                rbochosem.Visible = true;
                rbpersonal.Visible = true;
                dtpfechainicio.Visible = true;
                dtpfechafinal.Visible = true;
                lbfechainicio.Visible = true;
                lbfechafinal.Visible = true;

            }
        }


        private void nomproductotxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkGrano_CheckedChanged(object sender, EventArgs e)
        {
            pnlGrano.Visible = checkGrano.Checked;
            pnlDetalle.Enabled = !checkGrano.Checked;
        }

        private void CheckQuintal_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckQuintal.Checked)
            {
                ObtenerCantidades();
                if (txtunidadmedida.Text == "lb")
                {
                    AsignaCantidades(ConvertirLQuintal(sActual), ConvertirLQuintal(sNuevo), ConvertirLQuintal(sTotal));
                }
                else if (txtunidadmedida.Text == "onz")
                {
                    AsignaCantidades(ConvertirOQuintal(sActual), ConvertirOQuintal(sNuevo), ConvertirOQuintal(sTotal));
                }
                txtunidadmedida.Text = "q";
                txtunidadmedida.ReadOnly = true;
                unidadGrano = 1;
            }
        }

        private void CheckLibra_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckLibra.Checked)
            {
                ObtenerCantidades();
                if (txtunidadmedida.Text == "q")
                {
                    AsignaCantidades(ConvertirQLibra(sActual), ConvertirQLibra(sNuevo), ConvertirQLibra(sTotal));
                }
                else if (txtunidadmedida.Text == "onz")
                {
                    AsignaCantidades(ConvertirOLibra(sActual), ConvertirOLibra(sNuevo), ConvertirOLibra(sTotal));
                }
                txtunidadmedida.Text = "lb";
                txtunidadmedida.ReadOnly = true;
                unidadGrano = 2;
            }
        }

        private void CheckOnza_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckOnza.Checked)
            {
                ObtenerCantidades();
                if (txtunidadmedida.Text == "q")
                {
                    AsignaCantidades(ConvertirQOnza(sActual), ConvertirQOnza(sNuevo), ConvertirQOnza(sTotal));
                }
                else if (txtunidadmedida.Text == "lb")
                {
                    AsignaCantidades(ConvertirLOnza(sActual), ConvertirLOnza(sNuevo), ConvertirLOnza(sTotal));
                }
                txtunidadmedida.Text = "onz";
                txtunidadmedida.ReadOnly = true;
                unidadGrano = 3;
            }
        }
        private TipoPrecio GetModelTipoPrecio()
        {
            var tipoprecio = new TipoPrecio()
            {
                Id = Guid.NewGuid(),
                FechaInicio = DateTime.Now,

            };
            return tipoprecio;
        }
        private void GuardarTipoyDetalles(Producto productoEdit)
        {
            //try
            //{
            //    DatagridToList();
            //    var listaEscalas = new List<ListarDetallePrecios>();
            //    var listaDetalle = new List<DetallePrecio>();

            //    listaEscalas = lista1.Concat(lista2).Concat(lista3).Concat(lista4).Concat(lista5).ToList();

            //    if (listaEscalas.Count > 0)
            //    {
            //        var encabezadoTipoprecio = _tipoPrecioRepository.Get(productoEdit.Id);

            //        if (!ModelState.IsValid(encabezadoTipoprecio)) return;

            //        foreach (var item in listaEscalas)
            //        {
            //            DetallePrecio detallePrecio = new DetallePrecio();
            //            detallePrecio.Id = item.Id;
            //            detallePrecio.TipoPrecioId = item.TipoPrecioId;
            //            detallePrecio.Escala = item.Escala;
            //            detallePrecio.Precio = item.Precio;
            //            detallePrecio.RangoInicio = item.RangoInicio;
            //            detallePrecio.RangoFinal = item.RangoFinal;
            //            detallePrecio.TiposId = item.TiposId;
            //            detallePrecio.Tipos = _tiposClienteRepository.GetTipoName(item.Tipos);
            //            listaDetalle.Add(detallePrecio);
            //        }

            //        foreach (var detailPrecio in listaDetalle)
            //        {
            //            var tmp = _tipoPrecioRepository.GetDetalle(detailPrecio.Id);

            //            if (tmp != null)
            //            {
            //                tmp.RangoInicio = detailPrecio.RangoInicio;
            //                tmp.RangoFinal = detailPrecio.RangoFinal;
            //                tmp.Precio = detailPrecio.Precio;
            //                _tipoPrecioRepository.UpdateDetallePrecio(tmp);
            //            }
            //            else
            //            {
            //                detailPrecio.Id = Guid.NewGuid();
            //                detailPrecio.TipoPrecioId = encabezadoTipoprecio.Id;
            //                _tipoPrecioRepository.AddDetallePrecio(detailPrecio);
            //            }
            //        }
            //    }

            //    eliminarDetallePrecios(productoEdit);
            //}
            //catch (Exception ex)
            //{
            //    KryptonMessageBox.Show("Revise las escalas de precio y los valores ingresados", ex.Message);
            //}
            try
            {
                DatagridToList();
                var listaEscalas = new List<ListarDetallePrecios>();
                var listaDetalle = new List<DetallePrecio>();
                listaEscalas = lista1.Concat(lista2).Concat(lista3).Concat(lista4).Concat(lista5).ToList();
                var encabezadoTipoprecio = _tipoPrecioRepository.Get(productoEdit.Id);

                if (encabezadoTipoprecio != null) { 

                foreach (var item in listaEscalas)
                {
                    DetallePrecio detallePrecio = new DetallePrecio();
                    detallePrecio.Id = item.Id;
                    detallePrecio.TipoPrecioId = item.TipoPrecioId;
                    detallePrecio.Escala = item.Escala;
                    detallePrecio.Precio = item.Precio;
                    detallePrecio.RangoInicio = item.RangoInicio;
                    detallePrecio.RangoFinal = item.RangoFinal;
                    detallePrecio.TiposId = item.TiposId;
                    detallePrecio.Tipos = _tiposClienteRepository.GetTipoName(item.Tipos);
                    listaDetalle.Add(detallePrecio);
                }

                foreach (var detailPrecio in listaDetalle)
                {
                    var tmp = _tipoPrecioRepository.GetDetalle(detailPrecio.Id);

                    if (tmp != null)
                    {
                        tmp.RangoInicio = detailPrecio.RangoInicio;
                        tmp.RangoFinal = detailPrecio.RangoFinal;
                        tmp.Precio = detailPrecio.Precio;
                        _tipoPrecioRepository.UpdateDetallePrecio(tmp);
                    }
                    else
                    {
                        detailPrecio.Id = Guid.NewGuid();
                        detailPrecio.TipoPrecioId = encabezadoTipoprecio.Id;
                        _tipoPrecioRepository.AddDetallePrecio(detailPrecio);
                    }
                }
            }else {

                encabezadoTipoprecio = GetModelTipoPrecio();
                if (!ModelState.IsValid(encabezadoTipoprecio)) return;
                var productoReciente = _productosRepository.GetProductByBarCode(codigoreferencia.Text, UsuarioLogeadoSistemas.User.SucursalId);
                encabezadoTipoprecio.ProductoId = productoReciente.Id;
                _tipoPrecioRepository.Add(encabezadoTipoprecio);
                foreach (var item in listaEscalas)
                {
                    DetallePrecio detallePrecio = new DetallePrecio();
                    detallePrecio.Id = Guid.NewGuid();
                    detallePrecio.TipoPrecioId = encabezadoTipoprecio.Id;
                    detallePrecio.Escala = item.Escala;
                    detallePrecio.Precio = item.Precio;
                    detallePrecio.RangoInicio = item.RangoInicio;
                    detallePrecio.RangoFinal = item.RangoFinal;
                    detallePrecio.TiposId = item.TiposId;
                    listaDetalle.Add(detallePrecio);
                }

                foreach (var detailPrecio in listaDetalle)
                {
                    _tipoPrecioRepository.AddDetallePrecio(detailPrecio);
                }
            }
        }
            catch (Exception ex)
            {

                KryptonMessageBox.Show("Revise las escalas de precio y los valores ingresados", ex.Message);
            }
        }

        private void DatagridToList()
        {
            if (Dgvunitario.RowCount > 0)
            {
                dgvTolista(lista1, Dgvunitario,"Minorista");
            }
            if (dgvmayorista.RowCount > 0)
            {
                dgvTolista(lista2, dgvmayorista,"Mayorista");
            }
            if (dgvcuentaclave.RowCount > 0)
            {
                dgvTolista(lista3, dgvcuentaclave,"Cuenta clave");
            }
            if (dgvrevendedor.RowCount > 0)
            {
                dgvTolista(lista4, dgvrevendedor,"Revendedor");
            }
            if (dgvgubernamental.RowCount > 0)
            {
                dgvTolista(lista5, dgvgubernamental,"Gubernamental");
            }
        }

        private List<ListarDetallePrecios> dgvTolista(List<ListarDetallePrecios> lista, DataGridView dataGrid,string cliente)
        {

            int ContadorFilaActual = 0;
            foreach (DataGridViewRow rows in dataGrid.Rows)
            {
                var fila = (ListarDetallePrecios)dataGrid.Rows[ContadorFilaActual].DataBoundItem;
                fila.Tipos = cliente;
                listaPrecioDel.Add(fila);
                ContadorFilaActual++;
            }
            return lista;
        }

        private void Dgvunitario_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridView dgvTemp = sender as DataGridView;

            //para obtener los valores de las celdas 
            var filaeliminada = dgvTemp.CurrentRow;

            //para agregarlo al listado de precios eliminados
            var filaActualEliminada = (ListarDetallePrecios)dgvTemp.CurrentRow.DataBoundItem;
            listaPrecioDel.Add(filaActualEliminada);

        }

        private void eliminarDetallePrecios(Producto productoEdit)
        {
            try
            {
                if (listaPrecioDel.Count > 0)
                {
                    var listaDetalle = new List<DetallePrecio>();

                    foreach (var item in listaPrecioDel)
                    {
                        var tmp = _tipoPrecioRepository.GetDetalle(item.Id);
                        if (tmp != null)
                        {
                            _tipoPrecioRepository.DeleteDetallePreciop(tmp);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                KryptonMessageBox.Show("Error en eliminacion de los detalle de precios.", e.Message);
            }
        }


        public void ObtenerCantidades()
        {
            sActual = Convert.ToDecimal(StockActual.Text);
            sNuevo = Convert.ToDecimal(StockNuevo.Text);
            sTotal = Convert.ToDecimal(StockTotal.Text);
        }

        public void AsignaCantidades(decimal Actual, decimal nuevo, decimal total)
        {
            StockActual.Text = Actual.ToString();
            StockNuevo.Text = nuevo.ToString();
            StockTotal.Text = total.ToString();
        }

        private decimal ConvertirQLibra(decimal cantidad)
        {
            return decimal.Round((cantidad * ConversionQLb), 3);
        }

        private decimal ConvertirQOnza(decimal cantidad)
        {
            return decimal.Round((cantidad * ConversionQOnz), 3);
        }

        private decimal ConvertirLQuintal(decimal cantidad)
        {
            return decimal.Round((cantidad / ConversionQLb), 3);
        }

        private decimal ConvertirLOnza(decimal cantidad)
        {
            return decimal.Round((cantidad * ConversionLOnz), 3);
        }

        private decimal ConvertirOQuintal(decimal cantidad)
        {
            return decimal.Round((cantidad / ConversionQOnz), 3);
        }

        private decimal ConvertirOLibra(decimal cantidad)
        {
            return decimal.Round((cantidad / ConversionLOnz), 3);
        }

    }

}
