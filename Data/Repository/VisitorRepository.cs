using Data.DataFolder;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repository.IRepository;

namespace Data.Repository
{
    public class VisitorRepository : IRepository<Visitor>
    {
        private readonly AmusementParkDbContext _dbContext;

        public VisitorRepository(AmusementParkDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Visitor> GetAll()
        {
            return _dbContext.Visitors.ToList();
        }

        public Visitor GetById(int id)
        {
            return _dbContext.Visitors.Find(id);
        }

        public void Add(Visitor entity)
        {
            _dbContext.Visitors.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Visitor entity)
        {
            _dbContext.Visitors.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var visitor = _dbContext.Visitors.Find(id);
            if (visitor != null)
            {
                _dbContext.Visitors.Remove(visitor);
                _dbContext.SaveChanges();
            }
        }
    }
}
