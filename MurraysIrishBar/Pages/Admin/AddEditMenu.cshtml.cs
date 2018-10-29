using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MurraysIrishBar.Domain;
using MurraysIrishBar.Repository;

namespace MurraysIrishBar.Pages.Admin
{
    public class AddEditMenuModel : PageModel
    {
        private readonly IMenuRepository repository;

        [FromRoute]
        public long? Id { get; set; }

        public bool IsNewMenu
        {
            get { return Id == null; }
        }

        [BindProperty]
        public Menu Menu { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        public AddEditMenuModel(IMenuRepository repository)
        {
            this.repository = repository;
        }

        public async Task OnGetAsync()
        {
            Menu = await repository.FindAsync(Id.GetValueOrDefault()) 
                ?? new Menu();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid) {
                return Page();
            }

            var menu = await repository.FindAsync(Id.GetValueOrDefault()) 
                ?? new Menu();

            menu.Name = Menu.Name;
            menu.Description = Menu.Description;
            menu.Ingredients = Menu.Ingredients;
            menu.Price = Menu.Price;

            if(Image != null) {
                using(var stream = new System.IO.MemoryStream())
                {
                    await Image.CopyToAsync(stream);

                    menu.Image = stream.ToArray();
                    menu.ImageContentType = Image.ContentType;
                }
            }

            await repository.SaveAsync(menu);
            return RedirectToPage("/Menu", new { id = menu.Id });
        }

        public async Task<IActionResult> OnPostDelete()
        {
            await repository.DeleteAsync(Id.Value);
            return RedirectToPage("/Index");
        }
    }
}