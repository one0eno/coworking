using Coworking.Api.DataAcces.Contracts.Repositories;
using Coworking.Api.DataAcces.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.CrossCuting.Register
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services) {

            return AddRegsiterServices(services);
           
        }

        public static IServiceCollection AddRegsiterServices(IServiceCollection services) {

            services.AddTransient<IAdminRepository, AdminRepository>();

            return services;

        }

        public static IServiceCollection AddRegsiterRepositories(IServiceCollection services)
        {
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<IBookingRepository, BookingRepository>();
            services.AddTransient<IOfficeRepository, OfficeRepository>();
            services.AddTransient<IRoomRepository, RoomRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
    }
}
