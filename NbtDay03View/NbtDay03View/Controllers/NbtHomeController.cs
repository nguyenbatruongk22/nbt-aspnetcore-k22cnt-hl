using Microsoft.AspNetCore.Mvc;
using NbtDay03View.Models;
using System.Diagnostics;

namespace NbtDay03View.Controllers
{
    public class NbtHomeController : Controller
    {
        private readonly ILogger<NbtHomeController> _logger;

        public NbtHomeController(ILogger<NbtHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NbtIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult NbtAbout()
        {
            return View();
        }

        public IActionResult NbtViewIf()
        {
            return View();
        }
        public IActionResult NbtViewLoop()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
