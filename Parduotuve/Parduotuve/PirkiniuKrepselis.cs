using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parduotuve
{
    internal class Preke
    {
        public string Pavadinimas { get; set; }
        public double Kaina { get; set; }
    }

    internal class PirkiniuKrepselis
    {
        private readonly List<Preke> Krepselis;
        public Siuntimas Siunta;

        public PirkiniuKrepselis()
        {
            Krepselis = new List<Preke>();
            Siunta = new Siuntimas();
        }

        public void PridetiPreke(Preke preke)
        {
            Krepselis.Add(preke);
            Siunta.KiekisPirkiniu++;
            Siunta.PrekiuKaina += preke.Kaina;
        }

        public void VisoMoketi()
        {
            Console.WriteLine("Viso moketi reikes: "
                + (Siunta.PrekiuKaina
                + Siunta.SiuntosKaina).ToString("F2"));
        }
    }
}