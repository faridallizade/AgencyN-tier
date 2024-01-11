using Agency.DAL.Repositories.Interfaces;
using Agency.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Agency.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPortfolioRepository _repo;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,IPortfolioRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var portfolio = await _repo.GetAllAsync();
            return View(portfolio);
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