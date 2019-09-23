using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleloto
{
    public partial class TelelotoZaidimas : Form
    {
        public TelelotoZaidimas()
        {
            InitializeComponent();
        }

        private void GeneruotiMygtukas_Click(object sender, EventArgs e)
        {
            TextBox[] Melyni = { M1, M2, M3, M4, M5 };
            SugeneruotiStulpeli(Melyni, 1, 16);
            TextBox[] Juodi = { J1, J2, J3, J4, J5 };
            SugeneruotiStulpeli(Juodi, 16, 31);
            TextBox[] Raudoni = { R1, R2, R3, R4, R5 };
            SugeneruotiStulpeli(Raudoni, 31, 46);
            TextBox[] Geltoni = { G1, G2, G3, G4, G5 };
            SugeneruotiStulpeli(Geltoni, 46, 61);
            TextBox[] Zali = { Z1, Z2, Z3, Z4, Z5 };
            SugeneruotiStulpeli(Zali, 61, 76);
        }

        private void SugeneruotiStulpeli(TextBox[] stulpelis, int a, int b)
        {
            Random rng = new Random();
            int i = 0;
            List<int> isridenti = new List<int>();
            while (i < stulpelis.Length)
            {
                int kamuoliukas = rng.Next(a, b);

                bool jauIsridentas = false;
                foreach (var kamuoliuka in isridenti)
                {
                    if (kamuoliuka == kamuoliukas)
                    {
                        jauIsridentas = true;
                        break;
                    }
                }

                if (!jauIsridentas)
                {
                    stulpelis[i].Text = kamuoliukas.ToString();
                    i++;
                    isridenti.Add(kamuoliukas);
                }
            }
        }

        private void ZaistiB_Click(object sender, EventArgs e)
        {
            int i = 0;
            Random rng = new Random();
            List<int> IsridentiKamuoliukaiAuksiniui = new List<int>();
            NuimtiSpalva();
            KamuoliukaiIsridenti.Text = string.Empty;
            while (i < 45)
            {
                int kamuoliukas = rng.Next(1, 76);
                bool jauIsridentas = false;

                foreach (var kam in IsridentiKamuoliukaiAuksiniui)
                {
                    if (kam == kamuoliukas)
                    {
                        jauIsridentas = true;
                        break;
                    }
                }

                if (!jauIsridentas)
                {
                    KamuoliukaiIsridenti.Text += kamuoliukas.ToString() + " ";
                    i++;
                    PatirkintiKamuoliuka(kamuoliukas);
                    IsridentiKamuoliukaiAuksiniui.Add(kamuoliukas);
                }
            }
        }

        private void PatirkintiKamuoliuka(int kamuoliukas)
        {
            TextBox[] bilietas = {M1, M2, M3, M4, M5,
                                  J1, J2, J3, J4, J5,
                                   R1, R2, R3, R4, R5,
                                    G1, G2, G3, G4, G5,
                                   Z1, Z2, Z3, Z4, Z5 };
            foreach (var item in bilietas)
            {
                if (item.Text == kamuoliukas.ToString())
                {
                    item.BackColor = Color.Green;
                    break;
                }
            }
        }

        private void NuimtiSpalva()
        {
            TextBox[] bilietas = {M1, M2, M3, M4, M5,
                                  J1, J2, J3, J4, J5,
                                   R1, R2, R3, R4, R5,
                                    G1, G2, G3, G4, G5,
                                   Z1, Z2, Z3, Z4, Z5 };
            foreach (var item in bilietas)
            {
                item.BackColor = Color.White;
            }
        }
    }
}