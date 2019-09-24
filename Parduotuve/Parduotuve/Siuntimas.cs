using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parduotuve
{
    internal class Siuntimas
    {
        private int _kiekisPirkiniu;

        public int KiekisPirkiniu
        {
            get
            {
                return _kiekisPirkiniu;
            }
            set
            {
                _kiekisPirkiniu = value;
                if (value < 10)
                {
                    TipasSiuntos = "S";
                }
                else if (value < 25)
                {
                    TipasSiuntos = "M";
                }
                else
                {
                    TipasSiuntos = "L";
                }
                PrekiuKaina = _prekiuKaina;
            }
        }

        private double _prekiuKaina;

        public double PrekiuKaina
        {
            get
            {
                return _prekiuKaina;
            }
            set
            {
                if (value >= 20 && TipasSiuntos == "S")
                {
                    SiuntosKaina = 0;
                }
                else if (value >= 30 && TipasSiuntos == "M")
                {
                    SiuntosKaina = 0;
                }
                else if (TipasSiuntos == "S")
                {
                    SiuntosKaina = 3;
                }
                else if (TipasSiuntos == "M")
                {
                    SiuntosKaina = 5;
                }
                else
                {
                    SiuntosKaina = 5;
                }

                _prekiuKaina = value;
            }
        }

        public string TipasSiuntos { get; set; }

        public double SiuntosKaina { get; set; }
    }
}