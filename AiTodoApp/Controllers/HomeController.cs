using AiTodo.application.Extensions;
using AiTodoApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AiTodoApp.Controllers
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
        public IActionResult Create()
        {
            return View();
        }
        public async Task<ActionResult> Create(TodoDto todo)
        {
            if(!ModelState.IsValid)
            {
                return View(todo);
            }
            await _logger.Create(todo);
            await RedirectToAction("/");
        }
    }
}
