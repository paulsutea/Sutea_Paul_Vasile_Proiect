using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sutea_Paul_Vasile_Proiect.Data;
using Sutea_Paul_Vasile_Proiect.Models;

namespace Sutea_Paul_Vasile_Proiect.Pages.Jocuri
{
    public class CreateModel : PageModel
    {
        private readonly Sutea_Paul_Vasile_Proiect.Data.Sutea_Paul_Vasile_ProiectContext _context;

        public CreateModel(Sutea_Paul_Vasile_Proiect.Data.Sutea_Paul_Vasile_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Joc Joc { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Joc.Add(Joc);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
