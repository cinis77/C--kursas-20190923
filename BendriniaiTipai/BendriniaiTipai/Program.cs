using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BendriniaiTipai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> zodziuMasyvas = new List<string>();
            zodziuMasyvas.Add("Labas");
            zodziuMasyvas.Add("Pasauli");
            Console.WriteLine(zodziuMasyvas[1]);

            List<int> A = new List<int>() { 0, 1, 2 };
            List<int> B = new List<int>();
            B = A;

            Dictionary<string, int> zodynelis = new Dictionary<string, int>();
            zodynelis.Add("vienas", 1);
            Dictionary<string, List<int>> duomenys = new Dictionary<string, List<int>>();
            Dictionary<List<int>, Dictionary<string, int>> bigData = new Dictionary<List<int>, Dictionary<string, int>>();
            duomenys.Add("pirmas", A);
            Console.WriteLine(duomenys["pirmas"].Count());
            //Console.WriteLine(zodynelis["vienas"]);
            A.Clear();
            Console.WriteLine(duomenys["pirmas"].Count());
        }
    }
}