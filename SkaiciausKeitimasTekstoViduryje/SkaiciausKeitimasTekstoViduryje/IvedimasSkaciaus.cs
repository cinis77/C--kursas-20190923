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
    public partial class IvedimasSkaciaus : Form
    {
        private Action<int> PerduotiSkaiciu;

        public IvedimasSkaciaus(Action<int> PerdavimoFunkcija)
        {
            InitializeComponent();
            PerduotiSkaiciu = PerdavimoFunkcija;
        }

        private void Ivestis_TextChanged(object sender, EventArgs e)
        {
            int skaicius = 0;
            if (int.TryParse(Ivestis.Text, out skaicius))
            {
                PerduotiSkaiciu(skaicius);
            }
            else
            {
                MessageBox.Show("Reikia vesti tik skaicius");
            }
        }
    }
}