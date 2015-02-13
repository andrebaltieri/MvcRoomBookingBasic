using MvcRoomBooking.Models;
using System.Data.Entity;

namespace MvcRoomBooking.Data
{
    public class RoomBookingDataContext : DbContext
    {
        public RoomBookingDataContext()
            :base("RoomBookingConnectionString")
        { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}