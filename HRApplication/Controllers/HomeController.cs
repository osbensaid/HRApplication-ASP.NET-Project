using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HRApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HRApplication.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Employees()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Employees(Employee emp)
        {
            if (ModelState.IsValid) {  
                Repository.AddEmployee(emp);
                return View("ConfirmPage", emp);
            }
            else
            {
                return View();
            }
        }

        public ViewResult AllEmployees() {
            return View(Repository.GetEmployees().Where(emp=> emp.isActive == true));
        }
    }
}
