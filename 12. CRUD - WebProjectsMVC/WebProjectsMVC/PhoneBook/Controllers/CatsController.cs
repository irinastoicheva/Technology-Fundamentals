using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PhoneBook.Controllers
{
    public class CatsController: Controller
    {
        public string Index()
        {
            return "Some cats";
        }

        public IActionResult Details()
        {
            ViewData["Cats"] = "Ivan";
            return View();
        }
    }
}
