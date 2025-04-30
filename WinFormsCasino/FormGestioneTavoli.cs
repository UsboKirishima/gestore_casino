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
    public partial class FormGestioneTavoli: Form
    {

        private BindingList<Tavolo> tavoli;
        public FormGestioneTavoli()
        {
            InitializeComponent();
            CaricaDati();
        }

        private void CaricaDati()
        {
            
            tavoli = Tavolo.GetData();
            dgvTavoli.DataSource = tavoli;
            ConfiguraGriglia();
        }

        private void ConfiguraGriglia()
        {
            dgvTavoli.AutoGenerateColumns = false;
            dgvTavoli.Columns.Clear();

            
            dgvTavoli.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Gioco",
                HeaderText = "Tipo Gioco"
            });

            dgvTavoli.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "NGiocatori",
                HeaderText = "Posti"
            });

            dgvTavoli.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                DataPropertyName = "Croupier",
                HeaderText = "Croupier"
            });

            dgvTavoli.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PuntataMin",
                HeaderText = "Min Bet",
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "C2" }
            });

            dgvTavoli.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PuntataMax",
                HeaderText = "Max Bet",
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "C2" }
            });
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                Tavolo nuovoTavolo = new Tavolo(
                    txtGioco.Text,
                    (int)nudPosti.Value,
                    cbxCroupier.Checked,
                    (double)nudMinBet.Value,
                    (double)nudMaxBet.Value
                );

                if (nuovoTavolo.PuntataMin >= nuovoTavolo.PuntataMax)
                    throw new Exception("La puntata massima deve essere maggiore della minima!");

                tavoli.Add(nuovoTavolo);
                PulisciCampi();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore: {ex.Message}", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvTavoli.CurrentRow != null)
            {
                Tavolo selected = (Tavolo)dgvTavoli.CurrentRow.DataBoundItem;
                selected.Gioco = txtGioco.Text;
                selected.NGiocatori = (int)nudPosti.Value;
                selected.Croupier = cbxCroupier.Checked;
                selected.PuntataMin = (double)nudMinBet.Value;
                selected.PuntataMax = (double)nudMaxBet.Value;
                dgvTavoli.Refresh();
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dgvTavoli.CurrentRow != null)
            {
                tavoli.Remove((Tavolo)dgvTavoli.CurrentRow.DataBoundItem);
            }
        }

        private void dgvTavoli_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTavoli.CurrentRow != null)
            {
                Tavolo selected = (Tavolo)dgvTavoli.CurrentRow.DataBoundItem;
                txtGioco.Text = selected.Gioco;
                nudPosti.Value = selected.NGiocatori;
                cbxCroupier.Checked = selected.Croupier;
                nudMinBet.Value = (decimal)selected.PuntataMin;
                nudMaxBet.Value = (decimal)selected.PuntataMax;
            }
        }

        private void PulisciCampi()
        {
            txtGioco.Clear();
            nudPosti.Value = 2;
            cbxCroupier.Checked = false;
            nudMinBet.Value = 10;
            nudMaxBet.Value = 1000;
        }
    }
}
