import java.time.LocalDateTime;

public class TransazioneDenaro {
    private LocalDateTime data;
    private double fiches;
    private double contanti;

    public TransazioneDenaro(double fiches, double contanti) {
        this.data = LocalDateTime.now();
        this.fiches = fiches;
        this.contanti = contanti;
    }

    public void transazione() {
        // Logica per effettuare la transazione
    }

    // Getters and Setters
}
