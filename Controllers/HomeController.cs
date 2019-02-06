using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProCoding.Demos.ASPNetCore.DependencyInjection.Models;
using ProCoding.Demos.ASPNetCore.DependencyInjection.Services;

namespace ProCoding.Demos.ASPNetCore.DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _service;
        private readonly SecondService _secondService;
        public HomeController(IService service, SecondService secondService)
        {
            _service = service;
            _secondService = secondService;
        }

        public IActionResult Index([FromServices] IService actionService )
        {
            return Content($"<html><body>" + 
                           $"<p>First Service ID: {_service.GetGuid()}</p>" + 
                           $"<p>Second Service ID: {_secondService.GetGuid()}</p>" +
                           $"<p>Action Service ID: {actionService.GetGuid()}</p>" +
                           "</body></html>", 
                           "text/html");
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
