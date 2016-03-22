using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        // Making data context
        BookContext db = new BookContext();
 
        public ActionResult Index()
        {
            // Geting all objects Book from DB
            IEnumerable<Book> books = db.Books;
            // Sending Objects Books в ViewBag
            ViewBag.Books = books;
            // returning view
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // Adding to DB information about the purchase
            db.Purchases.Add(purchase);
            // Saving changes to DB
            db.SaveChanges();
            return "Спасибо, " + purchase.Person + ", за покупку!";
        }
    }
}