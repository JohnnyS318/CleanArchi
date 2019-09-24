using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CleanArchi.Application.Employee.Commands.CreateEmployee;
using Microsoft.AspNetCore.Mvc;
using CleanArchi.WebUI.Models;

namespace CleanArchi.WebUI.Controllers
{
    public class HomeController : BaseController
    {
        public async Task<IActionResult> Index()
        {

            var command = new CreateEmployeeCommand()
            {
                Name = "Hans",
            };

            await Mediator.Send(command);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
