using Domein;

namespace Persistentie {
    public class Data {
        Rekening a = new Rekening("BE44 8940 7842 5630", 1, 1);
        Rekening b = new Rekening("BE44 9068 7326 0531", 200, 2);

        User user1 = new User(1, "Tijs", "Baeyens", "tijsbaeyens8@gmail.com", "hatsjoe");
        User user2 = new User(2, "Toon", "Van de velde", "Toon@gmail.com", "Toon123");

        public Rekening geefRekening1() { return a; }
        public Rekening geefRekening2() {  return b; }
        public User getUser1() { return user1; }
        public User getUser2() { return user2; }
    }
}
