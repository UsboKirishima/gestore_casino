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
        private readonly string username = "admin";
        private readonly string password = "CadelGo!";

        private static Amministratore? amministratore;
        public LoginAmministratore()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Amministratore utente = new Amministratore("", "", 0, tbUsername.Text, tbPassword.Text);
            if (utente.Login(username, password))
            {
                this.Visible = false;
                tbPassword.Text = "";
                tbUsername.Text = "";
            }
            else
            {
                MessageBox.Show("Authentication Error!", "Invalid Password",
                    MessageBoxButtons.OK);
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void skipBtn_Click(object sender, EventArgs e)
        {
            Amministratore utente = new Amministratore("", "", 0, username, password);
            if (utente.Login(username, password))
            {
                this.Visible = false;
            }
        }
    }
}
