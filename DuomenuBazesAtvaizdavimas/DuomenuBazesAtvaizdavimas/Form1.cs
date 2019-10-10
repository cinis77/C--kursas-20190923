using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuomenuBazesAtvaizdavimas
{
    public partial class Form1 : Form
    {
        private string ConnectionString;

        public Form1()
        {
            InitializeComponent();
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C--kursas-20190923\DuomenuBazesAtvaizdavimas\DuomenuBazesAtvaizdavimas\RobotDataBase.mdf;Integrated Security=True";
            Load += FormLoading;
        }

        private void FormLoading(object sender, EventArgs e)
        {
            DataContext db = new DataContext(ConnectionString);
            var table = db.GetTable<Uzsakymai>();
            DataGridView data = new DataGridView();
            data.DataSource = table;
            data.Location = new Point(10, 10);
            data.Size = new Size(600, 200);
            Controls.Add(data);
        }
    }
}