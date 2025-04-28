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
        private static Cassa? cassa = Cassa.GetData();
        public FormGestioneCassa(Amministratore a)
        {
            amministratore = a;
            InitializeComponent();
            dgvCassa.DataSource = new BindingList<Cassa>() {cassa};
            dgvTransazione.DataSource = TransazioneDenaro.GetData();
        }

        private void btEseguiTransazione_Click(object sender, EventArgs e)
        {
            amministratore.EseguiTransazione(Convert.ToInt32(tbTransazione.Text)*2, Convert.ToInt32(tbTransazione.Text));
            //non funziona non capisco perchè :)
        }
    }
}
