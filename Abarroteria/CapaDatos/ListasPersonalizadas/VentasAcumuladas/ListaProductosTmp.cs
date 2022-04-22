using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ListasPersonalizadas.VentasAcumuladas
{
    public class ListaProductosTmp
    {

        public int Id { get; set; }//0
        public string Color { get; set; }//1
        public string Talla { get; set; }//2
        public string Descripcion { get; set; }//3

        public int Cantidad { get; set; }//4
        public decimal Precio { get; set; }//5
        public decimal Descuento { get; set; }//6
        public decimal SubTotal { get; set; }//7
        public decimal PrecioTotal { get; set; }//8        

        public int ProductoId { get; set; }//9
        public Guid ComboId { get; set; }//10
        public int DetalleColorId { get; set; }//11
        public int DetalleTallaId { get; set; }//12
        public int TallayColorId { get; set; }//13
        public bool Acciones { get; set; }//14
        public bool IsActive { get; set; }//15
        public int DetalleEstiloId { get; set; }//16
        public string Estilo { get; set; }//17
    }
}
