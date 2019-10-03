using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingus
{
    public partial class Form1 : Form
    {
        private MainViewBindings bind;

        public Form1()
        {
            InitializeComponent();
            bind = new MainViewBindings();
            Labelis.DataBindings.Add("Text", bind, "TekstoProperty");
            label1.DataBindings.Add("Text", bind, "LabasProperty");
        }

        private void Tekstas_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bind.TekstoProperty = "PC";
            bind.LabasProperty = "Hello";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bind.TekstoProperty = "Kompiuteris";
            bind.LabasProperty = "Labas vakaras";
        }
    }
}