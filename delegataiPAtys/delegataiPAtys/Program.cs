using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegataiPAtys
{
    internal class Program
    {
        private delegate void MyDelegata();

        private delegate void SuParametrais(int a, int b);

        private delegate int SuReturnType();

        private delegate int AntrasSuReturnType();

        private static MyDelegata DelegatoKintamasis;
        private static SuParametrais DelegataiSuParametrais;

        private static SuParametrais ADelegatas;
        private static AntrasSuReturnType antras;

        private static void Main(string[] args)
        {
            DelegatoKintamasis = Metodas;
            DelegataiSuParametrais = Suma;
            ADelegatas = antras;
        }

        private static void Suma(int a, int b)
        {
        }

        private static void Metodas()
        {
        }
    }
}