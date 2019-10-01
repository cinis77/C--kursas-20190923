using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaneleFormoje
{
    public partial class Form2 : Form
    {
        private Action<int, int> Veiksmas;

        public Form2(Action<int, int> veiksmas)
        {
            InitializeComponent();
            Veiksmas = veiksmas;
        }

        private void Mygtukas_Click(object sender, EventArgs e)
        {
            //Suskaiciuoti atsakyma ir isvesti ji from3
            Veiksmas(int.Parse(Tekstas1.Text), int.Parse(Tekstas2.Text));
        }
    }
}