using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontEndFeature.Controllers
{
    public class MyIndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}