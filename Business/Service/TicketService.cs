using Business.DTO;
using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    

    public class TicketService
    {
        private readonly TicketRepository _ticketRepository;

        public TicketService(TicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _ticketRepository.GetAll();
        }

        public Ticket GetTicketById(int id)
        {
            return _ticketRepository.GetById(id);
        }

        public void CreateTicket(Ticket ticket)
        {
            _ticketRepository.Add(ticket);
        }

        public void UpdateTicket(Ticket ticket)
        {
            _ticketRepository.Update(ticket);
        }

        public void DeleteTicket(int id)
        {
            _ticketRepository.Delete(id);
        }

        public IEnumerable<Ticket> GetTicketsByUserId(int userId)
        {
            return _ticketRepository.GetTicketsByUserId(userId);
        }

        public object CreateTicket(TicketDto ticketDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateTicket(TicketDto ticketDto)
        {
            throw new NotImplementedException();
        }
    }

}
