using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonuKnyga
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, long> TelefonuKnyga = new Dictionary<string, long>();
            TelefonuKnyga.Add("tomas lapenas", 8654798142);
            TelefonuKnyga.Add("rokas petras", 864579921);
            TelefonuKnyga.Add("urte lapa", 86457892179);
            TelefonuKnyga.Add("rita teta", 86978421265);
            TelefonuKnyga.Add("lukas masas", 861235476);
            foreach (var item in TelefonuKnyga)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("Nurodykite kurio asmens telefono numeri norite matyti");
            string vardas = Console.ReadLine();
            if (TelefonuKnyga.Keys.Contains(vardas))
            {
                Console.WriteLine(TelefonuKnyga[vardas.ToLower()]);
            }
            else
            {
                Console.WriteLine("Nerastas vardas");
            }
        }
    }
}