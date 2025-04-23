public class Tavolo {
    private String gioco;
    private int nGiocatori;
    private boolean croupier;
    private double puntataMin;
    private double puntataMax;

    public Tavolo(String gioco, int nGiocatori, boolean croupier, double puntataMin, double puntataMax) {
        this.gioco = gioco;
        this.nGiocatori = nGiocatori;
        this.croupier = croupier;
        this.puntataMin = puntataMin;
        this.puntataMax = puntataMax;
    }

    // Getters and Setters
}
