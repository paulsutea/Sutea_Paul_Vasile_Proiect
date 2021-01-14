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
    public class IndexModel : PageModel
    {
        private readonly Sutea_Paul_Vasile_Proiect.Data.Sutea_Paul_Vasile_ProiectContext _context;

        public IndexModel(Sutea_Paul_Vasile_Proiect.Data.Sutea_Paul_Vasile_ProiectContext context)
        {
            _context = context;
        }

        public IList<Joc> Joc { get;set; }

        public async Task OnGetAsync()
        {
            Joc = await _context.Joc.ToListAsync();
        }
    }
}
