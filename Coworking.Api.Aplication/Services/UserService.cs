using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.DataAcces.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Aplication.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IAdminService _adminService;
        public UserService(IAdminService adminService, IUserRepository userRepository)
        {
            _adminService = adminService;
            _userRepository = userRepository;
        }

        public async Task GetUserName(int idUser, int idAdmin)
        {
            var user = await _userRepository.Get(idUser);

            var adminName  = await _adminService.GetAdminName(idAdmin);

            
            
        }

    }
}
