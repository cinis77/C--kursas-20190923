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
    public partial class RegistracijosForma : Form
    {
        public RegistracijosForma()
        {
            InitializeComponent();
        }

        private void RegistruotisMygtukas_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Vardas = NameText.Text,
                Pavarde = SurnameText.Text,
                UserName = UserNameText.Text,
                Password = PassWordName.Text
            };
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C--kursas-20190923\Rezervacijo\Rezervacijo\RezervacijosDB.mdf;Integrated Security=True";

            System.Data.Linq.DataContext db = new System.Data.Linq.DataContext(connection);
            db.GetTable<User>().InsertOnSubmit(user);
            db.SubmitChanges();
            Close();
        }
    }
}