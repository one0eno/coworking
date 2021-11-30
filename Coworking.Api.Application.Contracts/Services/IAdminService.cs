﻿using Coworking.Api.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Contracts.Services
{
    public interface IAdminService
    {
        Task<string> GetAdminName(int id);

        Task<Admin> AddAdmin(Admin admin);


    }
}
