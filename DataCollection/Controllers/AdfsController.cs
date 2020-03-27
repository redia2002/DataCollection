using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using DataCollection.Models;

namespace DataCollection.Controllers
{
    public class AdfsController : Controller
    {
        public IActionResult Index()
        {
            AdfsModel adfsModel = new AdfsModel();
            adfsModel.initialize();

            return View(adfsModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(AdfsModel adfsModel)
        {
            return View(adfsModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Process( AdfsModel adfsModel)
        {
            return View(adfsModel);
        }

        public IActionResult WapReconfig()
        {
            return View();
        }
        public IActionResult ReadMe()
        {
            return View();
        }
    }
}