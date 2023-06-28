using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(int num1, int num2)
        {
            int sum = num1 + num2;
            ViewBag.Sum = sum;
            return View("Result");
        }
    }
}
