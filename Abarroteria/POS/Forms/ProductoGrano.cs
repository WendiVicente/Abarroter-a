using System;
using CapaDatos.Repository;
using CapaDatos.Models.Productos;
using sharedDatabase.Models;
using ComponentFactory.Krypton.Toolkit;
using CapaDatos.ListasPersonalizadas;

namespace POS.Forms
{
    public partial class ProductoGrano : BaseContext
    {
        private readonly ProductosRepository _productosRepository = null;
        private readonly DetalleGranoRepository _detalleGranoRepository = null;
        private PrincipalV2 _principal;
        private DetalleGrano detalleGrano;
        private Producto producto;
        private int ProductoId;
        private string UMedida;
        const decimal ConversionQLb = 220.46m;
        const decimal ConversionQOnz = 3527.40m;
        const int ConversionLOnz = 16;

        public ProductoGrano(PrincipalV2 principal, int Id)
        {
            _productosRepository = new ProductosRepository(_context);
            _detalleGranoRepository = new DetalleGranoRepository(_context);
            _principal = principal;
            ProductoId = Id;
            InitializeComponent();
        }

        private void ProductoGrano_Load(object sender, EventArgs e)
        {
            CargarProducto();
        }

        private void CargarProducto()
        {
            try
            {
                producto = _productosRepository.Get(ProductoId);
                detalleGrano = _detalleGranoRepository.GetGranosProd(ProductoId);
                lbProd.Text = producto.Descripcion;
                lbUMedida.Text = producto.UnidadMedida;

                switch (producto.UnidadMedida)
                {
                    case "q":
                        CheckQuintal.Checked = true;
                        StockActual.Text = detalleGrano.Quintal.ToString();
                        lbPrecioQ.Text = producto.PrecioVenta.ToString();
                        lbPrecioLb.Text = (producto.PrecioVenta / ConversionQLb).ToString();
                        lbPrecioOnz.Text = (producto.PrecioVenta / ConversionQOnz).ToString();
                        break;
                    case "lb":
                        CheckLibra.Checked = true;
                        StockActual.Text = detalleGrano.Libras.ToString();
                        lbPrecioQ.Text = (producto.PrecioVenta * ConversionQLb).ToString();
                        lbPrecioLb.Text = producto.PrecioVenta.ToString();
                        lbPrecioOnz.Text = (producto.PrecioVenta / ConversionLOnz).ToString();
                        break;
                    case "onz":
                        CheckOnza.Checked = true;
                        StockActual.Text = detalleGrano.Onzas.ToString();
                        lbPrecioQ.Text = (producto.PrecioVenta * ConversionQOnz).ToString();
                        lbPrecioLb.Text = (producto.PrecioVenta * ConversionLOnz).ToString();
                        lbPrecioOnz.Text = producto.PrecioVenta.ToString();
                        break;
                }
            }
            catch
            {
                KryptonMessageBox.Show("Error interno al obtener la información", "Notificación");
                Close();
            }            
        }

        private void CheckQuintal_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckQuintal.Checked)
            {
                StockActual.Text = detalleGrano.Quintal.ToString();
                UMedida = "Q";
            }
        }

        private void CheckLibra_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckLibra.Checked)
            {
                StockActual.Text = detalleGrano.Libras.ToString();
                UMedida = "LB";
            }
        }

        private void CheckOnza_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckOnza.Checked)
            {
                StockActual.Text = detalleGrano.Onzas.ToString();
                UMedida = "ONZ";
            }
        }

        private void TxtCantidad_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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

        private bool ValidarCampos()
        {
            if (CheckQuintal.Checked == false && CheckLibra.Checked == false && CheckOnza.Checked == false)
            {
                KryptonMessageBox.Show("Debe seleccionar una Unidad de Medida", "Notificación");
                return false;
            }
            if (!string.IsNullOrEmpty(TxtCantidad.Text))
            {
                decimal compara = 0.00m;
                decimal Existencia = Convert.ToDecimal(StockActual.Text);
                decimal cantidadv = Convert.ToDecimal(TxtCantidad.Text);

                if (cantidadv <= compara)
                {
                    KryptonMessageBox.Show("Debe ingresar una cantidad válida en Precio Venta", "Notificación");
                    return false;
                }
                else if (cantidadv > Existencia)
                {
                    KryptonMessageBox.Show("La cantidad ingresada es mayor a las existencias actuales", "Notificación");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ListarDetalleFacturas listarDetalleFacturas = GetModelFactura();
                _principal._listaDetalleFacturas.Add(listarDetalleFacturas);
                _principal.cargarDGVDetalleFactura(_principal._listaDetalleFacturas);
                Close();
            }
        }

        private ListarDetalleFacturas GetModelFactura()
        {
            int Cantidad = Convert.ToInt32(TxtCantidad.Text);
            ListarDetalleFacturas detalleFactura = new ListarDetalleFacturas
            {
                ProductoId = producto.Id,
                Descripcion = producto.Descripcion +" ("+UMedida+")",
                Cantidad = Cantidad,
                Precio = GetPrecio(),
                SubTotal = producto.PrecioVenta * Cantidad,
                PrecioTotal = producto.PrecioVenta * Cantidad,
                EsGrano = true,
            };
            return detalleFactura;
        }


        private decimal GetPrecio()
        {
            decimal Precio = 0.00m;
            switch (UMedida)
            {
                case "Q":
                    Precio = decimal.Round(Convert.ToDecimal(lbPrecioQ.Text), 4);
                    break;
                case "LB":
                    Precio = decimal.Round(Convert.ToDecimal(lbPrecioLb.Text), 4);
                    break;
                case "ONZ":
                    Precio = decimal.Round(Convert.ToDecimal(lbPrecioOnz.Text), 4);
                    break;
            }
            return Precio;
        }
    }
}
