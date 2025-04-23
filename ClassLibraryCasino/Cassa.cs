using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCasino
{
    public class Cassa
    {
        private double fiches;
        private double contanti;

        public Cassa(double fiches, double contanti)
        {
            this.Fiches = fiches;
            this.Contanti = contanti;
        }

        public double Fiches { get => fiches; set => fiches = value; }
        public double Contanti { get => contanti; set => contanti = value; }

        public double cambioFiches(double amount)
        {
            if (amount > this.Contanti)
            {
                return 0;
            }
            this.Contanti -= amount;
            this.Fiches += amount;
            return amount;
        }

        public void versamentoIncassoFiches(double amount)
        {
            this.Fiches -= amount;
            this.Contanti += amount;
        }

        // Getters and Setters
    }
}
