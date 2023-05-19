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
   public class VisitorService
    {
        
        private readonly VisitorRepository _visitorRepository;

        public VisitorService(VisitorRepository visitorRepository)
        {
            _visitorRepository = visitorRepository;
        }

        public IEnumerable<Visitor> GetAllVisitors()
        {
            return _visitorRepository.GetAll();
        }

        public Visitor GetVisitorById(int id)
        {
            return _visitorRepository.GetById(id);
        }

        public void CreateVisitor(Visitor visitor)
        {
            _visitorRepository.Add(visitor);
        }

        public void UpdateVisitor(Visitor visitor)
        {
            _visitorRepository.Update(visitor);
        }

        public void DeleteVisitor(int id)
        {
            _visitorRepository.Delete(id);
        }

        public object CreateVisitor(VisitorDto visitorDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateVisitor(VisitorDto visitorDto)
        {
            throw new NotImplementedException();
        }
    }

}

