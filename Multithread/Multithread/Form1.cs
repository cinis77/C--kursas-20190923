using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Multithread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(new Action(Metodas));
            await uzduotisAsync();
        }

        private void Metodas()
        {
            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show("Taskas is kito threado");
                Action act = () =>
                {
                    label1.Text = i.ToString();
                };
                Invoke(act);
            }
        }

        private async Task uzduotisAsync()
        {
        }
    }
}