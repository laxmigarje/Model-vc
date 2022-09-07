using Microsoft.AspNetCore.Mvc;
using System;
using Model_vc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_vc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudList()
        {
            List< Student > s = new List<Student>()
            {
                new Student{Roll_No =1,Name="Abhijit",Percentage=80},
                new Student{ Roll_No=2, Name="Manisha",Percentage=92},
                new Student{Roll_No=3,Name="Ashwini",Percentage=84},
                new Student{Roll_No=4,Name="Seema",Percentage=78},
                new Student{Roll_No=5,Name="Laxmi",Percentage=74},
            };
            ViewData["Studentlist"] = s;

            ViewBag.Student = s;
            return View();
        }
    }
}

