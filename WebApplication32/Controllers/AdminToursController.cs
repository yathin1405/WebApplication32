using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication32.Data;
using WebApplication32.Models;

namespace WebApplication32.Controllers
{
    public class AdminToursController : Controller
    {
        private WebApplication32Context db = new WebApplication32Context();

        // GET: AdminTours
        public ActionResult Index()
        {
            return View(db.AdminTours.ToList());
        }

        // GET: AdminTours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminTour adminTour = db.AdminTours.Find(id);
            if (adminTour == null)
            {
                return HttpNotFound();
            }
            return View(adminTour);
        }

        // GET: AdminTours/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminTours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TourID,Tour_Name,Tour_Duration,TourDate,TourStartTime,Price,discount")] AdminTour adminTour)
        {
            if (ModelState.IsValid)
            {
                adminTour.Deposit = adminTour.deposit();
                db.AdminTours.Add(adminTour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adminTour);
        }

        // GET: AdminTours/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminTour adminTour = db.AdminTours.Find(id);
            if (adminTour == null)
            {
                return HttpNotFound();
            }
            return View(adminTour);
        }

        // POST: AdminTours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TourID,Tour_Name,Tour_Duration,Num_Adults,Num_Kids,TourDate,TourStartTime,Price,Deposit,GuestCost,Total_Cost,TTickets,discount")] AdminTour adminTour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adminTour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adminTour);
        }

        // GET: AdminTours/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminTour adminTour = db.AdminTours.Find(id);
            if (adminTour == null)
            {
                return HttpNotFound();
            }
            return View(adminTour);
        }

        // POST: AdminTours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdminTour adminTour = db.AdminTours.Find(id);
            db.AdminTours.Remove(adminTour);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
