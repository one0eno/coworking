using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Mappers;
using Coworking.Api.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        /// <summary>
        /// Recupera el nombre del administrador
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {

            var admin = await _adminService.GetAdmin(id);
         
            if (admin == null) 
                return NotFound();
            return Ok(admin);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var admins = await _adminService.GetAllAdmins();

            if (admins == null)
                return NotFound();
            return Ok(admins);
        }

        /// <summary>
        /// Genera un nuevo administrador
        /// </summary>
        /// <param name="admin">Objeto admin</param>
        /// <returns></returns>
        [Produces("application/json", Type = typeof(AdminModel))]
        [HttpPost]
        public async Task<IActionResult> AddAdmin([FromBody] AdminModel  admin)
        {
            var name = await _adminService.AddAdmin(AdminMapper.Map(admin));
            if (name == null)
                return NotFound();
            return Ok(name);
        }

        [Produces("application/json", Type = typeof(AdminModel))]
        [HttpPut]
        public async Task<IActionResult> UpdateAdmin([FromBody] AdminModel admin)
        {
            var name = await _adminService.UpdateAdmin(AdminMapper.Map(admin));
            if (name == null)
                return NotFound();
            return Ok(name);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAdmin(int  id)
        {
            await _adminService.DeleteAdmin(id);
            return Ok();
        }
    }
}
