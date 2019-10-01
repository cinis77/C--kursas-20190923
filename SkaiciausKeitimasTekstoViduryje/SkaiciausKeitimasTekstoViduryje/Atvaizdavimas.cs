using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkaiciausKeitimasTekstoViduryje
{
    public partial class Atvaizdavimas : Form
    {
        public Atvaizdavimas()
        {
            InitializeComponent();
        }

        public void GautiNaujaSkaiciu(int skaicius)
        {
            var data = label1.Text.Split(' ');
            for (int i = 0; i < data.Length; i++)
            {
                int sk = 0;
                if (int.TryParse(data[i], out sk))
                {
                    data[i] = skaicius.ToString();
                }
            }
            string tekstas = "";
            foreach (var item in data)
            {
                tekstas += item + " ";
            }
            label1.Text = tekstas;
        }
    }
}