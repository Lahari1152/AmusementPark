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

    public class PurchaseService
    {
        private readonly PurchaseRepository _purchaseRepository;

        public PurchaseService(PurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        public IEnumerable<Purchase> GetAllPurchases()
        {
            return _purchaseRepository.GetAll();
        }

        public Purchase GetPurchaseById(int id)
        {
            return _purchaseRepository.GetById(id);
        }

        public void CreatePurchase(Purchase purchase)
        {
            _purchaseRepository.Add(purchase);
        }

        public void UpdatePurchase(Purchase purchase)
        {
            _purchaseRepository.Update(purchase);
        }

        public void DeletePurchase(int id)
        {
            _purchaseRepository.Delete(id);
        }

        public IEnumerable<Purchase> GetPurchasesByUserId(int userId)
        {
            return _purchaseRepository.GetPurchasesByUserId(userId);
        }

        public object CreatePurchase(PurchaseDto purchaseDto)
        {
            throw new NotImplementedException();
        }

        public void UpdatePurchase(PurchaseDto purchaseDto)
        {
            throw new NotImplementedException();
        }
    }

}
