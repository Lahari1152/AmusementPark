using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DTO;
using Data.Models;
using Data.Repository;

namespace Business.Service
{
   
    

    public class AttractionService 
    {
        private readonly AttractionRepository _attractionRepository;

        public AttractionService(AttractionRepository attractionRepository)
        {
            _attractionRepository = attractionRepository;
        }

        public IEnumerable<Attraction> GetAllAttractions()
        {
            return _attractionRepository.GetAll();
        }

        public Attraction GetAttractionById(int id)
        {
            return _attractionRepository.GetById(id);
        }

        public void CreateAttraction(Attraction attraction)
        {
            _attractionRepository.Add(attraction);
        }

        public void UpdateAttraction(Attraction attraction)
        {
            _attractionRepository.Update(attraction);
        }

        public void DeleteAttraction(int id)
        {
            _attractionRepository.Delete(id);
        }

        public IEnumerable<Attraction> GetAttractionsByCategory(string category)
        {
            return _attractionRepository.GetAttractionsByCategory(category);
        }

        public object CreateAttraction(AttractionDto attractionDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateAttraction(AttractionDto attractionDto)
        {
            throw new NotImplementedException();
        }
    }

}
