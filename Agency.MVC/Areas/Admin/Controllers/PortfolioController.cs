using Agency.BUSINESS.Services.Interfaces;
using Agency.BUSINESS.ViewModels;
using Agency.CORE.Entities;
using AutoMapper.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore;
using NuGet.Frameworks;
using System.Security.Policy;

namespace Agency.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;
        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }
        public async Task<IActionResult> Index()
        {
            IQueryable<Portfolio> portfolio = await _portfolioService.GetAllAsync();
            return View(portfolio);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreatePortfolioVM CreatePortfolioVM)
        {
            if (!ModelState.IsValid)
            {
                return View(CreatePortfolioVM);
            }
            await _portfolioService.Create(CreatePortfolioVM);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int id)
        {
            Portfolio portfolio = await _portfolioService.GetById(id);
            return View(portfolio);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdatePortfolioVM portVM)
        {
            if (!ModelState.IsValid)
            {
                return View(portVM);
            }

            await _portfolioService.Update(portVM);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _portfolioService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
