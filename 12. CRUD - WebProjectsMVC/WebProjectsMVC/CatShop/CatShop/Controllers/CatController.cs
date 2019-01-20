namespace CatShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CatShop.Models;
    using System.Linq;
    using System.Collections.Generic;

    public class CatController : Controller
    {
        private readonly CatDbContext context;

        public CatController(CatDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (CatDbContext db = new CatDbContext())
            {
                List<Cat> cats = db.Cats.ToList();
                return View(cats);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(Cat cat)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            using (CatDbContext db = new CatDbContext())
            {
                db.Cats.Add(cat);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            using (CatDbContext db = new CatDbContext())
            {
                Cat oldCat = db.Cats.FirstOrDefault(x => x.Id == id);
                if (oldCat == null)
                {
                    return RedirectToAction("Index");
                }

                return View(oldCat);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(Cat cat)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (CatDbContext db = new CatDbContext())
            {
                Cat oldCat = db.Cats.FirstOrDefault(x => x.Id == cat.Id);
                if (oldCat == null)
                {
                    return RedirectToAction("Index");
                }

                oldCat.Name = cat.Name;
                oldCat.Nickname = cat.Nickname;
                oldCat.Price = cat.Price;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            using (CatDbContext db = new CatDbContext())
            {
                Cat oldCat = db.Cats.FirstOrDefault(x => x.Id == id);
                if (oldCat == null)
                {
                    return RedirectToAction("Index");
                }

                return View(oldCat);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(Cat cat)
        {
            using (CatDbContext db = new CatDbContext())
            {
                if (cat == null)
                {
                    return RedirectToAction("Index");
                }

                db.Cats.Remove(cat);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}
