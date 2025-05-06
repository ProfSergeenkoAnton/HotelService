using HotelService.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.DataAccess.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<PaymentEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentEntity> builder)
        {
            builder.HasKey(p=>p.ID);

            builder.
                HasOne(b => b.Booking).
                WithOne(p => p.Payment).
                HasForeignKey<PaymentEntity>(p=>p.BookingID);

          
               
        }
    }
}
