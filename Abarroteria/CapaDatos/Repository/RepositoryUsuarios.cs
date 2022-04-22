using CapaDatos.Data;
using CapaDatos.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repository
{
    public class RepositoryUsuarios
    {
        private Context _context = null;

        public RepositoryUsuarios(Context context)
        {
            _context = context;
        }

        public IList<User> GetlistaUsuarios()
        {
            return _context.Users
                .Where(a => a.IsDeleted == false)
                
                .ToList();
        }
        public User Get(string iduser )
        {
            return _context.Users
                .Where(a => a.Id == iduser).FirstOrDefault();

                
        }
        public void Update(User user, bool saveChanges = true)
        {
            _context.Entry(user).State = System.Data.Entity.EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }


    }
}
