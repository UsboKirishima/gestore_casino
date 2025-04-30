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
    public partial class FormGestioneTransazioni: Form
    {
        private BindingList<TransazioneDenaro> transazioni;

        public FormGestioneTransazioni()
        {
            InitializeComponent();
            InizializzaForm();
        }

        private void InizializzaForm()
        {
            
            transazioni = Gestore.GetTransazioni();
            dgvTransazioni.DataSource = transazioni;
            dgvTransazioni.AutoGenerateColumns = true;

           
            dgvTransazioni.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvTransazioni.Columns["Fiches"].HeaderText = "Fiches Scambiate";
            dgvTransazioni.Columns["Contanti"].HeaderText = "Denaro Scambiato";
        }

        
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                double fiches = Convert.ToDouble(txtFiches.Text);
                double contanti = Convert.ToDouble(txtContanti.Text);

                new TransazioneDenaro(fiches, contanti);
                AggiornaCassa(fiches, contanti);
                AggiornaInterfaccia();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore: {ex.Message}");
            }
        }

        private void AggiornaCassa(double fiches, double contanti)
        {
            Cassa cassa = Cassa.GetData();
            cassa.Fiches -= fiches;
            cassa.Contanti += contanti;
        }

        private void AggiornaInterfaccia()
        {
            transazioni.ResetBindings();
            txtFiches.Clear();
            txtContanti.Clear();
        }

        
        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dgvTransazioni.CurrentRow != null)
            {
                TransazioneDenaro td = (TransazioneDenaro)dgvTransazioni.CurrentRow.DataBoundItem;
                transazioni.Remove(td);
                RipristinaCassa(td);
            }
        }

        private void RipristinaCassa(TransazioneDenaro td)
        {
            Cassa cassa = Cassa.GetData();
            cassa.Fiches += td.Fiches;
            cassa.Contanti -= td.Contanti;
        }
    }
}
