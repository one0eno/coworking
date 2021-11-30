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


        public async Task<IEnumerable<Admin>> GetAllAdmins()
        {
            var admins = await  _adminRepository.GetAll();
            return admins.Select(AdminMapper.Map);
        }

        public async Task<Admin> GetAdmin(int id) {

            var entidad = await _adminRepository.Get(id);
            return AdminMapper.Map(entidad) ;
        }

        public async Task<Admin> AddAdmin(Admin admin) {

            var addedEntity = await _adminRepository.Add(AdminMapper.Map(admin));
            return AdminMapper.Map(addedEntity);
        }

        
        public async Task<int> DeleteAdmin(int id)
        {

            var addedEntity = await _adminRepository.DeleteAsync(id);
            return id;
        }

        public async Task<Admin> UpdateAdmin(Admin admin)
        {

            var addedEntity = await _adminRepository.Update(AdminMapper.Map(admin));
            return AdminMapper.Map(addedEntity);
        }
    }
}
