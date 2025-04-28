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
    public partial class LoginAmministratore : UserControl
    {
        private static string username="admin";
        private static string password="CadelGo!";
        private static Amministratore? amministratore;
        public LoginAmministratore()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Amministratore utente = new Amministratore("", "", 0, tbUsername.Text, tbPassword.Text);
            if(utente.Login(username, password))
            {
                this.Visible = false;
                tbPassword.Text = "";
                tbUsername.Text = "";
                lbErrore.Text = "";
            }
            else
            {
                lbErrore.Text = "Credenziali errate!";
            }
        }
    }
}
