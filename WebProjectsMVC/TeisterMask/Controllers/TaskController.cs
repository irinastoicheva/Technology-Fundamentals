using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            using (MeisterTaskDbContext db = new MeisterTaskDbContext())
            {
                List<Task> tasks = db.Tasks.ToList();
                return View(tasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string title, string status)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(status))
            {
                return RedirectToAction("Index");
            }

            Task task = new Task
            {
                Title = title,
                Status = status
            };

            using (MeisterTaskDbContext db = new MeisterTaskDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (MeisterTaskDbContext db = new MeisterTaskDbContext())
            {
                Task oldTask = db.Tasks.FirstOrDefault(x => x.Id == id);
                if (oldTask == null)
                {
                    return RedirectToAction("Index");
                }

                return View(oldTask);
            }
        }

        [HttpPost]
        public IActionResult Edit(Task newTask)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (MeisterTaskDbContext db = new MeisterTaskDbContext())
            {
                Task oldTask = db.Tasks.FirstOrDefault(x => x.Id == newTask.Id);
                if (oldTask == null)
                {
                    return RedirectToAction("Index");
                }

                oldTask.Title = newTask.Title;
                oldTask.Status = newTask.Status;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (MeisterTaskDbContext db = new MeisterTaskDbContext())
            {
                Task oldTask = db.Tasks.FirstOrDefault(x => x.Id == id);
                if (oldTask == null)
                {
                    return RedirectToAction("Index");
                }

                return View(oldTask);
            }
        }

        [HttpPost]
        public IActionResult Delete(Task task)
        {
            using (MeisterTaskDbContext db = new MeisterTaskDbContext())
            {
                if (task == null)
                {
                    return RedirectToAction("Index");
                }

                db.Tasks.Remove(task);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }

}
