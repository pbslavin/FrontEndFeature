using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrontEndFeature.Models;

namespace FrontEndFeature.Controllers
{
    public class MyFormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FormDataModel formDataModel)
        {
            Repository.AddFormDataObject(formDataModel);
            return View("Results", Repository.FormDataObjects);
        }
    }
}