using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ciolocoiu_Daniel_Cristian_lab5.Data;
using Ciolocoiu_Daniel_Cristian_lab5.Models;

namespace Ciolocoiu_Daniel_Cristian_lab5.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly Ciolocoiu_Daniel_Cristian_lab5.Data.Ciolocoiu_Daniel_Cristian_lab5Context _context;

        public DeleteModel(Ciolocoiu_Daniel_Cristian_lab5.Data.Ciolocoiu_Daniel_Cristian_lab5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FindAsync(id);

            if (Category != null)
            {
                _context.Category.Remove(Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
