public class Giocatore {
    private int codice;
    private String nome;
    private String cognome;
    private double fiches;
    private double contanti;

    public Giocatore(int codice, String nome, String cognome, double fiches, double contanti) {
        this.codice = codice;
        this.nome = nome;
        this.cognome = cognome;
        this.fiches = fiches;
        this.contanti = contanti;
    }

    public void cambiaFiches(double amount) {
        this.fiches += amount;
    }

    public void cambiaContanti(double amount) {
        this.contanti += amount;
    }

    // Getters and Setters
}
