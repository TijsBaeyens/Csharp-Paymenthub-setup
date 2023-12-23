using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domein
{
    public class Gebruiker
    {
        public int _Id { get; set; }
        public string _voorNaam { get; set; }
        public string _achterNaam { get; set; }
        public string _email { get; set; }
        public string _wachtwoord { get; set; }

        public Gebruiker(int id, string voorNaam, string achterNaam, string email, string wachtwoord)
        {
            _Id = id;
            _voorNaam = voorNaam;
            _achterNaam = achterNaam;
            _email = email;
            _wachtwoord = wachtwoord;
        }
    }           
}
