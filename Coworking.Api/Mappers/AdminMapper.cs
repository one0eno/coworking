using Coworking.Api.Bussines.Models;
using Coworking.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.Mappers
{
    public class AdminMapper
    {
        public static Admin Map(AdminModel model)
        {

            return new Admin()
            {
                Email = model.Email,
                Name = model.Name,
                Phone = model.Phone,
                HireDate = DateTime.Now
            };
        }

        public static AdminModel Map(Admin model)
        {

            return new AdminModel()
            {
                Email = model.Email,
                Name = model.Name,
                Phone = model.Phone,
               
            };
        }
    }
}
