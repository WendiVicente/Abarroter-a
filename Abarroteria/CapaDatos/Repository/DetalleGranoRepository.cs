using CapaDatos.Data;
using CapaDatos.ListasPersonalizadas;
using CapaDatos.Models.Bancos;
using CapaDatos.Models.Productos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos.Repository
{
    public class DetalleGranoRepository
    {
        private Context _context = null;

        public DetalleGranoRepository(Context context)
        {
            _context = context;
        }

        public void Add(DetalleGrano DetalleGranos, bool saveChanges = true)
        {
            _context.DetalleGranos.Add(DetalleGranos);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void Update(DetalleGrano DetalleGranos, bool saveChanges = true)
        {
            _context.Entry(DetalleGranos).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public List<DetalleGrano> GetAll()
        {
            return _context.DetalleGranos.ToList();
        }

        public DetalleGrano GetGranosProd(int codigoproducto)
        {
            return _context.DetalleGranos
                 .Where(r => r.ProductoId == codigoproducto)
                 .FirstOrDefault();
        }

        public DetalleGrano GetDetalleGranos(int id)
        {
            return _context.DetalleGranos
                 .Where(r => r.Id == id)
                 .FirstOrDefault();
        }

        public void DeleteDetalleGranos(DetalleGrano DetalleGranos)
        {
            _context.Entry(DetalleGranos).State = EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
