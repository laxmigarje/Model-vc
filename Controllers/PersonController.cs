using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_vc.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Personaldetails()
        {
            List<string> options = new List<string>() { "Select option", "Yes", "No" };
            ViewData["options"] = new SelectList(options);
            return View();
        }

        [HttpPost]
        public IActionResult Personaldetail(IFormCollection form,ICollection<string>hobbies)
        {
            ViewBag.Name = form["fname"];
            ViewBag.Contact = form["contact"];
            ViewBag.Gender = form["gender"];
            ViewBag.Hobbies = form["hobbies"];
            ViewBag.Option = form["options"];
            return View("Details");
        }


    }
}
