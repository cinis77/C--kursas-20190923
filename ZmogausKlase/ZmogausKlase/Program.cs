using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace ZmogausKlase
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            string path = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            }
            List<Zmogus> zmones = new List<Zmogus>();
            using (System.IO.StreamReader reader = new System.IO.StreamReader(path))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    var duomenys = line.Split(';');
                    //Vardas;Pavarde;GimimoData;Lytis
                    Zmogus zmogus = new Zmogus(duomenys[0], duomenys[1],
                        DateTime.Parse(duomenys[2]), duomenys[3]);
                    zmones.Add(zmogus);
                }
            }
            Console.WriteLine(zmones.First().Vardas + " " + zmones.First().Pavarde +
                " " + zmones.First().GimimoDiena + " " + zmones.First().Lytis);
        }
    }
}