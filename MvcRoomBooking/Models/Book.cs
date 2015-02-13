using System;

namespace MvcRoomBooking.Models
{
    public class Book
    {
        public int Id { get; set; }
        public Room Room { get; set; }
        public EBookStatus Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string User { get; set; }
    }

    public enum EBookStatus
    {
        InProgress = 1,
        Reserved = 2,
        InUse = 3,
        Canceled = 4,
        Completed = 5
    }
}