using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCasino
{
    public class Dipendente
    {
        private String nome;
        private String cognome;
        private int stipendio;

        public Dipendente(String nome, String cognome, int stipendio)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Stipendio = stipendio;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public int Stipendio { get => stipendio; set => stipendio = value; }

        public BindingList<Dipendente> GetSampleData()
        {
            return new BindingList<Dipendente>
            {
                new Dipendente("Mario", "Rossi", 3000),
                new Dipendente("Luigi", "Verdi", 3500),
                new Dipendente("Anna", "Bianchi", 3200),
                new Dipendente("Giovanni", "Neri", 2800),
                new Dipendente("Maria", "Gialli", 3100)
            };
        }
    }
}
