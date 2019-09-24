using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraktiKlase
{
    internal abstract class Figura
    {
        public abstract double Plotas(int a, int b);

        public int parametras { get; set; }

        public void Isvedimas()
        {
            Console.WriteLine("Labas");
        }
    }

    internal class Trikampis : Figura
    {
        public override double Plotas(int a, int b)
        {
            return (0.5 * a * b);
        }
    }

    internal class Keturkampis : Figura
    {
        public override double Plotas(int a, int b)
        {
            return a * b;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}