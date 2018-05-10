using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackatonApp.Models;
using HackatonData.Models;
using HackatonData;

namespace HackatonApp.Controllers
{
    public class HomeController : Controller
    {
        public IDebtorService _debtorService;

        public HomeController(IDebtorService debtorService)
        {
            _debtorService = debtorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost]
        public IActionResult DebtorForm(DebtorViewModel debtor)
        {
            Debitor debtorModel = new Debitor()
            {
                Debitor_Navn1 = debtor.Name1,
                Debitor_Navn2 = debtor.Name2,
                Debitor_Adresse1 = debtor.Address1,
                Debitor_Adresse2 = debtor.Address2,
                Debitor_EPost = debtor.Email,
                Debitor_Fodselsdato = debtor.DateOfBirth,
                Debitor_Kategori = "P",
                Debitor_Kontakt = debtor.Contact,
                Debitor_KontoNr = debtor.AccountNumber,
                Debitor_LandKode = debtor.CountryCode,
                Debitor_Postnr = debtor.PostNr,
                Debitor_Sprak = debtor.Language,
                Debitor_Sted = debtor.Location
            };
            _debtorService.CreateNewDebtor(debtorModel);

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
