using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skaiciuoklis
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Func<int, int, int>> Veiksmai;

        public Form1()
        {
            InitializeComponent();
            zenklas.Items.Add("+");
            zenklas.Items.Add("-");
            zenklas.Items.Add("*");
            zenklas.Items.Add("/");
            Veiksmai = new Dictionary<string, Func<int, int, int>>();
            Veiksmai.Add("+", Suma);
            Veiksmai.Add("-", Skirtumas);
            Veiksmai.Add("*", Daugyba);
            Veiksmai.Add("/", Dalyba);
        }

        private int Suma(int a, int b)
        {
            return a + b;
        }

        private int Skirtumas(int a, int b)
        {
            return a - b;
        }

        private int Daugyba(int a, int b)
        {
            return a * b;
        }

        private int Dalyba(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                return 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zenklas = (string)this.zenklas.SelectedItem;
            int a = int.Parse(PirmasSkaicius.Text);
            int b = int.Parse(AntrasSkaicius.Text);
            atsakymas.Text = Veiksmai[zenklas](a, b).ToString();
        }
    }
}