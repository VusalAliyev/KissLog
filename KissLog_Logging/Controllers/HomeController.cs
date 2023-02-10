using KissLog;
using KissLog_Logging.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KissLog_Logging.Controllers
{

    //https://kisslog.net/Endpoints/7205e6f5-0551-43a6-a37c-80b98ddfa44e/kisslog-aspnetcore-2x
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var logger = Logger.Factory.Get();

            logger.Critical("Fatal error");


            return View();
        }

      
    }
}