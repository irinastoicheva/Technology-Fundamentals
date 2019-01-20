namespace Library.Controllers
{
    using Library.Data;
    using Library.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    public class LibraryController : Controller
    {
        public ActionResult Index()
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                List<Book> books = db.Books.ToList();
                return View(books);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            using (LibraryDbContext db = new LibraryDbContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                Book oldBook = db.Books.FirstOrDefault(x => x.Id == id);
                if (oldBook == null)
                {
                    return RedirectToAction("Index");
                }

                return View(oldBook);
            }
        }

        [HttpPost]
        public ActionResult Edit(Book book)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
           
            using (LibraryDbContext db = new LibraryDbContext())
            {
                Book oldBook = db.Books.FirstOrDefault(x => x.Id == book.Id);
                if (oldBook == null)
                {
                    return RedirectToAction("Index");
                }

                oldBook.Title = book.Title;
                oldBook.Author = book.Author;
                oldBook.Price = book.Price;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                Book oldBook = db.Books.FirstOrDefault(x => x.Id == id);
                if (oldBook == null)
                {
                    return RedirectToAction("Index");
                }

                return View(oldBook);
            }
        }

        [HttpPost]
        public ActionResult Delete(Book book)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                if (book == null)
                {
                    return RedirectToAction("Index");
                }

                db.Books.Remove(book);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}