using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakciosKlasesPrisiminimas
{
    internal abstract class Figura
    {
        public int perimetras;
        public double plotas;

        public abstract void Plotas();

        public abstract void Perimetras();
    }

    internal class Trikampis : Figura
    {
        public int a;
        public int b;
        public int c;

        public override void Plotas()
        {
            plotas = a * b * 0.5;
        }

        public override void Perimetras()
        {
            perimetras = a + b + c;
        }
    }

    internal class Kvadratas : Figura
    {
        public int a;

        public override void Plotas()
        {
            plotas = a * a;
        }

        public override void Perimetras()
        {
            perimetras = a * 4;
        }
    }

    internal class Staciakampis : Figura
    {
        public int a;
        public int b;

        public override void Plotas()
        {
            plotas = a * b;
        }

        public override void Perimetras()
        {
            perimetras = 2 * a + 2 * b;
        }
    }

    internal class Sesiakampis : Figura
    {
        public int a;

        public override void Plotas()
        {
            plotas = 3 * Math.Sqrt(3 * Math.Pow(a, 2)) / 2;
        }

        public override void Perimetras()
        {
            perimetras = 6 * a;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Trikampis trikampis = new Trikampis();
            Action plotas = trikampis.Plotas;
            Dictionary<string, Action> PlotoSkaiciavimai = new Dictionary<string, Action>();
            PlotoSkaiciavimai.Add("Trikampis", trikampis.Plotas);
            PlotoSkaiciavimai["Trikampis"]();
        }
    }
}