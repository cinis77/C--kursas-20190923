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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadInForm();
        }

        private void LoadInForm()
        {
            Form3 form = new Form3();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            MazaPanele.Controls.Add(form);
            form.Show();
            Action<int, int> veiksmai = form.Suma;
            veiksmai += form.Skirtumas;

            Form2 forom = new Form2(veiksmai);
            forom.TopLevel = false;
            forom.Dock = DockStyle.Fill;
            forom.FormBorderStyle = FormBorderStyle.None;
            DidelePanele.Controls.Add(forom);
            forom.Show();
        }
    }
}