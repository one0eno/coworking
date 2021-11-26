using Coworking.Api.DataAcces.Contracts;
using Coworking.Api.DataAcces.Contracts.Entities;
using Coworking.Api.DataAcces.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAcces
{
    public class CoworkingDBContext: DbContext ,ICoworkingDBContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AdminEntity> Admins { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<OfficeEntity> Offices { get; set; }
        public DbSet<Offices2RoomEntity> Offices2Rooms{ get; set; }
        public DbSet<Room2ServicesEntity> Room2Services{ get; set; }
        public DbSet<RoomEntity> Rooms{ get; set; }
        public DbSet<ServicesEntity> Services { get; set; }

        public CoworkingDBContext(DbContextOptions options) : base(options) 
        {

        }

        public CoworkingDBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            AdminEntityConfig.SetEntityBuilder(modelBuilder.Entity<AdminEntity>());
            UserEntityConfig.SetEntityBuilder(modelBuilder.Entity<UserEntity>());
            
            BookEntityConfig.SetEntityBuilder(modelBuilder.Entity<BookingEntity>());
            OfficeEntityConfig.SetEntityBuilder(modelBuilder.Entity<OfficeEntity>());
            Office2RoomEntityConfig.SetEntityBuilder(modelBuilder.Entity<Offices2RoomEntity>());
            Room2ServiceEntityConfig.SetEntityBuilder(modelBuilder.Entity<Room2ServicesEntity>());
            RoomEntityConfig.SetEntityBuilder(modelBuilder.Entity<RoomEntity>());
            ServiceEntityConfig.SetEntityBuilder(modelBuilder.Entity<ServicesEntity>());

            base.OnModelCreating(modelBuilder);

        }
    }
}
