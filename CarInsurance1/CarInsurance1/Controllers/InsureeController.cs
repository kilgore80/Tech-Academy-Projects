using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance1.Models;

namespace CarInsurance1.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        public ActionResult CustomerQuote()
        {
            return View(db.Insurees);
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (string.IsNullOrEmpty(insuree.FirstName) || string.IsNullOrEmpty(insuree.LastName) || string.IsNullOrEmpty(insuree.EmailAddress) || string.IsNullOrEmpty(Convert.ToString(insuree.DateOfBirth))
             || string.IsNullOrEmpty(Convert.ToString(insuree.CarYear)) || string.IsNullOrEmpty(insuree.CarMake) || string.IsNullOrEmpty(insuree.CarModel) || string.IsNullOrEmpty(Convert.ToString(insuree.SpeedingTickets)))
            {
                return View("~/Views/Shared/Error.cshtml");
            }

            DateTime age = Convert.ToDateTime(insuree.DateOfBirth);
            int year = DateTime.Now.Year - age.Year;

            decimal quote = insuree.Quote + 50m;

            //This is for the age portion of the exercise.
            if(year < 18)
            {
                quote = quote + 100m;
            }
            else if (year < 25)
            {
                quote = quote + 25m;
            }
            else if (year > 100)
            {
                quote = quote + 25m;
            }

            //This is for the cars age portion
            int carAge = Convert.ToInt16(insuree.CarYear);


            if(carAge < 2000)
            {
                quote = quote + 25m;
            }
            else if(carAge > 2015)
            {
                quote = quote + 25m;
            }
            
            //This is for the car make
            string carMake = insuree.CarMake.ToLower();

            if(carMake == "porsche")
            {
                quote = quote + 25m;
            }

            //This is for the car model

            string carModel = insuree.CarModel.ToLower();

            if(carModel == "911 carrera" || carModel == "911" || carModel == "carrera")
            {
                quote = quote + 25m; 
            }

            int speedTix = Convert.ToInt16(insuree.SpeedingTickets);

            if(speedTix > 0)
            {
                quote = quote + (speedTix * 10m);
            }

            //Dui

            bool dui = insuree.DUI;

            if(dui == true)
            {
                quote = quote * 1.25m;
            }

            //Coverage 

            bool coverage = insuree.CoverageType;
            if(coverage == true)
            {
                quote = quote * 1.50m;
            }

           
           insuree.Quote = quote;

            if (ModelState.IsValid)
            {    
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("CustomerQuote");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        //[HttpPost]
        ////Admin quote
        //public ActionResult Quote(string firstName, string lastName, string emailAddress, string dateOfBirth, string carYear, string carMake, string carModel, bool dui, string tickets, bool coverage, decimal iQuote)
        //{
        //    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(dateOfBirth)
        //       || string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(tickets))
        //    {
        //        return View("~/Views/Shared/Error.cshtml");
        //    }
        //    else
        //    {
        //        using (InsuranceEntities db = new InsuranceEntities())
        //        {
        //            var adminQuote = new Insuree();
        //            adminQuote.FirstName = firstName;
        //            adminQuote.LastName = lastName;
        //            adminQuote.EmailAddress = emailAddress;
        //            adminQuote.Quote = iQuote;
        //        }
        //        return View();
        //    }

        //}
        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
