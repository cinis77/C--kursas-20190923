using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            Label label = new Label();
            label.Location = new Point(10, 10);
            Controls.Add(label);
            timer1.Tick += TikTimer;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void TikTimer(object sender, EventArgs ev)
        {
            foreach (var item in Controls)
            {
                if (item is Label)
                {
                    Label toUse = (Label)item;
                    toUse.Text = DateTime.Today.TimeOfDay.ToString();
                }
            }
        }
    }
}