using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_control.Controllers
{
    public class ProductController : Controller//สร้าง Class ProductController
    {
        [Route("api/index")]//กำหนดเส้นทางใหม่เป็น /api/index จากเดิม product/index เป็นการปิดบังเส้นทางที่แท้จริงเอาไว้
        public IActionResult Index()
        {
            return View();
        }
    }
}
