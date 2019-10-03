using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoldunuValgymoCempionatas
{
    internal class TurinysOut : Exception
    {
        public TurinysOut() : base("Apsivemimas")
        {
        }
    }

    internal class Zaidejai
    {
        public int SkrandzioTuris { get; set; }
        public int ValgymoGreitis { get; set; }

        public Zaidejai(int skrandzioTuris, int valgymoGreitis)
        {
            SkrandzioTuris = skrandzioTuris;
            ValgymoGreitis = valgymoGreitis;
        }

        public void ValgytiKoldunos(int kiekis)
        {
            if (SkrandzioTuris < kiekis)
            {
                throw new TurinysOut();
            }
            Console.WriteLine("Suvalge per " + ((double)kiekis / ValgymoGreitis).ToString("F2"));
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Zaidejai zaidejas1 = new Zaidejai(12, 5);
            Zaidejai zaidejas2 = new Zaidejai(9, 1);
            Zaidejai zaidejas3 = new Zaidejai(20, 10);
            Zaidejai zaidejas4 = new Zaidejai(8, 1);
            Zaidejai zaidejas5 = new Zaidejai(5, 1);
            Zaidejai zaidejas6 = new Zaidejai(24, 11);

            List<Zaidejai> zaidejai = new List<Zaidejai>()
            { zaidejas1, zaidejas2, zaidejas3, zaidejas4, zaidejas5, zaidejas6 };
            foreach (var zaidejas in zaidejai)
            {
                try
                {
                    zaidejas.ValgytiKoldunos(13);
                }
                catch (TurinysOut ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nezinoma klaida");
                }
            }
        }
    }
}