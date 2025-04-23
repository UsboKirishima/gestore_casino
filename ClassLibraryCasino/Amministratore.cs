namespace ClassLibraryCasino
{
    public class Amministratore : Dipendente
    {
        private String username;
        private String password;

        public Amministratore(string nome, string cognome, int stipendio, string username, string password)
            : base(nome, cognome, stipendio)
        {
            this.username = username;
            this.password = password;
        }

        public bool Login(String username, String password)
        {
            return this.username.Equals(username) && this.password.Equals(password);
        }

        // Metodi per la gestione delle casse, turni, etc.


    }
}
