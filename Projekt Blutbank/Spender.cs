using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Blutbank
{
    class Spender
    {
        public int SpenderID { get; set; }
        public String Nachname { get; set; }
        public String Vorname { get; set; }
        public String Blutgruppe { get; set; }
        public String Wohnort { get; set; }
        public DateTime letzteSpende { get; set; }
    }
}
