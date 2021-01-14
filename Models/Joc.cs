using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sutea_Paul_Vasile_Proiect.Models
{
    public class Joc

    {
        public int ID { get; set; }
        [Display(Name = "Titlu Joc")]

        public string Titlu_joc { get; set; }
        public string Publisher{ get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret{ get; set; }
        [Display(Name = "Data Publicarii")]
        public DateTime DataPublicarii { get; set; }
    }
}
