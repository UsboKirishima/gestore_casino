using ClassLibraryCasino;

namespace WinFormsCasino
{
    public partial class FormAmministratore : Form
    {
        private Amministratore? amministratore = new Amministratore("", "", 0, "admin", "CadelGo!");
        public FormAmministratore()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            loginAmministratore1.Visible = true;
            amministratore = null;
        }

        private void btCassa_Click(object sender, EventArgs e)
        {
            FormGestioneCassa form = new FormGestioneCassa(amministratore);
            form.Visible = true;
        }

        private void loginAmministratore1_Load(object sender, EventArgs e)
        {

        }

        private void btTurni_Click(object sender, EventArgs e)
        {
            FormGestioneTurni formTurni = new FormGestioneTurni();
            formTurni.ShowDialog();
        }

        private void btEntrateUscite_Click(object sender, EventArgs e)
        {
            new FormGestioneTransazioni().ShowDialog();
        }

        private void btTavoli_Click(object sender, EventArgs e)
        {
            new FormGestioneTavoli().ShowDialog();
        }
    }
}
