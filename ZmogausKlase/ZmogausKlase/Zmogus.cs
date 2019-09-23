using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZmogausKlase
{
    internal class Zmogus
    {
        public string Vardas { get; }
        public string Pavarde { get; private set; }
        public DateTime GimimoDiena { get; }
        public string Lytis { get; private set; }

        public Zmogus(string Vardas, string Pavarde, DateTime GimimoData, string Lytis)
        {
            this.Vardas = Vardas;
            this.Pavarde = Pavarde;
            GimimoDiena = GimimoData;
            this.Lytis = Lytis;
        }

        public bool ArSuages()
        {
            if (DateTime.Today.Year - GimimoDiena.Year >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}