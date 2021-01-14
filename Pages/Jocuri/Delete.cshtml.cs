using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sutea_Paul_Vasile_Proiect.Data;
using Sutea_Paul_Vasile_Proiect.Models;

namespace Sutea_Paul_Vasile_Proiect.Pages.Jocuri
{
    public class DeleteModel : PageModel
    {
        private readonly Sutea_Paul_Vasile_Proiect.Data.Sutea_Paul_Vasile_ProiectContext _context;

        public DeleteModel(Sutea_Paul_Vasile_Proiect.Data.Sutea_Paul_Vasile_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Joc Joc { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Joc = await _context.Joc.FirstOrDefaultAsync(m => m.ID == id);

            if (Joc == null)
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

            Joc = await _context.Joc.FindAsync(id);

            if (Joc != null)
            {
                _context.Joc.Remove(Joc);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
