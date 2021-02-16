using Facturation.Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace Facturation.Server.Models
{
    public class BusinessDataSql : IBusinessData, IDisposable
    {
        private SqlConnection cnct;

        public BusinessDataSql(string connectionString)
        {
            cnct = new SqlConnection(connectionString);
        }
        public void Dispose()
        {
            cnct.Dispose();
        }

        public IEnumerable<Facture> Factures
            => cnct.Query<Facture>("SELECT * FROM Factures ORDER BY DateReglement DESC");

        public decimal CA => throw new NotImplementedException();

        public void Add(Facture facture)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Facture> GetFactures(DateTime? debut, DateTime? fin)
        {
            throw new NotImplementedException();
        }
    }
}

