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
    public partial class FormGestioneCassa : Form
    {
        private Amministratore amministratore;
        private static Cassa cassa = Cassa.GetData();
        public FormGestioneCassa(Amministratore a)
        {
            amministratore = a;
            InitializeComponent();
            dgvCassa.DataSource = new BindingList<Cassa>() {
                cassa
            };

            dgvTransazione.DataSource = Gestore.GetTransazioni();
        }

        private void btEseguiTransazione_Click(object sender, EventArgs e)
        {
            // FIX: La transazione accetta parametri double, venivano convertiti in Int32
            amministratore.EseguiTransazione(Convert.ToDouble(tbTransazione.Text) * 2, Convert.ToDouble(tbTransazione.Text));
            
            dgvTransazione.DataSource = null;
            dgvTransazione.DataSource = Gestore.GetTransazioni();
        }
    }
}
