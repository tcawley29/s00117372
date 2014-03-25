using S00117372_RAD302_CA.DAL;
using S00117372_RAD302_CA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S00117372_RAD302_CA.Controllers
{
    public class TripController : Controller
    {
        //
        // GET: /Trip/

        private DALITravel _repository;

        public TripController(DALITravel repository)
        {
            _repository = repository;
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

                return RedirectToAction("Index", "Home");
            }
            return View();
        }

    }
}
