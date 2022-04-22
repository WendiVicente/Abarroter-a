using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ListasPersonalizadas
{
    public class ListarRecargas
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string Categoria { get; set; }
        public int SucursalId { get; set; }
        public string Sucursal { get; set; }
        public int ProveedorId { get; set; }
        public string Proveedor { get; set; }
        public string Empresa { get; set; }
        public string Tipo { get; set; }
        public string CodigoBarras { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public string Vigencia { get; set; }
        public string PrecioVenta { get; set; }
        public bool Deleted { get; set; }
    }
}
