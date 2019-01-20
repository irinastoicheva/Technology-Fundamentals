using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Controllers
{
    public class DogController : Controller
    {
        public IActionResult Dog()
        {
            var model = new Dog
            {
                Name = "Pesho",
                Age = 5
            };

            return View(model);
        }
    }
}
