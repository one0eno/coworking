using Coworking.Api.Bussines.Models;
using Coworking.Api.DataAcces.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAcces.Mappers
{
    public static class AdminMapper
    {
        public static AdminEntity Map(Admin dto) {

            return new AdminEntity()
            {
                Email   = dto.Email,
                Id      = dto.Id,
                Name    = dto.Name,
                OfficeId= dto.OfficeId,
                Phone   = dto.Phone
            };
        }

        public static Admin Map(AdminEntity dto)
        {

            return new Admin()
            {
                Email = dto.Email,
                Id = dto.Id,
                Name = dto.Name,
                OfficeId = dto.OfficeId,
                Phone = dto.Phone
            };
        }

    }
}
