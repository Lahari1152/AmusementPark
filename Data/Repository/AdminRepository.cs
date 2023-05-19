using Data.DataFolder;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repository.IRepository;

namespace Data.Repository
{
    
        
    public class AdminRepository : IRepository<Admin>
    {
        private readonly AmusementParkDbContext _dbContext;

        public AdminRepository(AmusementParkDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Admin> GetAll()
        {
            return _dbContext.Admins.ToList();
        }

        public Admin GetById(int id)
        {
            return _dbContext.Admins.Find(id);
        }

        public void Add(Admin entity)
        {
            _dbContext.Admins.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Admin entity)
        {
            _dbContext.Admins.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var admin = _dbContext.Admins.Find(id);
            if (admin != null)
            {
                _dbContext.Admins.Remove(admin);
                _dbContext.SaveChanges();
            }
        }

        public Admin GetByUsername(string username)
        {
            return _dbContext.Admins.FirstOrDefault(admin => admin.Name == username);
        }
    }


}
