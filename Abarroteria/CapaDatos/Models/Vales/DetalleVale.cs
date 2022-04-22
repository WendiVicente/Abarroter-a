using CapaDatos.Models.Productos;
using CapaDatos.Models.Productos.Combos;
using sharedDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models.Vales
{
    public class DetalleVale
    {
        public Guid Id { get; set; }
        public int? ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal precio { get; set; }
        public Guid AsignacionValeId { get; set; }
        public Guid? ComboId { get; set; }
        public int? DetalleColorId { get; set; }
        public int? DetalleTallaId { get; set; }
        public int? DetalleColorTallaId { get; set; }
        public int? DetalleEstiloId { get; set; }
        public int? DetalleGranoId { get; set; }
        public AsignacionVale AsignacionVale { get; set; }
        public Producto Producto { get; set; }
        public Combo Combo { get; set; }
        public DetalleColor DetalleColor { get; set; }
        public DetalleTalla DetalleTalla { get; set; }
        public DetalleColorTalla DetalleColorTalla { get; set; }
        public DetalleEstilo DetalleEstilo { get; set; }
        public DetalleGrano DetalleGrano { get; set; }

    }


}
