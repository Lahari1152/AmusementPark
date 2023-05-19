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
    public class PurchaseRepository : IRepository<Purchase>
    {
        private readonly AmusementParkDbContext _dbContext;

        public PurchaseRepository(AmusementParkDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Purchase> GetAll()
        {
            return _dbContext.Purchases.ToList();
        }

        public Purchase GetById(int id)
        {
            return _dbContext.Purchases.Find(id);
        }

        public void Add(Purchase entity)
        {
            _dbContext.Purchases.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Purchase entity)
        {
            _dbContext.Purchases.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var purchase = _dbContext.Purchases.Find(id);
            if (purchase != null)
            {
                _dbContext.Purchases.Remove(purchase);
                _dbContext.SaveChanges();
            }
        }

        // Additional methods specific to Purchase entity
        public IEnumerable<Purchase> GetPurchasesByUserId(int userId)
        {
            return _dbContext.Purchases.Where(p => p.UserId == userId).ToList();
        }
    }
}