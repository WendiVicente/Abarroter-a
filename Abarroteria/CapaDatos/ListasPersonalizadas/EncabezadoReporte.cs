using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ListasPersonalizadas
{
    public class EncabezadoReporte
    {
        public string usuario { get; set; }
        public string nombreVendedor { get; set; }
        public string nombreCliente { get; set; }
        public string nitCliente { get; set; }
        public string direccionCliente { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public string sucursal { get; set; }
    }
}
