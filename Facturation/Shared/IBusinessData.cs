using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public interface IBusinessData
    {
        IEnumerable<Facture> Factures { get; }

        decimal CA { get; }

        void Add(Facture facture);

        IEnumerable<Facture> GetFactures(DateTime? debut, DateTime? fin);
    }
}
