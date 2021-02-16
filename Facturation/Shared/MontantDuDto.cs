using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class MontantDuDto
    {
        public MontantDuDto()
        {

        }
        public MontantDuDto(Facture from)
        {
            Date = from.DateReglement;
            Montant = from.Montant;
        }
        public DateTime Date { get; set; }
        public decimal Montant { get; set; }
    }
}
