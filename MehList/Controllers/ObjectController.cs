using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MehList.Controllers
{
    public class ObjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
