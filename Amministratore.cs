public class Amministratore extends Dipendente {
    private String username;
    private String password;

    public Amministratore(String nome, String cognome, int stipendio, String username, String password) {
        super(nome, cognome, stipendio);
        this.username = username;
        this.password = password;
    }

    public boolean login(String username, String password) {
        return this.username.equals(username) && this.password.equals(password);
    }

    // Metodi per la gestione delle casse, turni, etc.
}
