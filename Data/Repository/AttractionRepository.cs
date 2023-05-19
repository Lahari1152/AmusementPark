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
    public class AttractionRepository : IRepository<Attraction>
    {
        private readonly AmusementParkDbContext _dbContext;

        public AttractionRepository(AmusementParkDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Attraction> GetAll()
        {
            return _dbContext.Attractions.ToList();
        }

        public Attraction GetById(int id)
        {
            return _dbContext.Attractions.Find(id);
        }

        public void Add(Attraction entity)
        {
            _dbContext.Attractions.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Attraction entity)
        {
            _dbContext.Attractions.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var attraction = _dbContext.Attractions.Find(id);
            if (attraction != null)
            {
                _dbContext.Attractions.Remove(attraction);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Attraction> GetAttractionsByCategory(string category)
        {
            throw new NotImplementedException();
        }
    }
}
