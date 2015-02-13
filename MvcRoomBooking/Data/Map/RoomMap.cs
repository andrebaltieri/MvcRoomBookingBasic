using MvcRoomBooking.Models;
using System.Data.Entity.ModelConfiguration;

namespace MvcRoomBooking.Data.Map
{
    public class RoomMap : EntityTypeConfiguration<Room>
    {
        public RoomMap()
        {
            ToTable("Room");

            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(60).IsRequired();
        }
    }

}