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
    public class ServiceOrderConfiguration : IEntityTypeConfiguration<ServiceOrderEntity>
    {
        public void Configure(EntityTypeBuilder<ServiceOrderEntity> builder)
        {
            builder.HasKey(so => so.ID);

            builder.
                HasOne(s => s.Services).
                WithMany(so => so.ServiceOrders);
        }
    }
}
