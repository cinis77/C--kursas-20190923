using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        private static Dictionary<string, Action> strategy = new Dictionary<string, Action>();

        private static void Main(string[] args)
        {
            strategy.Add("1", vienas);
            strategy.Add("2", du);
            strategy.Add("3", trys);
            string data = Console.ReadLine();
            strategy[data]();

            Metodas("4", keturi);
        }

        private static void keturi()
        {
            Console.WriteLine("paspausts 4");
        }

        public static void Metodas(string key, Action methodToUse)
        {
            strategy.Add(key, methodToUse);
        }

        private static void vienas()
        {
            Console.WriteLine("Paspaustas vienetas");
        }

        private static void du()
        {
            Console.WriteLine("Paspaustas du");
        }

        private static void trys()
        {
            Console.WriteLine("Paspausta trys");
        }
    }
}