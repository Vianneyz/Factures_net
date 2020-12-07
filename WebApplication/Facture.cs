using System;
using System.Diagnostics.Contracts;

namespace WebApplication
{
    public class Facture
    {
         private int numero;
         private string nomClient;
         private DateTime dateEmission;
         private DateTime dateEcheance;
         private double montantDu;
         private double montantRegle;

        public Facture(int numero, string nomClient, DateTime dateEmission, DateTime dateEcheance, double montantDu, double montantRegle)
        {
            this.numero = numero;
            this.nomClient = nomClient;
            this.dateEmission = dateEmission;
            this.dateEcheance = dateEcheance;
            this.montantDu = montantDu;
            this.montantRegle = montantRegle;
        }

        public int Numero
        {
            get => numero;
            set => numero = value;
        }

        public string NomClient
        {
            get => nomClient;
            set => nomClient = value;
        }

        public DateTime DateEmission
        {
            get => dateEmission;
            set => dateEmission = value;
        }

        public DateTime DateEcheance
        {
            get => dateEcheance;
            set => dateEcheance = value;
        }

        public double MontantDu
        {
            get => montantDu;
            set => montantDu = value;
        }

        public double MontantRegle
        {
            get => montantRegle;
            set => montantRegle = value;
        }
    }
}