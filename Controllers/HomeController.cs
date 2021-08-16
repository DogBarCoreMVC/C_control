using C_control.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace C_control.Controllers
{
    public class HomeController : Controller//Inherit from Class Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var FullName = (FirstName:"Porawit", LastName:"Pumlamjeak");
            ViewData["myname"] = FullName.FirstName + " " + FullName.LastName;
            //ส่งตัวแปร 2 ตัว FullName.FirstName และ FullName.LastName ไปเก็บไวที่ใน class ViewData ตั้งชื่อข้อมูลชุดนี้ว่า "myname"

            return View();
        }

        public IActionResult Culculeter()
        {
            var result = 0;

            int x = 200;
            int y = 300;

            AddData(x, y);

            void AddData(int num1, int num2)
            {
                result = num1 + num2;
            }

            ViewData["result"] = result;

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
