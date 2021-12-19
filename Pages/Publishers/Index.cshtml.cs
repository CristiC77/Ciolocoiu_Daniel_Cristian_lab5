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
    public class IndexModel : PageModel
    {
        private readonly Ciolocoiu_Daniel_Cristian_lab5.Data.Ciolocoiu_Daniel_Cristian_lab5Context _context;

        public IndexModel(Ciolocoiu_Daniel_Cristian_lab5.Data.Ciolocoiu_Daniel_Cristian_lab5Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
