using Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistentie
{
    public class Data
    {

        Winkelmandje item1 = new Winkelmandje("basketbal",1, 5);
        Winkelmandje item2 = new Winkelmandje("voetbal", 1, 10);
        Winkelmandje item3 = new Winkelmandje("volleybal", 1, 15);
        Winkelmandje item4 = new Winkelmandje("tennisbal", 1, 20);

        Gebruiker user1 = new Gebruiker(1, "Tijs", "Baeyens", "tijsbaeyens8@gmail.com", "hatsjoe");
        Gebruiker user2 = new Gebruiker(2, "Toon", "Van de velde", "Toon@gmail.com", "Toon123");

        public List<Winkelmandje> GetWinkelmandje()
        {
            List<Winkelmandje> winkelmandje = new List<Winkelmandje>();
            winkelmandje.Add(item1);
            winkelmandje.Add(item2);
            winkelmandje.Add(item3);
            winkelmandje.Add(item4);
            return winkelmandje;
        }
        public int GetWinkelmandjePrijs()
        {
            int prijs = 0;
            prijs = item1._prijs + item2._prijs + item3._prijs + item4._prijs;
            return prijs;
        }
        public Gebruiker GetGebruiker()
        {
            return user1;
        }
        

    }
}
