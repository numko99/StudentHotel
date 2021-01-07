using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBdata.EF;
using Microsoft.AspNetCore.Mvc;

namespace StudentHotel.Controllers
{
    public class Referent : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PrikazPrijava()
        {
            MojDbContext dBcONTEXT = new MojDbContext();
            return View();
        }
    }
}
