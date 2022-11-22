using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestKASRACompany.Models;

namespace TestKASRACompany.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult test1()
        {
            return View();
        }

        public IActionResult test2()
        {
            return View();
        }
        public IActionResult test3()
        {
            return View();
        }

        public IActionResult test4()
        {
            return View();
        }
    }
}