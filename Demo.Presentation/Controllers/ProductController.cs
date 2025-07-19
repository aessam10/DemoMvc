using Microsoft.AspNetCore.Mvc;

namespace Demo.Presentation.Controllers
{
    public class ProductController : Controller
    {
        public string Get(int id, string name)
        {
            return $"{name} :: {id}";
        }
        public string Create(int[] numbers) => numbers.Length.ToString();
        public IActionResult Index()
        {
            return View();
        }
    }
}
