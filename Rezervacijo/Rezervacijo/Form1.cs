using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervacijo
{
    public partial class Form1 : Form
    {
        private string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C--kursas-20190923\Rezervacijo\Rezervacijo\RezervacijosDB.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Registruotis_Click(object sender, EventArgs e)
        {
            RegistracijosForma reg = new RegistracijosForma();

            reg.Show();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            System.Data.Linq.DataContext db = new System.Data.Linq.DataContext(connection);
            var user = db.GetTable<User>().
                Where(x => x.UserName == UserNameText.Text && x.Password == PassWordText.Text);
            if (user.Count() == 0)
            {
                MessageBox.Show("Nerastas toks vartotojas");
            }
            else
            {
                RezervacijosForma form = new RezervacijosForma(connection, user.First().Id);
                form.Show();
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}