using la_mia_pizzeria_model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_model.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Pizza> pizzaList = new List<Pizza>();
            pizzaList.Add(new Pizza() { Name = "Margherita", Description = "Pomodoro, mozzarella, basilico", Image = "/img/pizza.jpg", Price = 4.5 });
            pizzaList.Add(new Pizza() { Name = "Divola", Description = "Pomodoro, salame, mozzarella", Image = "/img/pizza.jpg", Price = 5 });
            pizzaList.Add(new Pizza() { Name = "marinara", Description = "Pomodoro, mozzarella, basilico", Image = "/img/pizza.jpg", Price = 3.5 });
            return View(pizzaList);
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