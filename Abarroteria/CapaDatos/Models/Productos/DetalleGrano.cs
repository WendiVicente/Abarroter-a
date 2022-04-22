using CapaDatos.Models.Cotizacion;
using CapaDatos.Models.CuentaCobrar;
using CapaDatos.Models.Pedidos;
using CapaDatos.Models.Productos.Combos;
using CapaDatos.Models.ProductosToFacturar;
using CapaDatos.Models.Vales;
using sharedDatabase.Models;
using System.Collections.Generic;

namespace CapaDatos.Models.Productos
{
    public class DetalleGrano
    {
        public DetalleGrano()
        {
            //DetalleCombos = new List<DetalleCombo>();
            //DetalleVales = new List<DetalleVale>();
            //DetalleCotizaciones = new List<DetalleCotizacion>();
            //DetallePedidos = new List<DetallePedidos>();
            //DetalleFacturas = new List<DetalleFactura>();
            //ProductosEnReserva = new List<ProductosReserva>();
            //SolicitudDetalles = new List<SolicitudDetalle>();
            //temporalProductostofacturar = new List<TemporalProductos>();
        }
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public decimal Onzas { get; set; }
        public decimal Libras { get; set; }
        public decimal Quintal { get; set; }
        
        //public Producto Producto { get; set; }
        //public ICollection<DetalleCombo> DetalleCombos { get; set; }
        //public ICollection<DetalleVale> DetalleVales { get; set; }
        //public ICollection<DetalleCotizacion> DetalleCotizaciones { get; set; }
        //public ICollection<DetallePedidos> DetallePedidos { get; set; }
        //public ICollection<DetalleFactura> DetalleFacturas { get; set; }
        //public ICollection<ProductosReserva> ProductosEnReserva { get; set; }
        //public ICollection<SolicitudDetalle> SolicitudDetalles { get; set; }
        //public ICollection<TemporalProductos> temporalProductostofacturar { get; set; }
    }
}
