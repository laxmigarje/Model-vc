using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Model_vc.Models;
using System.Threading.Tasks;

namespace Model_vc.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult List()
        {
            List<Emp> Employee = new List<Emp>()
            {
                new Emp{Id=1,Name="Abhijit",Salary=34000},
                new Emp{Id=2,Name="Manisha",Salary=38000},
                new Emp{Id=3,Name="Ashwini",Salary=39000},
                new Emp{Id=4,Name="Seema",Salary=345000},
                new Emp{Id=5,Name="Laxmi",Salary=40000},
            };
            ViewData["Emplist"] = Employee;

            ViewBag.Emp = Employee;
            return View();
        }
            
        }
    }

