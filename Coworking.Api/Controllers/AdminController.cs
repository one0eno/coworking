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
            var name = await _adminService.GetAdminName(id);
            if (name == null) 
                return NotFound();
            return Ok(name);
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
    }
}
