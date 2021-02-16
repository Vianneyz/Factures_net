using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class DummyBusinessData : IBusinessData
    {
        public DummyBusinessData()
        {
            Factures = new List<Facture>()
            {
                new Facture { Numero="BSO349", Client="Foo", Montant=1254.10m, DateReglement=new DateTime(year: 2021, month: 2, day: 19) },
                new Facture { Numero="BSO350", Client="Bar", Montant=1254.10m, DateReglement=new DateTime(year: 2021, month: 1, day: 15) }
            };
        }
        public IEnumerable<Facture> Factures { get; }

        public decimal CA => Factures.Sum(f => f.Montant);

        public IEnumerable<Facture> GetFactures(DateTime? debut, DateTime? fin) =>
            Factures.Where(f => 
                (!debut.HasValue || f.DateReglement >= debut) && 
                (!fin.HasValue || f.DateReglement <=fin)
            );

        public void Add(Facture facture)
        {
            (Factures as List<Facture>).Add(facture);
        }
    }
}
