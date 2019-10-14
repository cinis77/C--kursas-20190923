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
    public partial class RezervacijosForma : Form
    {
        private string connectionString;
        private int UserId;

        public RezervacijosForma(string connection, int userId)
        {
            InitializeComponent();
            connectionString = connection;
            UserId = userId;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            System.Data.Linq.DataContext db = new System.Data.Linq.
                DataContext(Properties.Resources.ConnectionString);
            Resultatas.DataSource =
                db.GetTable<Lektuva>().
                Where(x => x.AtvykimoVieta == KryptisText.Text
                && x.Isvykimas.Date > dateTimePicker1.Value);
        }

        private void Resultatas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                //Antra klase
                Vieta vieta = new Vieta();
                vieta.firstclass = false;
                System.Data.Linq.DataContext db = new System.Data.Linq.
                DataContext(Properties.Resources.ConnectionString);
                var lektuvas = db.GetTable<Lektuva>().Where(x => x.Id ==
                (int)Resultatas.Rows[e.RowIndex].Cells[0].Value);
                lektuvas.First().AntrosKlasesVietuSkaicius--;
                var user = db.GetTable<User>().Where(x => x.Id == UserId);
                user.First().Vietas.Add(vieta);
                lektuvas.First().Vietas.Add(vieta);
                db.GetTable<Vieta>().InsertOnSubmit(vieta);
                db.SubmitChanges();
                MessageBox.Show("Jus sekmingai atlikote rezervacija");
            }
            else if (e.ColumnIndex == 3)
            {
                Vieta vieta = new Vieta();
                vieta.firstclass = true;
                System.Data.Linq.DataContext db = new System.Data.Linq.
                DataContext(Properties.Resources.ConnectionString);
                var lektuvas = db.GetTable<Lektuva>().Where(x => x.Id ==
                (int)Resultatas.Rows[e.RowIndex].Cells[0].Value);
                lektuvas.First().PirmosKlasesVietuSkaicius--;
                var user = db.GetTable<User>().Where(x => x.Id == UserId);
                user.First().Vietas.Add(vieta);
                lektuvas.First().Vietas.Add(vieta);
                db.GetTable<Vieta>().InsertOnSubmit(vieta);
                db.SubmitChanges();
                MessageBox.Show("Jus sekmingai atlikote rezervacija");
            }
        }
    }
}