using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domein
{
    public class Winkelmandje
    {
        public string _item { get; set; }
        public int _aantal { get; set; }
        public int _prijs { get; set; }

        public Winkelmandje(string item, int aantal, int prijs)
        {
            _item = item;
            _aantal = aantal;
            _prijs = prijs;
        }
    }
}
