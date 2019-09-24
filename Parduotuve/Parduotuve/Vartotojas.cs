using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parduotuve
{
    internal class Vartotojas
    {
        public int ID { get; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public PirkiniuKrepselis Krepselis { get; set; }

        public Vartotojas()
        {
            Krepselis = new PirkiniuKrepselis();
        }

        public void PrisidetiPreke(Preke preke)
        {
            Krepselis.PridetiPreke(preke);
        }

        public void BaigtiPirkima()
        {
            Krepselis.VisoMoketi();
        }
    }
}