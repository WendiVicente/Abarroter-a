using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ListasPersonalizadas.VentasAcumuladas
{
    public class ListaFacturacion
    {
        public Guid idDocumento { get; set; }
        public int idTipoDocumento { get; set; }
        public string Documento { get; set; }
        public DateTime Fecha { get; set; }
        public string Nit { get; set; }
        public string Nombre { get; set; }
        public string Vendedor { get; set; }
        public string Valor { get; set; }
        public bool Facturar { get; set; }
        public int ClienteId { get; set; }
        public bool Temporales { get; set; }

    }
}
