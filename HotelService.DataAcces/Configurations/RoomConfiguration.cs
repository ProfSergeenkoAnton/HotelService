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
    public class RoomConfiguration : IEntityTypeConfiguration<RoomEntity>
    {
        public void Configure(EntityTypeBuilder<RoomEntity> builder)
        {
            builder.HasKey(r=>r.ID);

            builder.
                HasMany(b => b.Bookings).
                WithOne(b => b.Room);

            builder.
                HasIndex(r=>r.roomNumber).
                IsUnique();
        }
    }
}
