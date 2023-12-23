using Persistentie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cui {
    public class Program {
        static void Main(string[] args) {
            Data data = new Data();
            Console.WriteLine($"Je bent ingelogd als {data.getUser1()._voorNaam}");
            Console.WriteLine($"Je hebt {data.geefRekening1().bedrag} euro op je rekening staan");

            Console.WriteLine("We schrijven nu 50 euro over naar de andere rekening");

            if (data.geefRekening1().BetaalRekening(50)) {
                data.geefRekening2().KrijgGeld(50);
            
            Console.WriteLine($"Je hebt {data.geefRekening1().bedrag} euro op je rekening staan");
            Console.WriteLine($"De andere gebruiker heeft {data.geefRekening2().bedrag} euro op zijn rekening staan");
            } else {
                Console.WriteLine("Je hebt niet genoeg geld op je rekening staan");
            }
        }

    }
}
