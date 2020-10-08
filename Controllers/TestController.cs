using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProjekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspProjekt.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestRepository repository;

        public TestController(ITestRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var othermodel = new TestIndexModel()
            {
                TodaysDate = DateTime.Now.ToString("dd/MM/yyyy")

            };
            return View(othermodel);
        }

        public IActionResult RedirectToGoogle()
        {
            return Redirect("http://www.google.com");
        }

        public IActionResult GetJson()
        {
            return Json(new {Name = "Jan", Surname = "Kowalski" });
        }
       
        public IActionResult TestModel()
        {
            return View(repository.GetItems());
        }
        
    }
}
