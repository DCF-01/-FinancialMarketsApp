using FinancialMarketsApp.MVC.Models;
using FinancialMarketsApp.MVC.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace FinancialMarketsApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<MVCOptions> _options;

        public HomeController(ILogger<HomeController> logger, IOptions<MVCOptions> options)
        {
            _logger = logger;
            _options = options;
        }

        public IActionResult Index()
        {
            return Ok(new { options = _options.Value.APIKey});
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
    }
}