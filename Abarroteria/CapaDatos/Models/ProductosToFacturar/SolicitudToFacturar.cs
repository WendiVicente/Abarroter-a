using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos.Models.ProductosToFacturar
{
    public class SolicitudToFacturar
    {

        public SolicitudToFacturar()
        {
            SolicitudDetalles = new List<SolicitudDetalle>();
        }

        public Guid Id { get; set; }
        public string NoSolicitud { get; set; }
        public string NombreCliente { get; set; }
        public string UserId { get; set; }
        public string Vendedor { get; set; }
        public DateTime FechaVenta { get; set; }
        public bool Estado { get; set; }

        public ICollection<SolicitudDetalle> SolicitudDetalles { get; set; }




    }
}
