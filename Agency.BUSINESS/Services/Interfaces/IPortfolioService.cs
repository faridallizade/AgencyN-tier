using Agency.BUSINESS.ViewModels;
using Agency.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.BUSINESS.Services.Interfaces
{
    public interface IPortfolioService
    {
        Task<IQueryable<Portfolio>> GetAllAsync();
        Task<Portfolio> GetById(int id);
        Task Create(CreatePortfolioVM createPortfolioVM);
        Task Update(UpdatePortfolioVM updatePortfolioVM);
        Task Delete(int id);
    }
}
