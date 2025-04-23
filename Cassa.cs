public class Cassa {
    private double fiches;
    private double contanti;

    public Cassa(double fiches, double contanti) {
        this.fiches = fiches;
        this.contanti = contanti;
    }

    public double cambioFiches(double amount) {
        if (amount > this.contanti) {
            System.out.println("Saldo insufficiente.");
            return 0;
        }
        this.contanti -= amount;
        this.fiches += amount;
        return amount;
    }

    public void versamentoIncassoFiches(double amount) {
        this.fiches -= amount;
        this.contanti += amount;
    }

    // Getters and Setters
}
