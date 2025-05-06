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
    public class BookingConfiguration : IEntityTypeConfiguration<BookingEntity>
    {
        public void Configure(EntityTypeBuilder<BookingEntity> builder)
        {
            builder.HasKey(b=>b.ID);

            builder.
                HasOne(g => g.Guest).
                WithMany(b => b.Bookings).
                HasForeignKey(b=>b.guestID);

            builder.
                HasOne(r => r.Room).
                WithMany(b => b.Bookings).
                HasForeignKey(b=>b.roomID);

            builder.
                HasOne(b => b.Payment).
                WithOne(p => p.Booking);
                

        }
    }
}
