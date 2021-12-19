using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ciolocoiu_Daniel_Cristian_lab5.Data;
using Ciolocoiu_Daniel_Cristian_lab5.Models;

namespace Ciolocoiu_Daniel_Cristian_lab5.Pages.Publishers
{
    public class DeleteModel : PageModel
    {
        private readonly Ciolocoiu_Daniel_Cristian_lab5.Data.Ciolocoiu_Daniel_Cristian_lab5Context _context;

        public DeleteModel(Ciolocoiu_Daniel_Cristian_lab5.Data.Ciolocoiu_Daniel_Cristian_lab5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
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

            Publisher = await _context.Publisher.FindAsync(id);

            if (Publisher != null)
            {
                _context.Publisher.Remove(Publisher);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
