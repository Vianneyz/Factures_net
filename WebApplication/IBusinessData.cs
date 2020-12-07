using System.Collections;
using System.Collections.Generic;

namespace WebApplication
{
    public interface IBusinessData
    {
        IEnumerable<Facture> Factures { get; }
    }
}