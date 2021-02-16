using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class Facture
    {
        [Required]
        [StringLength(15, MinimumLength =10)]
        public string Numero { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Client { get; set; }
        [Required]
        public DateTime DateReglement { get; set; }
        [Required]
        [Range(0.1, double.MaxValue)]
        public decimal Montant { get; set; }
    }
}
