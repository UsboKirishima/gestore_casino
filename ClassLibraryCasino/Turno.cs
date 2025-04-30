using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCasino
{
    public class Turno
    {
        private static BindingList<Turno> turni;
        private DateTime dataInizio;
        private DateTime dataFine;

        public Turno(DateTime dataInizio, DateTime dataFine)
        {
            this.DataInizio = dataInizio;
            this.DataFine = dataFine;
            AddTurno(this);
        }

        public DateTime DataInizio { get => dataInizio; set => dataInizio = value; }
        public DateTime DataFine { get => dataFine; set => dataFine = value; }

        // Getters and Setters

        public BindingList<Turno> GetSampleData()
        {
            return new BindingList<Turno>
            {
                new Turno(DateTime.Now.AddHours(-2), DateTime.Now),
                new Turno(DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-2)),
                new Turno(DateTime.Now.AddHours(-6), DateTime.Now.AddHours(-4)),
                new Turno(DateTime.Now.AddHours(-8), DateTime.Now.AddHours(-6))
            };
        }

        private static void AddTurno(Turno turno)
        {
            if (turni == null)
                turni = new BindingList<Turno>();

            turni.Add(turno);
        }

        public static BindingList<Turno> GetData()
        {
            if (turni == null)
                turni = new BindingList<Turno>();

            return turni;
        }

    }
}
