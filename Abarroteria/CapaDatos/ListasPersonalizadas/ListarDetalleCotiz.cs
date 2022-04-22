using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ListasPersonalizadas
{
    public class ListarDetalleCotiz
    {
        public Guid Id { get; set; } //0
        public Guid CotizacionId { get; set; } //1
        public int ProductoId { get; set; } //2
        public Guid ComboId { get; set; }//3
        public string Color { get; set; } //4
        public string Talla { get; set; }//5
        public string Estilo { get; set; } //6
        public string Descripcion { get; set; } //7
        public decimal Precio { get; set; } //8
        public int Cantidad { get; set; } //9
        public decimal Total { get; set; } //10
        public int DetalleColorId { get; set; } //11
        public int DetalleTallaId { get; set; } //12
        public int TallayColorId { get; set; } //13
        public int DetalleEstiloId { get; set; } //14
    }
}
