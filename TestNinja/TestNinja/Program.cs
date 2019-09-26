using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja
{
    public class User
    {
        public bool IsAdmin { get; set; }
    }

    public class Rezervacija
    {
        public User KienoRezervacija { get; set; }

        public void DarytRezervacija(User uzsakytojas)
        {
            KienoRezervacija = uzsakytojas;
        }

        public bool AtsauktiRezervacija(User atsaukejas)
        {
            if (atsaukejas == KienoRezervacija)
            {
                return true;
            }
            else if (atsaukejas.IsAdmin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void KazkasNetinka()
        {
            throw new FormatException();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}