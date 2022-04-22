using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Helper
{
    public class Elemento
    {
        public Elemento(int _id, string _nombre)
        {
            Id = _id;
            Nombre = _nombre;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
