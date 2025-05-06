
using HotelService.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelService.DataAccess.Configurations
{
    public class GuestConfiguration : IEntityTypeConfiguration<GuestEntity>
    {
        public void Configure(EntityTypeBuilder<GuestEntity> builder)
        {
            builder.HasKey(g => g.ID);

            builder.HasMany(b => b.Bookings).
                WithOne(g => g.Guest).HasForeignKey(f=>f.guestID);

            builder.HasMany(s => s.Services).WithMany(g => g.Guests);
        }
    }
}
