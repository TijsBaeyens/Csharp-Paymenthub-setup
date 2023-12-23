namespace Domein {
    public class Rekening {
        public string rekeningNummer { get; set; }
        public double bedrag { get; set; }
        public int UserId { get; set; }

        public Rekening(string rekeningNummer, double bedrag, int userId) {
            this.rekeningNummer = rekeningNummer;
            this.bedrag = bedrag;
            UserId = userId;
        }

        public bool BetaalRekening(double teBetalen) {
            if (teBetalen > bedrag) {
                return false;
            } else {
                bedrag -= teBetalen;
                return true;
            }
        }

        public void KrijgGeld(double teKrijgen) {
            bedrag += teKrijgen;
        }
    }
}
