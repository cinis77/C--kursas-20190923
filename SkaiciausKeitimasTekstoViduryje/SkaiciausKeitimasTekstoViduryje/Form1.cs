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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UzkrautiForma();
        }

        private void UzkrautiForma()
        {
            Atvaizdavimas atvaizdavimas = new Atvaizdavimas();
            atvaizdavimas.TopLevel = false;
            atvaizdavimas.Dock = DockStyle.Fill;
            atvaizdavimas.FormBorderStyle = FormBorderStyle.None;
            TekstoPanele.Controls.Add(atvaizdavimas);
            atvaizdavimas.Show();

            IvedimasSkaciaus ivedimas =
                new IvedimasSkaciaus(atvaizdavimas.GautiNaujaSkaiciu);
            ivedimas.TopLevel = false;
            ivedimas.Dock = DockStyle.Fill;
            ivedimas.FormBorderStyle = FormBorderStyle.None;
            IvedimoPanele.Controls.Add(ivedimas);
            ivedimas.Show();
        }
    }
}