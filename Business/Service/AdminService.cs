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
 

    public class AdminService 
    {
        private readonly AdminRepository _adminRepository;

        public AdminService(AdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public IEnumerable<Admin> GetAllAdmins()
        {
            return _adminRepository.GetAll();
        }

        public Admin GetAdminById(int id)
        {
            return _adminRepository.GetById(id);
        }

        public void CreateAdmin(Admin admin)
        {
            _adminRepository.Add(admin);
        }

        public void UpdateAdmin(Admin admin)
        {
            _adminRepository.Update(admin);
        }

        public void DeleteAdmin(int id)
        {
            _adminRepository.Delete(id);
        }

        public Admin GetAdminByUsername(string username)
        {
            return _adminRepository.GetByUsername(username);
        }

        public void UpdateAdmin(AdminDto adminDto)
        {
            throw new NotImplementedException();
        }

        public object CreateAdmin(AdminDto adminDto)
        {
            throw new NotImplementedException();
        }
    }

}
