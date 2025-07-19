using Demo.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo.Presentation.Controllers
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
        /*
        return types
        1- string
        2-content ودا في فيتشرز الاتش تي ام ال بحيث اقدر استخدم ستاتس كود او احمل بدي ااف
        3- redirect to route
        4- redirect to action
        IActionResult بيرجع كل التايبس عشان بينفذو الانترفيس
         */
    }
}
