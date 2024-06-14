using J_query_Ajax.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace J_query_Ajax.Controllers
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
        [HttpPost]
        public int sum(int num1, int num2)
        {
            return num1+num2;
        }
        [HttpPost]
        public int sub(int num1, int num2)
        {
            return num1- num2;
        }
        [HttpPost]
        public int mull(int num1, int num2)
        {
            return (num1*num2);
        }
        [HttpPost]
        public decimal div(int num1, int num2)
        {
            return (decimal)num1/num2;
        }
        [HttpPost]
        public Mathmatic calculation(int num1, int num2)
        {
           Mathmatic math = new Mathmatic();
           math.Add=num1 + num2;
           math.Sub=num1 - num2;
           math.Div=(decimal)num1/num2;
           math.Mul=num1*num2;


            return math;
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
