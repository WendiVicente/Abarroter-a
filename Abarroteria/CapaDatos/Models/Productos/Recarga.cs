using CapaDatos.Models.Sucursales;
using sharedDatabase.Models;
using sharedDatabase.Models.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models.Productos
{
    public class Recarga
    {
        public int Id { get; set; }
        [Required]
        public int CategoriaId { get; set; }
        [Required]
        public int SucursalId { get; set; }
        [Required]
        public int ProveedorId { get; set; }
        [Required]
        public string Empresa { get; set; }
        public string Tipo { get; set; }
        public string CodigoBarras { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public string Vigencia { get; set; }
        public string PrecioVenta { get; set; }
        public bool Deleted { get; set; }

        public Categoria Categoria { get; set; }
        public Sucursal Sucursal { get; set; }
        public Proveedor Proveedor { get; set; }

    }
}
