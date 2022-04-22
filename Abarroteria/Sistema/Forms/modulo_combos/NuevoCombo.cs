using CapaDatos.Data;
using CapaDatos.ListasPersonalizadas;
using CapaDatos.Models.Productos;
using CapaDatos.Models.Productos.Combos;
using CapaDatos.Repository;
using CapaDatos.Validation;
using ComponentFactory.Krypton.Toolkit;
using POS.Validations;
using sharedDatabase.Models;
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

namespace Sistema.Forms.modulo_combos
{
    public partial class NuevoCombo : BaseContext
    {
        private CombosRepository _combosRepository = null;
        private int sucursalid = UsuarioLogeadoSistemas.User.SucursalId;
        private ProductosRepository _productosRepository = null;
        private ColoresRepository _coloresRepository = null;
        private TallasRepository _tallasRepository = null;
        private TallasyColoresRepository _tallasyColoresRepository = null;
        private DetalleEstiloRepository _detalleEstiloRepository = null;
        private List<ListarProductos> listarProductosTodos = null;
        private List<ComboDetalleLista> listaDetalles = null;
        private List<Producto> listaproductostoadd = null;

        //columnas del detall de combos para enviar ala bd
        private readonly int idproducto = 2;
        private readonly int referenciacol = 3;
        private readonly int descripcol = 4;
        private readonly int cantidadcol = 5;
        private readonly int colorIdcol = 6;
        private readonly int tallaIdcol = 8;
        private readonly int colidtyc = 10;
        private readonly int colAccionesProd = 31;

        //columnas de dgv colores y tallas
        readonly int IDTyCcol = 0;
        readonly int productIDTyCcol = 1;        
        readonly int colorTyCcol = 3;
        readonly int tallaTyCcol = 4;
        readonly int colAccionesTyC = 5;
        byte[] filefoto = null;

        private readonly Layout formslayout = null;
        public NuevoCombo(Layout forms)
        {
            _productosRepository = new ProductosRepository(_context);
            _combosRepository = new CombosRepository(_context);
            _coloresRepository = new ColoresRepository(_context);
            _tallasRepository = new TallasRepository(_context);
            _tallasyColoresRepository = new TallasyColoresRepository(_context);
            _detalleEstiloRepository = new DetalleEstiloRepository(_context);
            listaDetalles = new List<ComboDetalleLista>();
            listaproductostoadd = new List<Producto>();
            formslayout = forms;
            InitializeComponent();
            TraerListabd();
        }
        
        public ProductosRepository AccesoProductoRepository()
        {
            _context = null;
            _context = new Context();
            _productosRepository = null;
            _productosRepository = new ProductosRepository(_context);
            return _productosRepository;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ListaProductSelect.Rows.Count == 0)
            {
                KryptonMessageBox.Show("Debe ingresar productos");
                return;
            }         
            GuardarCombo();
            RecargarNuevoCombo();
            Close();
        }
               
        private void NuevoCombo_Load(object sender, EventArgs e)
        {
            ocultarcombos();
            cargardatos();
        }

        private void LimpiarCampos()
        {
            txtcosto.Text = "0.00";
            txtdescripcion.Text = "";
            txtpreciocuentaclave.Text = "0.00";
            txtprecioentidad.Text = "0.00";
            txtpreciomayorista.Text = "0.00";
            txtprecioventa.Text = "0.00";
            txtrevendedor.Text = "0.00";
            txtstock.Text = "0";
            txtcodibarras.Text = "";            
            ListaProductSelect.DataSource = null;
        }

        private void cargardatos()
        {
            txtcosto.Text = "0.00";
            txtdescripcion.Text = "";
            txtpreciocuentaclave.Text = "0.00";
            txtprecioentidad.Text = "0.00";
            txtpreciomayorista.Text = "0.00";
            txtprecioventa.Text = "0.00";
            txtrevendedor.Text = "0.00";
            txtstock.Text = "0";
            txtcodibarras.Text = "";
        }

        public Combo GetCombo()
        {
            return new Combo()
            {
                Id = Guid.NewGuid(),
                SucursalId = sucursalid,
                Descripcion = txtdescripcion.Text,
                FechaInicio = DateTime.Now,
                Precioventa = decimal.Parse(txtprecioventa.Text),
                PrecioMayorista = decimal.Parse(txtpreciomayorista.Text),
                PrecioCuentaClave = decimal.Parse(txtpreciocuentaclave.Text),
                PrecioEntidadGubernamental = decimal.Parse(txtprecioentidad.Text),
                PrecioRevendedor = decimal.Parse(txtrevendedor.Text),
                PrecioCompra = decimal.Parse(txtcosto.Text),
                TieneColor = false,
                FechaMovimiento = DateTime.Now,
                CategoriaId = 1,
                Stock= int.Parse(txtstock.Text),
                CodigoBarras= txtcodibarras.Text,
                Imagen = filefoto,
            };
        }
        
        public List<ComboDetalleLista> GetDatosDetalleCombo()
        {
            var List = new List<ComboDetalleLista>();

            foreach (DataGridViewRow item in ListaProductSelect.Rows)
            {
                if (item == null)
                {
                    continue;
                }

                ComboDetalleLista producto = (ComboDetalleLista)item.DataBoundItem;
                ComboDetalleLista comboDetalleU = new ComboDetalleLista
                {
                    ProductoId = producto.ProductoId,
                    Referencia = producto.Referencia,
                    Descripcion = producto.Descripcion,
                    Cantidad = producto.Cantidad,
                    ColorId = producto.ColorId,
                    TallaId = producto.TallaId,
                    TallayColorId = producto.TallayColorId,
                    DetalleEstiloId = producto.DetalleEstiloId,
                    Color = producto.Color,
                    Talla = producto.Talla,
                    Estilo = producto.Estilo
                };

                List.Add(comboDetalleU);
            }

            return List;
        }
        
        public ComboDetalleLista GetmodelDetalle()
        {
            return new ComboDetalleLista
            {
            };
        }
        
        private void GuardarCombo()
        {
            try
            {
                var encabezadoCombo = GetCombo(); // encabezado
                var detalleCombo = GetDatosDetalleCombo();// detalle de combo               
                if (!ModelState.IsValid(encabezadoCombo)) return;
                if (!ModelState.IsValid(detalleCombo)) return;
              
                _combosRepository.Add(encabezadoCombo);
                foreach (var item in detalleCombo)
                {
                    var detalle = new DetalleCombo()
                    {
                        ComboId = encabezadoCombo.Id,
                        
                        Referencia = item.Referencia.ToString(),
                        Descripcion = item.Descripcion,
                        Cantidad = item.Cantidad,
                    };

                    if (item.TallayColorId !=0) { detalle.DetalleColorTallaId = item.TallayColorId; }
                    if (item.TallaId != 0){ detalle.DetalleTallaId = item.TallaId;}
                    if (item.ColorId != 0){ detalle.DetalleColorId = item.ColorId;}
                    if (item.DetalleEstiloId != 0) { detalle.DetalleEstiloId = item.DetalleEstiloId; }
                    _combosRepository.AddDetalle(detalle);
                    _context.SaveChanges();
                }

                KryptonMessageBox.Show("Combo Registrado con exito");
               
                LimpiarCampos();
                limpiarSeleccion(dgListaProductos,colAccionesProd);
                limpiarSeleccion(dgvtallascolores,5 );
                listaproductostoadd.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpiarSeleccion(DataGridView data, int colacc)
        {
            foreach (DataGridViewRow Rows in data.Rows)
            {
                bool acciones = Convert.ToBoolean(Rows.Cells[colacc].Value);
                if (acciones)
                {
                    Rows.Cells[colacc].Value = false;
                }
            }
        }

      
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            //var ProductoBuscado = ListadoProductosC.ListaDeProductos;
            var ProductoBuscado = listarProductosTodos;
            var filter = ProductoBuscado.Where(a => a.Descripcion.Contains(txtbuscar.Text) ||
            (a.CodigoReferencia != null && a.CodigoReferencia.Contains(txtbuscar.Text)) ||
            (a.Categoria != null && a.Categoria.Contains(txtbuscar.Text)) ||
            (a.Notas != null && a.Notas.Contains(txtbuscar.Text)));
            dgListaProductos.DataSource = filter.ToList();
        }

        private void TraerListabd()
        {
            listarProductosTodos = (List<ListarProductos>)_productosRepository.GetList(UsuarioLogeadoSistemas.User.SucursalId);
            CargarDgv();
        }

        public void CargarDgv()
        {
            BindingSource source = new BindingSource();
            source.DataSource = listarProductosTodos;
            dgListaProductos.DataSource = typeof(List<>);
            dgListaProductos.DataSource = source;
        }
      

        private void SeleccionAcciones(DataGridView datatgrid, List<Producto> Productolista)
        {
            if (datatgrid.RowCount <= 0) { return; }
            int filasSeleccion = 0;
            foreach (DataGridViewRow Rows in datatgrid.Rows)
            {
                var filasTotales = int.Parse(datatgrid.RowCount.ToString());
                bool acciones = Convert.ToBoolean(Rows.Cells[colAccionesProd].Value);
                if (!acciones)
                {
                    filasSeleccion += 1;
                }
                else
                {
                    var Id = int.Parse(Rows.Cells[0].Value.ToString());
                    var ProductoObtenido = _productosRepository.Get(Id);
                    Productolista.Add(ProductoObtenido);
                }

                if (filasTotales == filasSeleccion)
                {
                    KryptonMessageBox.Show("Debera tener seleccionada  la columna 'Acciones'\n "
                        + "Selecione un Producto, dando click en la columna Acciones\n"
                        );

                    return;
                }
            }
        }
        private void cargarDGVPromos(List<ComboDetalleLista> lista)
        {
            BindingSource recurso = new BindingSource();
            recurso.DataSource = lista;
            ListaProductSelect.DataSource = typeof(List<>);
            ListaProductSelect.DataSource = recurso;
        }

        private void AgregarListarDetalles()
        {
            foreach (var item in listaproductostoadd)
            {
                var detalleCombo = GetmodelDetalle();
                detalleCombo.ProductoId = item.Id;
                detalleCombo.Referencia = item.CodigoBarras;
                detalleCombo.Cantidad = int.Parse(txtcantidad.Text);
                detalleCombo.Descripcion = item.Descripcion;
                if (combocolor.Items.Count > 0)
                {
                    detalleCombo.ColorId = int.Parse(combocolor.SelectedValue.ToString());
                    detalleCombo.Color = combocolor.Text;
                }
                if (combotalla.Items.Count > 0)
                {
                    detalleCombo.TallaId = int.Parse(combotalla.SelectedValue.ToString());
                    detalleCombo.Talla = combotalla.Text;
                }
                if (comboestilos.Items.Count > 0)
                {
                    detalleCombo.DetalleEstiloId = int.Parse(comboestilos.SelectedValue.ToString());
                    detalleCombo.Estilo = comboestilos.Text;
                }

                listaDetalles.Add(detalleCombo);

            }

            cargarDGVPromos(listaDetalles);

        }


        private void btnAgregarCombo_Click(object sender, EventArgs e)
        {
            SeleccionAcciones(dgListaProductos, listaproductostoadd);
            AgregarListarDetalles();
            listaproductostoadd.Clear();
            limpiarSeleccion(dgListaProductos,colAccionesProd);
        }

        private void ocultarcombos()
        {
            lbcolor.Visible = false;
            lbtalla.Visible = false;
            lbEstilos.Visible = false;
            combocolor.Visible = false;
            combotalla.Visible = false;
            comboestilos.Visible = false;
        }

        private void mostarcomvbos()
        {
            lbcolor.Visible = true;
            lbtalla.Visible = true;
            lbEstilos.Visible = true;
            combocolor.Visible = true;
            combotalla.Visible = true;
            comboestilos.Visible = true;
        }

        public void LlenarTextBox(int IndiceDGV)
        {
            txtproducto.Text = dgListaProductos.Rows[IndiceDGV].Cells[1].Value.ToString(); //tipo de cliente
            var productoObtenido = _productosRepository.Get(int.Parse(dgListaProductos.Rows[IndiceDGV].Cells[0].Value.ToString()));

            int opcion = ObtenerTipoDetalle(productoObtenido.Id);
            switch (opcion)
            {
                case 1:
                    var listadeColoresProductos = _coloresRepository.GetProductoListaColor(productoObtenido.Id);
                    cargarComboColores(listadeColoresProductos);
                    combotalla.DataSource = null;
                    comboestilos.DataSource = null;
                    btnAgregarCombo.Enabled = true;
                    lbcolor.Visible = true;
                    lbtalla.Visible = false;
                    lbEstilos.Visible = false;
                    combocolor.Visible = true;
                    combotalla.Visible = false;
                    comboestilos.Visible = false;
                    CargarDgVacio();
                    break;
                case 2:
                    var listadeTallaProductos = _tallasRepository.GetTallaListaProducto(productoObtenido.Id);
                    cargarComboTallas(listadeTallaProductos);
                    combocolor.DataSource = null;
                    comboestilos.DataSource = null;
                    btnAgregarCombo.Enabled = true;
                    lbcolor.Visible = false;
                    lbtalla.Visible = true;
                    lbEstilos.Visible = false;
                    combocolor.Visible = false;
                    combotalla.Visible = true;
                    comboestilos.Visible = false;
                    CargarDgVacio();
                    break;
                case 3:
                    CargarDg(productoObtenido.Id);
                    combocolor.DataSource = null;
                    combotalla.DataSource = null;
                    comboestilos.DataSource = null;
                    btnAgregarCombo.Enabled = false;
                    ocultarcombos();
                    break;
                case 4:
                    var listaEstilos = _detalleEstiloRepository.GetProductoListaEstilo(productoObtenido.Id);
                    cargarComboEstilos(listaEstilos);
                    combocolor.DataSource = null;
                    combotalla.DataSource = null;
                    btnAgregarCombo.Enabled = true;
                    lbcolor.Visible = false;
                    lbtalla.Visible = false;
                    lbEstilos.Visible = true;
                    combocolor.Visible = false;
                    combotalla.Visible = false;
                    comboestilos.Visible = true;
                    CargarDgVacio();
                    break;
                default:
                    break;
            }
        }

        private void cargarComboColores(List<DetalleColor> detalleColors)
        {
            combocolor.DataSource = detalleColors;
            combocolor.ValueMember = "Id";
            combocolor.DisplayMember = "Color";
        }

        private void cargarComboTallas(List<DetalleTalla> listaTallas)
        {
            combotalla.DataSource = listaTallas;
            combotalla.ValueMember = "Id";
            combotalla.DisplayMember = "Talla";
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
       
        private void checktodas_CheckedChanged(object sender, EventArgs e)
        {
            if (checktodas.Checked == true)
            {
                foreach (DataGridViewRow Rows in dgListaProductos.Rows)
                {
                    Rows.Cells[colAccionesProd].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow Rows in dgListaProductos.Rows)
                {
                    Rows.Cells[colAccionesProd].Value = false;
                }
            }            
        }       

        public void CargarDg(int idproducto)
        {
            BindingSource source = new BindingSource();
            var detalleListsObtenida = _tallasyColoresRepository.GetListaDetalleColorTallas(idproducto);
            source.DataSource = detalleListsObtenida;
            dgvtallascolores.DataSource = typeof(List<>);
            dgvtallascolores.DataSource = source;
            dgvtallascolores.AutoResizeColumns();
        }

        public void CargarDgVacio()
        {
            List<ListarDetalleColorTallas> lista = new List<ListarDetalleColorTallas>();
            dgvtallascolores.DataSource = typeof(List<>);
            dgvtallascolores.DataSource = lista;
        }

        private void txtstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnaddTallasycolores_Click(object sender, EventArgs e)
        {
            CargarSizeAndColorsToCombo();
            limpiarSeleccion(dgvtallascolores, 5);
            limpiarSeleccion(dgListaProductos, colAccionesProd);
        }

        private void dgvtallascolores_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            seleccionarfila(dgvtallascolores, colAccionesTyC);
        }

        private void seleccionarfila(DataGridView data, int numberCol)
        {
            bool estadoActual = Convert.ToBoolean(data.CurrentRow.Cells[numberCol].Value);
            if (estadoActual)
            {
                data.CurrentRow.Cells[numberCol].Value = false;
            }
            else
            {
                data.CurrentRow.Cells[numberCol].Value = true;
            }
        }

        private void CargarSizeAndColorsToCombo()
        {
            if (dgvtallascolores.RowCount <= 0) { return; }
            int filasSeleccion = 0;           
            foreach (DataGridViewRow Rows in dgvtallascolores.Rows)
            {
                var filasTotales = int.Parse(dgvtallascolores.RowCount.ToString());
                bool acciones = Convert.ToBoolean(Rows.Cells[colAccionesTyC].Value);
                if (!acciones)
                {
                    filasSeleccion += 1;
                }
                else
                {
                    var detalleCombo = GetmodelDetalle();
                    var detallect = (ListarDetalleColorTallas)Rows.DataBoundItem;                    
                    var productoobtenido = _productosRepository.Get(detallect.ProductoId);
                    detalleCombo.ProductoId = detallect.ProductoId;
                    detalleCombo.Referencia = productoobtenido.CodigoBarras;
                    detalleCombo.Cantidad = int.Parse(txtcantidad.Text);
                    detalleCombo.Descripcion = productoobtenido.Descripcion;
                    detalleCombo.Color = detallect.Color;
                    detalleCombo.Talla = detallect.Talla;
                    detalleCombo.TallayColorId = detallect.Id;
                    listaDetalles.Add(detalleCombo);
                }

                if (filasTotales == filasSeleccion)
                {
                    KryptonMessageBox.Show("Debera tener seleccionada  la columna 'Acciones'\n "
                        + "Selecione un Producto, dando click en la columna Acciones\n"
                        );

                    return;
                }

            }
            cargarDGVPromos(listaDetalles);

        }

        private void RecargarNuevoCombo()
        {
            NuevoCombo nuevo = new NuevoCombo(formslayout);
            nuevo.MdiParent = formslayout;
            nuevo.Show();
        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtpreciomayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
        }

        private void txtprecioentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtpreciocuentaclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtrevendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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

        private int ObtenerTipoDetalle(int ProductoId)
        {
            if (ProductoId > 0)
            {
                Producto producto = _productosRepository.Get(ProductoId);
                if (producto.TieneColor == true && producto.TieneTalla == false)
                    return 1;
                else if (producto.TieneColor == false && producto.TieneTalla == true)
                    return 2;
                else if (producto.TieneColor == true && producto.TieneTalla == true)
                    return 3;
                else if (producto.TieneEstilo == true)
                    return 4;
                else
                    return 0;
            }
            else
            {
                return 0;
            }
        }

        private void cargarComboEstilos(List<DetalleEstilo> listaEstilos)
        {
            comboestilos.DataSource = listaEstilos;
            comboestilos.ValueMember = "Id";
            comboestilos.DisplayMember = "Estilo";
            comboestilos.SelectedIndex = 0;
        }

        private void dgListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgListaProductos.CurrentRow.Index;
            LlenarTextBox(index);            
            if (dgListaProductos.CurrentCell.ColumnIndex == colAccionesProd)
            {
                var fila = dgListaProductos.CurrentRow;
                ListarProductos listarProductos = (ListarProductos)fila.DataBoundItem;
                if (listarProductos.Acciones)
                {
                    dgListaProductos.CurrentRow.Cells[colAccionesProd].Value = false;
                }
                else
                {
                    dgListaProductos.CurrentRow.Cells[colAccionesProd].Value = true;
                }
            }

            //if (EvaluarProductosSeleccionados() == 0)
            //{
            //    ocultarcombos();
            //    txtproducto.Text = "";
            //    dgvtallascolores.DataSource = null;
            //}

        }

        private int EvaluarProductosSeleccionados()
        {
            int selec = 0;
            //var lista = (List<ListarProductos>)dgListaProductos.DataSource;
            foreach (DataGridViewRow row in dgListaProductos.Rows)
            {
                ListarProductos productos  = (ListarProductos)row.DataBoundItem;
                if(productos.Acciones)
                {
                    selec++;
                }
            }
            return selec;
        }
    }
}
