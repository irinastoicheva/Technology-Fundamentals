namespace ToDoList.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using ToDoList.Controllers.Data;
    using ToDoList.Models;

    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (ToDoDbContext db = new ToDoDbContext())
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
        public IActionResult Create(string title, string comments)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(comments))
            {
                return RedirectToAction("Index");
            }

            Task task = new Task
            {
                Title = title,
                Comments = comments
            };

            using (ToDoDbContext db = new ToDoDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (ToDoDbContext db = new ToDoDbContext())
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
            using (ToDoDbContext db = new ToDoDbContext())
            {
                Task oldTask = db.Tasks.FirstOrDefault(x => x.Id == newTask.Id);
                if (oldTask == null)
                {
                    return RedirectToAction("Index");
                }

                oldTask.Title = newTask.Title;
                oldTask.Comments = newTask.Comments;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            using (ToDoDbContext db = new ToDoDbContext())
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
        public IActionResult Delete(int id)
        {
            using (ToDoDbContext db = new ToDoDbContext())
            {
                Task task = db.Tasks.FirstOrDefault(x => x.Id == id);
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