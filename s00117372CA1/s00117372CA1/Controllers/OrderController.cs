using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using s00117372CA1.Models;

namespace s00117372CA1.Controllers
{
    public class OrderController : Controller
    {
        private OrderContext db = new OrderContext();

        //
        // GET: /Order/

        /*public ActionResult Index()
        {
                return View(db.Orders.ToList());
        }*/

        //
        // GET: /Order/Details/5

        public ActionResult Index(string sortOrder, string searchTerm)
        {
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.TotalSortParm = sortOrder == "Total" ? "total_desc" : "Total";
            //mine
            var allOrders = db.Orders
            .Where(ar => searchTerm == null || ar.FirstName.Contains(searchTerm) || ar.LastName.Contains(searchTerm));
            
            //var findOrders = ordb.OrderDetails.Where(a => a.Album.Title.Contains(searchTerm));
            //return View("Index", findOrders);
            switch (sortOrder)
            {
                case "Date":
                    allOrders = allOrders.OrderBy(o => o.OrderDate);
                    break;
                case "Date_desc":
                    allOrders = allOrders.OrderByDescending(o => o.OrderDate);
                    break;
                case "Total":
                    allOrders = allOrders.OrderBy(o => o.Total);
                    break;
                case "Total_desc":
                    allOrders = allOrders.OrderByDescending(o => o.Total);
                    break;
            }

            return View(allOrders);
        }

        public ActionResult Details(int id = 1)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        //
        // GET: /Order/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Order/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(order);
        }

        //
        // GET: /Order/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        //
        // POST: /Order/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        //
        // GET: /Order/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        //
        // POST: /Order/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}