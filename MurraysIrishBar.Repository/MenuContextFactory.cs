using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace MurraysIrishBar.Repository
{
    public class MenuContextFactory : IDesignTimeDbContextFactory<MenuDbContext>
    {
        public MenuDbContext CreateDbContext(string[] args)
        {
            //var options = new DbContextOptionsBuilder<MenuDbContext>()
            //    .UseInMemoryDatabase("MurraysIrishBar")
            //    .Options;

            //var options = new DbContextOptionsBuilder<MenuDbContext>()
            //  .UseSqlite("Data Source=Database.db")
            //  .Options;

            // https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/new-db?tabs=visual-studio

            var options = new DbContextOptionsBuilder<MenuDbContext>()
               .UseSqlServer("Server =.\\SQLEXPRESS; Database = MurraysIrishBar6; Trusted_Connection = True; MultipleActiveResultSets = true")
               .Options;

            return new MenuDbContext(options);
        }
    }
}
