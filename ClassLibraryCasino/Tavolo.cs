using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCasino
{
    public class Tavolo
    {
        private String gioco;
        private int nGiocatori;
        private bool croupier;
        private double puntataMin;
        private double puntataMax;

        public Tavolo(String gioco, int nGiocatori, bool croupier, double puntataMin, double puntataMax)
        {
            this.Gioco = gioco;
            this.NGiocatori = nGiocatori;
            this.Croupier = croupier;
            this.PuntataMin = puntataMin;
            this.PuntataMax = puntataMax;
        }

        public String Gioco { get => gioco; set => gioco = value; }
        public int NGiocatori { get => nGiocatori; set => nGiocatori = value; }
        public bool Croupier { get => croupier; set => croupier = value; }
        public double PuntataMin { get => puntataMin; set => puntataMin = value; }
        public double PuntataMax { get => puntataMax; set => puntataMax = value; }

        // Getters and Setters

        public BindingList<Tavolo> GetSampleData()
        {
            return new BindingList<Tavolo>
            {
                new Tavolo("Roulette", 8, true, 5, 1000),
                new Tavolo("Blackjack", 7, true, 10, 500),
                new Tavolo("Poker", 6, false, 20, 2000),
                new Tavolo("Baccarat", 9, true, 50, 5000)
            };
        }
    }
}
