using HotelService.DataAcces.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.DataAcces.Configurations
{
    public class HouseKeepingConfiguration : IEntityTypeConfiguration<HouseKeepingEntity>
    {
        public void Configure(EntityTypeBuilder<HouseKeepingEntity> builder)
        {
            builder.HasKey(h=>h.ID);

            builder.
                HasOne(r => r.Room).
                WithOne(h => h.HouseKeeping);


        }
    }
}
