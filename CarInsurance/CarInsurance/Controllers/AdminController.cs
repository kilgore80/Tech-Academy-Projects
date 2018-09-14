using CarInsurance.Models;
using CarInsurance.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (AutoInsuranceEntities db = new AutoInsuranceEntities())
            {
                var quotes = db.QuoteInfoes;
                var quotesVms = new List<QuotesVm>();
                foreach (var quote in quotes)
                {
                    var quoteVm = new QuotesVm();
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.EmailAddress = quote.EmailAddress;
                    quotesVms.Add(quoteVm);
                }

                return View(quotesVms);

            }
        }
    }
}