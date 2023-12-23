using Domein;
using Persistentie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUI
{
    public class Program
    {
        
       static void Main(string[] args)
        {

            Data data = new Data();
            Console.WriteLine($"Welkom {data.GetGebruiker()._voorNaam} U heeft volgende rekening openstaan");
            Console.WriteLine("Items:");
            Console.WriteLine("basketbal 5EURO");
            Console.WriteLine("voetbal 10EURO");
            Console.WriteLine("volleybal 15EURO");
            Console.WriteLine("tennisbal 20EURO");
            Console.WriteLine($"Totaalprijs: {data.GetWinkelmandjePrijs()} Euro");
            Betalen();
        }
        static void Betalen()
        {
            Console.WriteLine("Wenst u te betalen? (ja/nee)");

            Controleer();

        }
        static void Controleer()
        {
            string antwoord = Console.ReadLine().ToLower();

            if (antwoord == "ja")
            {
                Console.WriteLine("U heeft betaald");
            }
            else if (antwoord == "nee")
            {
                Console.WriteLine("Bestelling geannuleerd");
            }
            else
            {
                Console.WriteLine("U heeft een ongeldig antwoord gegeven! probeer te antwoorden met Ja of Nee");
                Betalen();
            }
        }
    }
}
