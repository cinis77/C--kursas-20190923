using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class MusuSingleton
    {
        private MusuSingleton()
        {
        }

        public static int SudetiDuSkaicius(int a, int b)
        {
            return a + b;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(MusuSingleton.SudetiDuSkaicius(1, 1));
        }
    }
}