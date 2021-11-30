using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Bussines.Models;
using Coworking.Api.DataAcces.Contracts.Repositories;
using Coworking.Api.DataAcces.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Aplication.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        public AdminService(IAdminRepository adminRepository) {

            _adminRepository = adminRepository;

            
        }

        public async Task<string> GetAdminName(int id) {

            var entidad = await _adminRepository.Get(id);
            return entidad.Name;
        }

        public async Task<Admin> AddAdmin(Admin admin) {

            var addedEntity = await _adminRepository.Add(AdminMapper.Map(admin));
            return AdminMapper.Map(addedEntity);
        }
    }
}
