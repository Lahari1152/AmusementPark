using Business.DTO;
using Business.Service;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.Controller
{

    [ApiController]


    [Route("api/admins")]

    public class AdminController : ControllerBase
    {
        private readonly AdminService _adminService;

        public AdminController(AdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AdminDto>> GetAllAdmins()
        {
            var admins = _adminService.GetAllAdmins();
            return Ok(admins);
        }

        [HttpGet("{id}")]
        public ActionResult<AdminDto> GetAdminById(int id)
        {
            var admin = _adminService.GetAdminById(id);
            if (admin == null)
            {
                return NotFound();
            }
            return Ok(admin);
        }

        [HttpPost]
        public ActionResult<AdminDto> CreateAdmin(AdminDto adminDto)
        {
            var admin = _adminService.CreateAdmin(adminDto);
            return CreatedAtAction(nameof(GetAdminById), admin);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAdmin(int id, AdminDto adminDto)
        {
            if (id != adminDto.Id)
            {
                return BadRequest();
            }

            var admin = _adminService.GetAdminById(id);
            if (admin == null)
            {
                return NotFound();
            }

            _adminService.UpdateAdmin(adminDto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdmin(int id)
        {
            var admin = _adminService.GetAdminById(id);
            if (admin == null)
            {
                return NotFound();
            }

            _adminService.DeleteAdmin(id);

            return NoContent();
        }
    }
}