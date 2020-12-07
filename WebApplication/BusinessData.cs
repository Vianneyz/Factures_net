using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Shared;

namespace WebApplication
{
    public class BusinessData : IBusinessData
    {
        private List<Facture> listeFactures;

        public BusinessData()
        {
            this.listeFactures = new List<Facture>();
            this.Populate();
        }

        public void Populate()
        {
            Facture f1 = new Facture(001, "Dupont", new DateTime(2020, 11, 01), new DateTime(2020, 12, 01), 650, 650);
            Facture f2 = new Facture(002, "Martin", new DateTime(2020, 11, 12), new DateTime(2020, 12, 03), 1520, 1520);
            Facture f3 = new Facture(003, "Garrigue", new DateTime(2020, 11, 16), new DateTime(2020, 12, 06), 987, 987);
            Facture f4 = new Facture(004, "Soulier", new DateTime(2020, 11, 25), new DateTime(2020, 12, 22), 2300, 2000);
            
            this.listeFactures.Add(f1);
            this.listeFactures.Add(f2);
            this.listeFactures.Add(f3);
            this.listeFactures.Add(f4);
        }

        public IEnumerable<Facture> Factures => listeFactures;

    }
}