using MvcRoomBooking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MvcRoomBooking.Controllers
{
    public class BookController : Controller
    {
        private RoomBookingDataContext db = new RoomBookingDataContext();

        // GET: Book
        public ActionResult Index()
        {
            ViewBag.Rooms = db.Rooms.ToList();
            return View();
        }

        public PartialViewResult CheckBook(int Room, DateTime StartDate, DateTime EndDate)
        {
            Thread.Sleep(3000);

            return PartialView("CheckBookResult");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}