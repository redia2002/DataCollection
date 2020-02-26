using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DataCollection.Controllers
{
    public class DsRegController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RunTask()
        {
            return View();
        }

        public IActionResult LockUnlock()
        {
            return View();
        }
        public IActionResult RunTaskDetail()
        {
            return View();
        }

        public IActionResult LockUnlockDetail()
        {
            return View();
        }
    }
}