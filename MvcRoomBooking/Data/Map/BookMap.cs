using MvcRoomBooking.Models;
using System.Data.Entity.ModelConfiguration;

namespace MvcRoomBooking.Data.Map
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable("Book");

            HasKey(x => x.Id);

            HasRequired(x => x.User);
            HasRequired(x => x.Room).WithMany(x => x.Books);
        }

    }
}