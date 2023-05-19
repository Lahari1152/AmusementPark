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
    public class TicketRepository : IRepository<Ticket>
    {
        private readonly AmusementParkDbContext _dbContext;

        public TicketRepository(AmusementParkDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _dbContext.Tickets.ToList();
        }

        public Ticket GetById(int id)
        {
            return _dbContext.Tickets.Find(id);
        }

        public void Add(Ticket entity)
        {
            _dbContext.Tickets.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Ticket entity)
        {
            _dbContext.Tickets.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var ticket = _dbContext.Tickets.Find(id);
            if (ticket != null)
            {
                _dbContext.Tickets.Remove(ticket);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Ticket> GetTicketsByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}