using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaveldinciosKlases
{
    internal class Gyvunas // Bazine klase
    {
        public string KailioTipas { get; set; }
        public int Amzius { get; set; }

        public Gyvunas(string kailioTipas)
        {
            KailioTipas = kailioTipas;
        }
    }

    internal class Suo : Gyvunas //Paveldincio klases
    {
        public string TipasNamuos;

        public Suo(string kailioTipo) : base(kailioTipo)
        {
        }
    }

    internal class Korgis : Suo
    {
        public string Vardas;

        public Korgis(string kailioTipo) : base(kailioTipo)
        {
        }
    }

    internal class Kate : Gyvunas // Paveldinti klase
    {
        public string TingumoLygis;

        public Kate(string kailis) : base(kailis)
        {
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Gyvunas gyvunas = new Gyvunas("");
            Suo suo = new Suo("");
            gyvunas = suo; // Polimorfizmas

            List<Gyvunas> gyvunai = new List<Gyvunas>();
            gyvunai.Add(suo);
            Kate kate = new Kate("");
            gyvunai.Add(kate);

            object objektas = suo;
            double sk = 10.5;
            int sk1 = (int)sk;
            Suo sun = (Suo)objektas; //(tipas) kintamasis => kastinimu
        }
    }
}