using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using princeshop.Models;

namespace princeshop.Controllers
{

    public class IconoController : Controller
    {
        private readonly ILogger<IconoController> _logger;

        public IconoController(ILogger<IconoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Icono()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}