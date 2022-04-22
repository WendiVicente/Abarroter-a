using CapaDatos.Models.Precios;
using CapaDatos.Repository;
using CapaDatos.Repository.PreciosRepository;
using ComponentFactory.Krypton.Toolkit;
using sharedDatabase.Models;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema.Forms.modulo_producto
{
    public partial class Importar_data : BaseContext
    {

        private readonly ProductosRepository productosRepository = null;
        private readonly TipoPrecioRepository _tipoPrecioRepository = null;
        private readonly DetallePrecio precios = null;
        private readonly CategoriaProdRepository _categoria = null;

        List<Elemento> listadolocal = new List<Elemento>();
        public Importar_data()
        {
            productosRepository = new ProductosRepository(_context);
            _tipoPrecioRepository = new TipoPrecioRepository(_context);
            _categoria = new CategoriaProdRepository(_context);
            precios = new DetallePrecio();
            InitializeComponent();
        }


        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel | *.xls;*.xlsx;",
                Title = "Seleccionar Archivo"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String tmp = openFileDialog.InitialDirectory + openFileDialog.FileName;
                ImportarDatos(tmp);
            }
        }

        public void ImportarDatos(string nombrearchivo)
        {
            DataGridView dgv = new DataGridView();
            Elemento elemento = new Elemento();
            SLDocument sl = null;
            try
            {
                sl = new SLDocument(nombrearchivo);
                try
                {
                    int iRow = 2;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        elemento.codigo = sl.GetCellValueAsInt32(iRow, 1);
                        elemento.descripcion = sl.GetCellValueAsString(iRow, 2);
                        elemento.existencia = sl.GetCellValueAsInt32(iRow, 3);
                        elemento.costo = sl.GetCellValueAsDecimal(iRow, 4);
                        elemento.precio = sl.GetCellValueAsDecimal(iRow, 5);
                        elemento.credito = sl.GetCellValueAsDecimal(iRow, 6);
                        elemento.minimo = sl.GetCellValueAsDecimal(iRow, 7);
                        elemento.codigoreferencia = sl.GetCellValueAsString(iRow, 8);
                        elemento.categoria = ObtenerCategoria(sl.GetCellValueAsString(iRow, 9).Trim());
                        elemento.proveedor = 1;
                        listadolocal.Add(elemento);
                        elemento = new Elemento();
                        iRow++;
                    }
                }
                catch (Exception ex)
                {
                    KryptonMessageBox.Show("Error en la consulta realizada para obtencion de la informacion de la BD");
                }

                BindingSource source = new BindingSource();
                source.DataSource = listadolocal;
                DataDetalles.DataSource = typeof(List<>);
                DataDetalles.DataSource = source;
                DataDetalles.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error en obtencion del archivo. ERR-" + ex.Message);
            }



        }

        private int ObtenerCategoria(string categoria)
        {
            if (categoria == "CABELLO")
                return 1;
            else if (categoria == "COSMETICOS")
                return 2;
            else if (categoria == "FACIAL")
                return 3;
            else if (categoria == "MANICURE/PEDICURE")
                return 4;
            else if (categoria == "PERSONAL")
                return 5;
            else if (categoria == "UÑAS")
                return 6;
            else if (categoria == "VARIOS")
                return 7;
            else
                return 7;

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

        private DetallePrecio DetallePrecio(Guid g, string escala, int ri, int rf, decimal precio)
        {
            var detalle = new DetallePrecio()
            {
                Id = Guid.NewGuid(),
                TipoPrecioId = g,
                Escala = escala,
                RangoInicio = ri,
                RangoFinal = rf,
                Precio = precio,
                TiposId = 7,

            };
            return detalle;
        }

        private void btnMigrar_Click(object sender, EventArgs e)
        {
            int total = 0;
            int insertados = 0;
            int actualizados = 0;
            foreach (Elemento item in listadolocal)
            {

                Producto prd = productosRepository.Get(item.codigo);
                if (prd != null)
                {
                    ActualizarProd(prd, item);
                    GuardarPrecios(prd, item);
                    actualizados++;
                }
                else
                {
                    Producto GetProd = productosRepository.GetProductByBarCode(item.codigoreferencia, UsuarioLogeadoSistemas.User.SucursalId);

                    if (GetProd != null)
                    {
                        ActualizarProd(GetProd, item);
                        GuardarPrecios(GetProd, item);
                        actualizados++;
                    }
                    else
                    {
                        Producto nuevo = GetModelProducto(item);
                        productosRepository.Add(nuevo);
                        Producto GetNuevo = productosRepository.GetProductByBarCode(nuevo.CodigoBarras, UsuarioLogeadoSistemas.User.SucursalId);


                        if (GetNuevo != null)
                        {
                            GuardarPrecios(nuevo, item);
                        }
                        else
                        {
                            KryptonMessageBox.Show("No se pudo obtener el producto a insertar");
                        }
                        insertados++;
                    }                    
                }
            }
            total = insertados + actualizados;
            lbActualizados.Text = actualizados.ToString();
            lbInsertados.Text = insertados.ToString();
            lbtotal.Text = total.ToString();
            KryptonMessageBox.Show("Migracion Realizada Con exito");
        }
        public void GuardarPrecios(Producto prd, Elemento item)
        {
            try
            {
                var tp = _tipoPrecioRepository.Get(prd.Id, false);

                if (tp != null)
                {
                    var detallesprecio = _tipoPrecioRepository.GetDetallePrecios(tp.Id);
                    if (detallesprecio.Count > 0)
                    {
                        foreach (DetallePrecio dt in detallesprecio)
                        {
                            if (dt.Escala == "E1")
                            {
                                dt.Precio = item.credito;
                                _tipoPrecioRepository.UpdateDetallePrecio(dt);
                            }
                            else if (dt.Escala == "E2")
                            {
                                dt.Precio = item.minimo;
                                _tipoPrecioRepository.UpdateDetallePrecio(dt);
                            }
                        }
                    }
                    else
                    {
                        DetallePrecio deta1 = DetallePrecio(tp.Id, "E1", 3, 5, item.credito);
                        DetallePrecio deta2 = DetallePrecio(tp.Id, "E2", 6, 1000, item.minimo);

                        _tipoPrecioRepository.AddDetallePrecio(deta1);
                        _tipoPrecioRepository.AddDetallePrecio(deta2);
                    }
                }
                else
                {
                    TipoPrecio tp2 = GetModelTipoPrecio();
                    tp2.ProductoId = prd.Id;

                    _tipoPrecioRepository.Add(tp2);

                    DetallePrecio det = DetallePrecio(tp2.Id, "E1", 3, 5, item.credito);
                    DetallePrecio det2 = DetallePrecio(tp2.Id, "E2", 6, 1000, item.minimo);

                    _tipoPrecioRepository.AddDetallePrecio(det);
                    _tipoPrecioRepository.AddDetallePrecio(det2);
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("¡Error en proceso de migracion!" + ex.Message);
                return;
            }

        }

        private Producto GetModelProducto(Elemento item)
        {
            var producto = new Producto()
            {
                CategoriaId = item.categoria,
                ProveedorId = item.proveedor,
                SucursalId = UsuarioLogeadoSistemas.User.SucursalId,
                CodigoBarras = item.codigoreferencia,
                Descripcion = item.descripcion,
                DescripcionCorta = item.descripcion,
                Impuesto = 0.12M,
                Coste = item.costo,
                PrecioVenta = item.precio,
                TieneEscalas = true,
                FechaIngreso = DateTime.Now,
                FechaModificacion = DateTime.Now,
                Notas = "",
                Stock = item.existencia,
                PermitirVenta = true,
                PermitirCompra = true,
                Ubicacion = "Principal",
            };

            return producto;

        }

        private void ActualizarProd(Producto prd, Elemento item)
        {
            try
            {
                Producto actualizar = GetModelProducto(item);
                actualizar.Id = prd.Id;
                actualizar.Sucursal = prd.Sucursal;
                actualizar.Categoria = prd.Categoria;
                actualizar.Marca = prd.Marca;
                actualizar.Numeral = prd.Numeral;
                actualizar.PeriodoMovimiento = prd.PeriodoMovimiento;
                productosRepository.Update(prd);
            }
            catch (Exception io)
            {
                KryptonMessageBox.Show("Ha ocurrido un error interno en la actualizacion del producto");
            }

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsertarNuevos_Click(object sender, EventArgs e)
        {
            int total = 0;
            int insertados = 0;
            int actualizados = 0;
            foreach (Elemento item in listadolocal)
            {
                Producto prd = productosRepository.GetProductByBarCode(item.codigoreferencia, UsuarioLogeadoSistemas.User.SucursalId);
                if (prd == null)
                {
                    Producto nuevo = GetModelProducto(item);
                    productosRepository.Add(nuevo);
                    Producto Getnuevo = productosRepository.GetProductByBarCode(item.codigoreferencia, UsuarioLogeadoSistemas.User.SucursalId);

                    if (Getnuevo != null)
                    {
                        GuardarPrecios(nuevo, item);
                    }
                    else
                    {
                        KryptonMessageBox.Show("No se pudo obtener el producto a insertar");
                    }

                    insertados++;
                }
            }
            total = insertados + actualizados;
            lbInsertados.Text = insertados.ToString();
            lbtotal.Text = total.ToString();
            KryptonMessageBox.Show("Migracion Realizada Con exito");
        }


    }
}
public class Elemento
{

    public Elemento()
    {

    }


    public int codigo { get; set; }

    public string descripcion { get; set; }

    public int existencia { get; set; }

    public decimal costo { get; set; }

    public decimal precio { get; set; }

    public decimal credito { get; set; }

    public decimal minimo { get; set; }

    public string codigoreferencia { get; set; }

    public int categoria { get; set; }

    public int proveedor { get; set; }
}