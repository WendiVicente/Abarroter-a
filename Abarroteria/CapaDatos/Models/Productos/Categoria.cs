using CapaDatos.Models.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharedDatabase.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Productos = new List<Producto>();
            Recargas = new List<Recarga>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Inactivo { get; set; }
        public byte[] Imagen { get; set; }

        public ICollection<Producto> Productos { get; set; }
        public ICollection<Recarga> Recargas { get; set; }
    }
}
