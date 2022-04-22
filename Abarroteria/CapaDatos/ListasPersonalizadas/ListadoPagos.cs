using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ListasPersonalizadas
{
    public class ListaVentasProductos
    {
        public string Cliente { get; set; }
        public string Fecha { get; set; }
        public string Documento { get; set; }
        public string Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }
    }
}
