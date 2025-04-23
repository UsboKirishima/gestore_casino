import java.time.LocalDateTime;

public class Turno {
    private LocalDateTime dataInizio;
    private LocalDateTime dataFine;

    public Turno(LocalDateTime dataInizio, LocalDateTime dataFine) {
        this.dataInizio = dataInizio;
        this.dataFine = dataFine;
    }

    public double incassoFineTurno() {
        return Math.random() * 1000;  // Placeholder
    }

    // Getters and Setters
}
