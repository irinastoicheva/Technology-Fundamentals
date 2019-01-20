using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            using (BandDbContext db = new BandDbContext())
            {
                List<Band> bands = db.Bands.ToList();
                return View(bands);
            }

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Band band)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            using (BandDbContext db = new BandDbContext())
            {
                db.Bands.Add(band);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (BandDbContext db = new BandDbContext())
            {
                Band oldBand = db.Bands.FirstOrDefault(x => x.Id == id);
                if (oldBand == null)
                {
                    return RedirectToAction("Index");
                }

                return View(oldBand);
            }

        }

        [HttpPost]
        public IActionResult Edit(Band newBand)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (BandDbContext db = new BandDbContext())
            {
                Band oldBand = db.Bands.FirstOrDefault(x => x.Id == newBand.Id);
                if (oldBand == null)
                {
                    return RedirectToAction("Index");
                }

                oldBand.Name = newBand.Name;
                oldBand.Members = newBand.Members;
                oldBand.Honorarium = newBand.Honorarium;
                oldBand.Genre = newBand.Genre;

                db.SaveChanges();

                return RedirectToAction("Index");
            }

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (BandDbContext db = new BandDbContext())
            {
                Band oldBand = db.Bands.FirstOrDefault(x => x.Id == id);
                if (oldBand == null)
                {
                    return RedirectToAction("Index");
                }

                return View(oldBand);
            }

        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {
            using (BandDbContext db = new BandDbContext())
            {
                if (band == null)
                {
                    return RedirectToAction("Index");
                }

                db.Bands.Remove(band);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

        }
    }
}