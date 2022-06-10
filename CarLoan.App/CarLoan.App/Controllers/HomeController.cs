using CarLoan.App.Models;
using ISLoans.Web.API_Router;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CarLoan.App.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Quote model)
        {
            model.createdOn = DateTime.Now;
            var result = await CarLoanDocumentService.InsertDocument(model);
            return RedirectToAction("AllCarLoans", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> AllCarLoans()
        {
            var QuoteViewModel = new QuoteViewModel();
            QuoteViewModel.QuoteList = await CarLoanDocumentService.GetAllQuotes();
            return View(QuoteViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int quoteID)
        {
            var QuoteViewModel = new QuoteViewModel();
            QuoteViewModel.QuoteID = quoteID;
            QuoteViewModel.Quote = await CarLoanDocumentService.GetQuotesByID(quoteID);
            return View(QuoteViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(QuoteViewModel model)
        {
            var result = await CarLoanDocumentService.UpdateQuote(model.Quote);
            return RedirectToAction("AllCarLoans", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int quoteID)
        {
            var QuoteViewModel = new QuoteViewModel();
            QuoteViewModel.QuoteID = quoteID;
            QuoteViewModel.Quote = await CarLoanDocumentService.GetQuotesByID(quoteID);
            return View(QuoteViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(QuoteViewModel model)
        {
            model.Quote.DeletedOn = DateTime.Now;
            var result = await CarLoanDocumentService.DeleteQuote(model.Quote);
            return RedirectToAction("AllCarLoans", "Home");
        }
    }
}
