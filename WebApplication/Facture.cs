using System;

namespace WebApplication
{
    public class Facture
    {
        public int numero;
        public string nomClient;
        public DateTime dateEmission;
        public DateTime dateEcheance;
        public double montantDu;
        public double montantRegle;

        public Facture(int numero, string nomClient, DateTime dateEmission, DateTime dateEcheance, double montantDu, double montantRegle)
        {
            this.numero = numero;
            this.nomClient = nomClient;
            this.dateEmission = dateEmission;
            this.dateEcheance = dateEcheance;
            this.montantDu = montantDu;
            this.montantRegle = montantRegle;
        }
    }
}