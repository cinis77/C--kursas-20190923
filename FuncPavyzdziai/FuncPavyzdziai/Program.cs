using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncPavyzdziai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Func<int> Metodas = GrazinaViena;
            Func<int, int, int> MetodasSuma = Suma;
            Func<int, int, string> MetodasSkirtumas = Skirtumas;
        }

        private static string Skirtumas(int a, int b)
        {
            return (a - b).ToString();
        }

        private static int Suma(int a, int b)
        {
            return a + b;
        }

        private static int GrazinaViena()
        {
            return 1;
        }
    }
}