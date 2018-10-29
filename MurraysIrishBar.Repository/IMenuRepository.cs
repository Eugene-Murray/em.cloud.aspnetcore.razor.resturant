using MurraysIrishBar.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MurraysIrishBar.Repository
{
    public interface IMenuRepository
    {
        Task DeleteAsync(long id);
        Menu Find(long id);
        Task<Menu> FindAsync(long id);
        IQueryable<Menu> GetAll(int? count = null, int? page = null);
        Task<Menu[]> GetAllAsync(int? count = null, int? page = null);
        Task SaveAsync(Menu Menu);
    }
}
