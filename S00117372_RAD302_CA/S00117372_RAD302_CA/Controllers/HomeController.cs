using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using S00117372_RAD302_CA.DAL;
using S00117372_RAD302_CA.Models;


namespace S00117372_RAD302_CA.Controllers
{
    public class HomeController : Controller
    {


        private DALITravel _repository;

        public HomeController(DALITravel repository)
        {
            _repository = repository;
        }


        public ActionResult Index()
        {
            var trips = _repository.GetAllTrips();
            return View(trips.ToList());
        }

        public ActionResult ListLegs(int? tripID)
        {
            var legs = _repository.GetLegsForTrip(1);
            return PartialView("_ListOfLegs", legs);
        }



        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Trip trip)
        {
            if (ModelState.IsValid)
            {
                trip.Viable = false;
                trip.Complete = false;

                _repository.AddTrip(trip);

                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult GetGuestsOnLeg(int legId)
        {
            var guests = _repository.GetGuestsOnLeg(legId);
            if (!guests.Any())
                ViewBag.NoGuests = "empty";
            var leg = _repository.GetLeg(legId);
            ViewBag.Start = leg.StartLocation;
            ViewBag.Finish = leg.FinishLocation;
            ViewBag.LegId = leg.ID;
            return PartialView("_GuestList", guests);
        }
    }
}
