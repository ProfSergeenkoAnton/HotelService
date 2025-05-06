using HotelService.DataAcces.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.DataAcces.Data
{
    public class HotelServiceDbContext : DbContext
    {
        public HotelServiceDbContext(DbContextOptions<HotelServiceDbContext> options) : base(options) { }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<GuestEntity> Guests { get; set; }
        public DbSet<HouseKeepingEntity> HouseKeepings { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }
        public DbSet<RoomEntity> Rooms { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }
        public DbSet<ServiceOrderEntity> ServiceOrders { get; set; }
        public DbSet<UserEntity> Users { get; set; }


    }
}
