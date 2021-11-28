using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSiteMVC.UI.Controllers
{
    public class ExploreCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
