using Agency.BUSINESS.Services.Interfaces;
using Agency.BUSINESS.ViewModels;
using Agency.CORE.Entities;
using Agency.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.BUSINESS.Services.Implementations
{
    public class PortfolioService : IPortfolioService
    {
        private readonly IPortfolioRepository _repo;
        public PortfolioService(IPortfolioRepository repo)
        {
            _repo = repo;
        }
        public async Task Create(CreatePortfolioVM createPortfolioVM)
        {
            Portfolio portfolio = new Portfolio();
            await _repo.Create(portfolio);
            _repo.SaveChanges();
        }

        public async Task Delete(int id)
        {
            _repo.Delete(id);
        }

        public async Task<IQueryable<Portfolio>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async  Task<Portfolio> GetById(int id)
        {
            if (id < 0) throw new Exception("Invalid Id");
            return await _repo.GetById(id);
        }

        public async Task Update(UpdatePortfolioVM updatePortfolioVM)
        {
            if(updatePortfolioVM != null && _repo.Check(updatePortfolioVM.Id))
            {
                var existingPortfolio = await _repo.GetById(updatePortfolioVM.Id);
                existingPortfolio.ImageUrl = updatePortfolioVM.ImageUrl;
                existingPortfolio.Title = updatePortfolioVM.Title;
                existingPortfolio.SubTitle = updatePortfolioVM.Subtitle;
                _repo.Update(existingPortfolio);
                _repo.SaveChanges();
            }
        }
    }
}
