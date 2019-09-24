using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parduotuve
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Preke batonas = new Preke()
            {
                Pavadinimas = "Batonas",
                Kaina = 0.99
            };
            Preke tepalai = new Preke()
            {
                Pavadinimas = "Tepalai",
                Kaina = 8.99
            };
            Preke Striuke = new Preke()
            {
                Pavadinimas = "Striuke",
                Kaina = 45.99
            };
            Vartotojas vartotojas = new Vartotojas();
            //vartotojas.PrisidetiPreke(Striuke);
            vartotojas.PrisidetiPreke(tepalai);
            vartotojas.PrisidetiPreke(batonas);

            vartotojas.BaigtiPirkima();
        }
    }
}