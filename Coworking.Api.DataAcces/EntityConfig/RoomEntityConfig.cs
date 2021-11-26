using Coworking.Api.DataAcces.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAcces.EntityConfig
{
    public class RoomEntityConfig
    {

        public static void SetEntityBuilder(EntityTypeBuilder<RoomEntity> entityBuilder)
        {

            entityBuilder.ToTable("Rooms");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //entityBuilder.HasOne(x => x.Office2Room).WithMany(x => x.Office2Room).HasForeignKey(x => x.OfficeId);
            //entityBuilder.HasOne(x => x.Room).WithMany(x => x.Office2Room).HasForeignKey(x => x.RoomId);

            //entityBuilder.HasKey(x => new { x.OfficeId, x.RoomId });
            //entityBuilder.Property(x => x.OfficeId).IsRequired();
            //entityBuilder.Property(x => x.RoomId).IsRequired();

        }

    }
}
