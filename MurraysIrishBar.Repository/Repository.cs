using Microsoft.EntityFrameworkCore;
using MurraysIrishBar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurraysIrishBar.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly MenuDbContext _context;

        public MenuRepository()
        {
            var factory = new MenuContextFactory();
            _context = factory.CreateDbContext(null);
        }

        public MenuRepository(MenuDbContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(long id)
        {
            _context.Menus.Remove(new Menu { Id = id });
            await _context.SaveChangesAsync();
        }

        public Menu Find(long id)
        {
            return _context.Menus.FirstOrDefault(x => x.Id == id);
        }

        public Task<Menu> FindAsync(long id)
        {
            return _context.Menus.FirstOrDefaultAsync(x => x.Id == id);
        }

        public IQueryable<Menu> GetAll(int? count = null, int? page = null)
        {
            var actualCount = count.GetValueOrDefault(10);

            return _context.Menus
                    .Skip(actualCount * page.GetValueOrDefault(0))
                    .Take(actualCount);
        }

        public Task<Menu[]> GetAllAsync(int? count = null, int? page = null)
        {
            return GetAll(count, page).ToArrayAsync();
        }

        public async Task SaveAsync(Menu menu)
        {
            var isNew = menu.Id == default(long);

            _context.Entry(menu).State = isNew ? EntityState.Added : EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
