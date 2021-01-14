using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sutea_Paul_Vasile_Proiect.Models;

namespace Sutea_Paul_Vasile_Proiect.Data
{
    public class Sutea_Paul_Vasile_ProiectContext : DbContext
    {
        public Sutea_Paul_Vasile_ProiectContext (DbContextOptions<Sutea_Paul_Vasile_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Sutea_Paul_Vasile_Proiect.Models.Joc> Joc { get; set; }
    }
}
