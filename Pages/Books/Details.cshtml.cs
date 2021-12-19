using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ciolocoiu_Daniel_Cristian_lab5.Data;
using Ciolocoiu_Daniel_Cristian_lab5.Models;

namespace Ciolocoiu_Daniel_Cristian_lab5.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Ciolocoiu_Daniel_Cristian_lab5.Data.Ciolocoiu_Daniel_Cristian_lab5Context _context;

        public DetailsModel(Ciolocoiu_Daniel_Cristian_lab5.Data.Ciolocoiu_Daniel_Cristian_lab5Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
