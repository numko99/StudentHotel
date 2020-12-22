using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudentHotel.Controllers
{
    public class Konkurs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KonkursForma()
        {
            return View();
        }
    }
}
