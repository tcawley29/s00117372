using S00117372_RAD302_CA.DAL;
using S00117372_RAD302_CA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S00117372_RAD302_CA.Controllers
{
    public class LegController : Controller
    {
        //
        // GET: /Leg/

        private DALITravel _repository;

        public LegController(DALITravel repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.TripList = _repository.GetAllTrips().Select(t => new { id = t.ID, value = t.Name }).Distinct();

            return View();
        }

        [HttpPost]
        public ActionResult Create(Leg leg)
        {
            if (ModelState.IsValid)
            {
                _repository.AddLeg(leg);

                return RedirectToAction("Index", "Home");
            }
            return View();
        }

    }
}
