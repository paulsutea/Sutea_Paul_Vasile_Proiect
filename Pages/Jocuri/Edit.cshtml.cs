using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sutea_Paul_Vasile_Proiect.Data;
using Sutea_Paul_Vasile_Proiect.Models;

namespace Sutea_Paul_Vasile_Proiect.Pages.Jocuri
{
    public class EditModel : PageModel
    {
        private readonly Sutea_Paul_Vasile_Proiect.Data.Sutea_Paul_Vasile_ProiectContext _context;

        public EditModel(Sutea_Paul_Vasile_Proiect.Data.Sutea_Paul_Vasile_ProiectContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Joc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JocExists(Joc.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool JocExists(int id)
        {
            return _context.Joc.Any(e => e.ID == id);
        }
    }
}
