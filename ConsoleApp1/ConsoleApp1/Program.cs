using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pirma
    {
        private void Suma(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public Action<int, int> GrazinamasDelegatas()
        {
            return Suma;
        }
    }

    internal class Antra
    {
        public Action<int, int> DaromasMetodas;

        public Antra(Action<int, int> callBack)
        {
            DaromasMetodas = callBack;
        }

        public void DarytiPirmaMetoda()
        {
            DaromasMetodas(1, 2);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Action Delegatas = MetodasA; // Action => void Metodai()
            Delegatas += Metodas;
            Action<int> DelegatasSuParametru = MetodasB;
            Action<int, int, int> Delegetai;

            Pirma p = new Pirma();
            Antra a = new Antra(p.GrazinamasDelegatas());
            a.DarytiPirmaMetoda();
        }

        public static void MetodasB(int a)
        {
        }

        public static void MetodasA()
        {
        }

        public static void Metodas()
        {
        }
    }
}