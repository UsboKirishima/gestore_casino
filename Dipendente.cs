public class Dipendente {
    private String nome;
    private String cognome;
    private int stipendio;

    public Dipendente(String nome, String cognome, int stipendio) {
        this.nome = nome;
        this.cognome = cognome;
        this.stipendio = stipendio;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getCognome() {
        return cognome;
    }

    public void setCognome(String cognome) {
        this.cognome = cognome;
    }

    public int getStipendio() {
        return stipendio;
    }

    public void setStipendio(int stipendio) {
        this.stipendio = stipendio;
    }
}
