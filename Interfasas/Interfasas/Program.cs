using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfasas
{
    internal interface Ainterfas
    {
        void MetodasA();

        int PropertisA { get; set; }
    }

    internal interface Binterfas
    {
        void MetodasB();

        int PropertisB { get; set; }
    }

    internal class ManoKlase : Ainterfas, Binterfas
    {
        private int _A;

        public int PropertisA
        {
            get
            {
                return _A;
            }
            set
            {
                if (value != _A)
                {
                    _A = value;
                }
            }
        }

        public int PropertisB { get; set; }

        public void MetodasA()
        {
            Console.WriteLine("Panaudojamas metodas pirma klase");
        }

        public void MetodasB()
        {
            Console.WriteLine("Panaudojamas metodas pirma klase");
        }
    }

    internal class AntraKlase
    {
        public Ainterfas InterfaceProperty { get; set; }

        public AntraKlase(Ainterfas ainterfas)
        {
            InterfaceProperty = ainterfas;
            InterfaceProperty.MetodasA();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            ManoKlase mano = new ManoKlase();
            AntraKlase antra = new AntraKlase(mano);
        }
    }
}