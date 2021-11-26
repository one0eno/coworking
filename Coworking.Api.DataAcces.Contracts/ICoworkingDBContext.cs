using Coworking.Api.DataAcces.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAcces.Contracts
{
    public interface ICoworkingDBContext
    {
       
       DbSet<UserEntity> Users { get; set; }
       DbSet<AdminEntity> Admins { get; set; }
       DbSet<BookingEntity> Bookings { get; set; }
       DbSet<OfficeEntity> Offices { get; set; }
       DbSet<Offices2RoomEntity> Offices2Rooms { get; set; }
       DbSet<Room2ServicesEntity> Room2Services { get; set; }
       DbSet<RoomEntity> Rooms { get; set; }
       DbSet<ServicesEntity> Services { get; set; }
    }
}
