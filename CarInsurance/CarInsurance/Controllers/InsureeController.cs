using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();
        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }
        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }
        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarMode,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid) return View(table);

            //compute monthly quote according to the rules
            table.Quote = CalculateQuote(table);

            db.Tables.Add(table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarMode,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid) return View(table);

            //recalculate in case any inputs changed
            table.Quote = CalculateQuote(table);

                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");       
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var table = db.Tables.Find(id);
            db.Tables.Remove(table);
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

        //The view can show First/Last/Email/Quote columns
        public ActionResult Admin()
        {
            return View(db.Tables.ToList());
        }
        //Adding calculation logic
        private decimal CalculateQuote(Table t)
        {
            decimal total = 50m; //$50 per month

            //age adjustments
            int age = GetAge(t.DateOfBirth);
            if (age <= 18) total += 100m;
            else if (age >= 19 && age <= 25) total += 50m;
            else if (age >= 26) total += 25m;

            //Car year
            if (t.CarYear < 2000) total += 25m;
            if (t.CarYear > 2015) total += 25m;

            //Make/Model
            bool isPorche = !string.IsNullOrWhiteSpace(t.CarMake) &&
                            t.CarMake.Trim().Equals("Porsche", StringComparison.OrdinalIgnoreCase);
            if (isPorche)
            {
                total += 25m; //Porsche
                if (!string.IsNullOrWhiteSpace(t.CarMode) &&
                    t.CarMode.Trim().Equals("911 Carrera", StringComparison.OrdinalIgnoreCase))
                {
                    total += 25m; //additional for 911 Carrera
                }
            }
            //$10 per speeding ticket
            total += 10m * Math.Max(0, t.SpeedingTickets);

            //DUI adds 25%
            if (t.DUI) total *= 1.25m;

            //Full coverage adds 50%
            if (t.CoverageType) total *= 1.50m;

            //Round for display/storage
            return Math.Round(total, 2);
        }
            //Helper to compute integer age correctly
            private int GetAge(DateTime dob)
            {
                var today = DateTime.Today;
                int age = today.Year - dob.Year;
                if (dob.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
    }

