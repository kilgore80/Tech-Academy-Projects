using CarInsurance.Models;
using CarInsurance.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
         //private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AutoInsurance;Integrated Security=True;Connect Timeout=30;
                                            //Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AutoInfo(string firstName, string lastName, string emailAddress, string dateOfBirth, string carYear, string carMake, string carModel, bool dui, string tickets, bool coverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(dateOfBirth)
               || string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(tickets))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (AutoInsuranceEntities db = new AutoInsuranceEntities())
                {
                    var autoquote = new QuoteInfo();
                    autoquote.FirstName = firstName;
                    autoquote.LastName = lastName;
                    autoquote.EmailAddress = emailAddress;

                    db.QuoteInfoes.Add(autoquote);
                    db.SaveChanges();


                }
              
                return View("Success");
            }
        }
      
    }
}