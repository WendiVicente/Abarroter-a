using CapaDatos.ListasPersonalizadas;
using CapaDatos.Repository;
using CapaDatos.Repository.PreciosRepository;
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

namespace POS.Forms
{
    public partial class DetallePrecios : BaseContext
    {
        private ProductosRepository _productoRepository = null;
        private TiposClienteRepository _clientesRepository = null;
        private TipoPrecioRepository _preciosRepository = null;
        ListarProductos _producto = null;

        public DetallePrecios(ListarProductos producto)
        {
            _productoRepository = new ProductosRepository(_context);
            _clientesRepository = new TiposClienteRepository(_context);
            _preciosRepository = new TipoPrecioRepository(_context);
            _producto = producto;
            InitializeComponent();
        }

        private void DetallePrecios_Load(object sender, EventArgs e)
        {            
            CargarPrecios();
        }
        
        public void CargarPrecios()
        {
            Producto prod = _productoRepository.Get(_producto.Id);
            lbNombreProducto.Text = prod.Descripcion;
            txtPrecioGeneral.Text = prod.PrecioVenta.ToString();
            txtPrecioEspecial.Text = prod.PrecioEspecial.ToString();
            txtPrecioMinimo.Text = prod.PrecioMinimo.ToString();

            if (prod.TieneEscalas)
            {
                var tipo = _preciosRepository.Get(_producto.Id);
                if (tipo != null)
                {
                    var detalleprecioslista = _preciosRepository.GetDetallePrecioListar(tipo.Id, 0);
                    if (detalleprecioslista != null)
                    {
                        List<Precios> _precios = new List<Precios>();
                        int min = 1;
                        int rev = 1;
                        int esp = 1;
                        int gob = 1;
                        foreach (var item in detalleprecioslista)
                        {
                            var tipoObtendio = _clientesRepository.GetTipo(item.TiposId);
                            if (tipoObtendio.TipoCliente == "Minorista")
                            {
                                _precios.Add(AgregarAListado(item, tipoObtendio.TipoCliente, min));
                            }
                            if (tipoObtendio.TipoCliente == "Revendedor")
                            {
                                _precios.Add(AgregarAListado(item, tipoObtendio.TipoCliente, rev));
                            }
                            if (tipoObtendio.TipoCliente == "Especial")
                            {
                                _precios.Add(AgregarAListado(item, tipoObtendio.TipoCliente, esp));
                            }
                            if (tipoObtendio.TipoCliente == "Gubernamental")
                            {
                                _precios.Add(AgregarAListado(item, tipoObtendio.TipoCliente, gob));
                            }
                        }
                        lbCantidadEscalas.Text = "Cantidad de Escalas: " +_precios.Count;
                        dgvEscalas.DataSource = typeof(List<>);
                        dgvEscalas.DataSource = _precios;
                        dgvEscalas.ClearSelection();
                    }
                }
            }
        }

        public Precios AgregarAListado(ListarDetallePrecios precio, string cliente, int contador) 
        {
            Precios p = new Precios() {
                Cliente = cliente,
                Escala = "Escala " + contador,
                De = precio.RangoInicio,
                A = precio.RangoFinal,
                Precio = precio.Precio
            };
            contador++;
            return p;
        }
    }

    public class Precios
    {
        public Precios() { }
        public string Cliente { get; set; }
        public string Escala { get; set; }
        public int De { get; set; }
        public int A { get; set; }
        public decimal Precio { get; set; }
    }
}
