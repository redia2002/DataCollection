﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DataCollection.Controllers
{
    public class DataCollectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}