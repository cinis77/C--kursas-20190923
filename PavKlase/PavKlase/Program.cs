using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavKlase
{
    internal class Telefonas
    {
        public int Numeris { get; private set; }
        public string Gamintojas { get; }
        public DateTime GamybosMetai { get; }

        public Telefonas(string Gamintojas, DateTime GamybosMetai)
        {
            this.Gamintojas = Gamintojas;
            this.GamybosMetai = GamybosMetai;
        }

        public virtual void SuteiktiNumeri(int numeris)
        {
            Numeris = numeris;
        }
    }

    internal class LaidinisTelefonas : Telefonas
    {
        public string IvedimoTipas { get; }

        public string Tipas { get; set; }

        public LaidinisTelefonas(string gamintojas, DateTime metai)
            : base(GamybosMetai: metai, Gamintojas: gamintojas)
        {
        }

        public LaidinisTelefonas(string gamintojas, DateTime gamybosMetai, string Tipas)
            : base(gamintojas, gamybosMetai)
        {
        }

        public override void SuteiktiNumeri(int numeris)
        {
            numeris = 837000000 + numeris;
            base.SuteiktiNumeri(numeris);
            Console.WriteLine("Esu laidinis telefonas");
        }
    }

    internal class MobilusTelefonas : Telefonas
    {
        public string SimKortelesTipas { get; set; }
        public string RysioTipas { get; set; }

        public MobilusTelefonas(string gamintojas, DateTime gamybosMetai) : base(gamintojas, gamybosMetai)
        {
        }

        public override void SuteiktiNumeri(int numeris)
        {
            numeris = 86000000 + numeris;
            base.SuteiktiNumeri(numeris);
        }
    }

    internal class IsmanusTelefonas : MobilusTelefonas
    {
        public string OperacineSistemosTipas { get; set; }
        public string Kamera { get; set; }
        public string Dizainas { get; set; }

        public IsmanusTelefonas(string gamintojas, DateTime gamybosMetai)
            : base(gamintojas, gamybosMetai)
        {
        }

        public override void SuteiktiNumeri(int numeris)
        {
            base.SuteiktiNumeri(numeris);
            Console.WriteLine("Esu ismanusis telefonas");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Telefonas> telefonai = new List<Telefonas>();
            int sk = 5;
            LaidinisTelefonas laidinis = new LaidinisTelefonas("Alkatel", DateTime.Today);
            telefonai.Add(laidinis);
            telefonai.Add(new LaidinisTelefonas("Siemens", new DateTime(1996, 08, 12)));
            telefonai.Add(new MobilusTelefonas("Nokia", new DateTime(2009, 09, 05)));
            telefonai.Add(new IsmanusTelefonas("Samsung", DateTime.Today));
            foreach (var item in telefonai)
            {
                item.SuteiktiNumeri(355521);
                Console.WriteLine(telefonai.Count);
            }
        }
    }
}