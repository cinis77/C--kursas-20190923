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
            IsvedamasFailas(zmones);
            RasymasIFaila(path);
        }

        private static void IsvedamasFailas(List<Zmogus> zmog)
        {
            foreach (Zmogus zmogus in zmog)
            {
                Console.WriteLine(zmogus.Vardas + " " + zmogus.Pavarde +
                " " + zmogus.GimimoDiena.ToShortDateString() + " " + zmogus.Lytis);
            }
        }

        /// <summary>
        /// Rasoma informacija i faila
        /// </summary>
        /// <param name="path">kelias iki failo</param>
        private static void RasymasIFaila(string path)
        {
            string duomenys = Console.ReadLine();
            var data = duomenys.Split(' ');
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(path, true))
            {
                writer.WriteLine(data[0] + ";" + data[1] + ";" + data[2] + ";" + data[3]);
            }
        }
    }
}