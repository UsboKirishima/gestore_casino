using ClassLibraryCasino;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCasino
{
    public partial class FormGestioneTurni: Form
    {
        private BindingList<Turno> turni;

        public FormGestioneTurni()
        {
            InitializeComponent();
            CaricaDati();
        }

        private void CaricaDati()
        {
            
            turni = Turno.GetData();
            dgvTurni.DataSource = turni;
            dgvTurni.AutoGenerateColumns = true; 
        }

        // Aggiungi un nuovo turno
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            DateTime inizio = dtpInizio.Value;
            DateTime fine = dtpFine.Value;

            if (inizio < fine)
            {
                new Turno(inizio, fine); 
                dgvTurni.Refresh();
            }
            else
            {
                MessageBox.Show("La data di fine deve essere successiva all'inizio!");
            }
        }

        // Elimina il turno selezionato
        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dgvTurni.CurrentRow != null)
            {
                Turno turnoSelezionato = (Turno)dgvTurni.CurrentRow.DataBoundItem;
                turni.Remove(turnoSelezionato);
            }
        }

        // Modifica il turno selezionato
        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvTurni.CurrentRow != null)
            {
                Turno turnoSelezionato = (Turno)dgvTurni.CurrentRow.DataBoundItem;
                turnoSelezionato.DataInizio = dtpInizio.Value;
                turnoSelezionato.DataFine = dtpFine.Value;
                dgvTurni.Refresh();
            }
        }
    }
}
