using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models.Productos
{
    public class DetalleRecarga
    {
        public int Id { get; set; }
        public int? RecargaId { get; set; }
        public string Empresa { get; set; }
        public string Descripcion { get; set; }
        public string Numero { get; set; }
        public decimal Monto { get; set; }
        public Guid? FacturaId { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
    }
}
