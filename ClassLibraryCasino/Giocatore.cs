using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCasino
{
    public class Giocatore
    {
        private int codice;
        private String nome;
        private String cognome;
        private double fiches;
        private double contanti;

        public int Codice { get => codice; set => codice = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public double Fiches { get => fiches; set => fiches = value; }
        public double Contanti { get => contanti; set => contanti = value; }

        public Giocatore(int codice, String nome, String cognome, double fiches, double contanti)
        {
            this.Codice = codice;
            this.Nome = nome;
            this.Cognome = cognome;
            this.Fiches = fiches;
            this.Contanti = contanti;
        }

        public void cambiaFiches(double amount)
        {
            this.Fiches += amount;
        }

        public void cambiaContanti(double amount)
        {
            this.Contanti += amount;
        }

        public BindingList<Giocatore> GetSampleData()
        {
            return new BindingList<Giocatore>
            {
                new Giocatore(1, "Franco", "Franchi", 1200, 5000),
                new Giocatore(2, "Giovanni", "Gioia", 1500, 3000),
                new Giocatore(3, "Marco", "Marconi", 800, 2000),
                new Giocatore(4, "Luca", "Luciani", 2000, 7000)
            };
        }
    }
}
