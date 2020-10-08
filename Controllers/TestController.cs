using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspProjekt.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string StringValue()
        {
            return "Hello World";
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
            var model = new List<TestModel>() {
                new TestModel {},
                new TestModel {},
                new TestModel {}
            }
            return View(model);
        }

    }
}
