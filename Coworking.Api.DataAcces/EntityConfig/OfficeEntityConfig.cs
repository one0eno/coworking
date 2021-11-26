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
    public class OfficeEntityConfig
    {

        public static void SetEntityBuilder(EntityTypeBuilder<OfficeEntity> entityBuilder)
        {

            entityBuilder.ToTable("Offices");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //Estamos diciendo que una oficina tiene realcion con un Admin
            //entityBuilder.HasOne(x => x.Admin).WithOne(x => x.Office);
            entityBuilder.HasOne(x => x.Booking).WithOne(x => x.Office);
            //entityBuilder.HasMany(x => x.Office2Room).WithOne(x => x.Office);

        }

    }
}
