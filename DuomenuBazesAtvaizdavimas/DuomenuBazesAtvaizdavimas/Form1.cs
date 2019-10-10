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
    public partial class Form : System.Windows.Forms.Form
    {
        private string ConnectionString;
        private List<Panel> paneles;
        private List<PictureBox> PictureBoxContainer;

        public Form()
        {
            InitializeComponent();
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C--kursas-20190923\DuomenuBazesAtvaizdavimas\DuomenuBazesAtvaizdavimas\RobotDataBase.mdf;Integrated Security=True";
            Load += FormLoading;
            paneles = new List<Panel>();
            PictureBoxContainer = new List<PictureBox>();
            BackColor = Color.White;
            AutoScroll = true;
        }

        private void FormLoading(object sender, EventArgs e)
        {
            DataContext db = new DataContext(ConnectionString);
            var table = db.GetTable<Uzsakymai>().Where(x => x.State != "Done");
            DataGridView data = new DataGridView();
            data.DataSource = table;

            data.Location = new Point(10, 10);
            data.Size = new Size(600, 200);
            //Controls.Add(data);
            int i = 1;
            foreach (var item in table)
            {
                CreateNewPanel(i++, item.Id);
            }
        }

        private void CreateNewPanel(int i, int ID)
        {
            Panel panel = new Panel();
            panel.Size = new Size(300, 200);
            panel.BackColor = Color.FromArgb(230, 230, 230);
            if (paneles.Count == 0)
            {
                panel.Location = new Point(10, 10);
            }
            else
            {
                if (paneles.Last().Location.X + paneles.Last().Width > Width)
                {
                    panel.Location = new Point(10, paneles.Last().Location.Y + 200 + 10);
                }
                else
                {
                    panel.Location = new Point(paneles.Last().Location.X + paneles.Last().Width + 10,
                        paneles.Last().Location.Y);
                }
            }
            Label label = new Label();
            label.Location = new Point(10, panel.Height / 2);
            label.Text = i.ToString();
            label.Font = new Font("Arial", 20);
            label.AutoSize = true;
            panel.Name = ID.ToString();
            panel.DoubleClick += DoubleClickPanel;
            panel.Controls.Add(label);
            Controls.Add(panel);
            paneles.Add(panel);
        }

        private void DoubleClickPanel(object sender, EventArgs e)
        {
            Controls.Clear();
            Control control = (Control)sender;
            DataContext db = new DataContext(ConnectionString);
            var table = db.GetTable<Uzsakymai>().Where(x => x.Id == int.Parse(control.Name)).First();
            foreach (var item in table.Sheets)
            {
                CreatePicture(item);
            }
        }

        private void CreatePicture(Sheet data)
        {
            PictureBox picture = new PictureBox();
            picture.Size = new Size((int)data.Width, (int)data.Height);
            foreach (var item in data.DrawingInDBs)
            {
                PictureBox pic = new PictureBox();
                pic.Location = new Point((int)item.PositionX, (int)item.PositionY);
                pic.Size = new Size((int)item.Width, (int)item.Height);
                foreach (var line in item.LINESQLs)
                {
                    picture.Paint += (toSend, ev) =>
                    {
                        Point start = new Point(pic.Location.X * 2 + (int)line.StartX, pic.Location.Y * 2 + (int)line.StartY);
                        Point end = new Point(pic.Location.X * 2 + (int)line.EndX, pic.Location.Y * 2 + (int)line.EndY);
                        Pen p = new Pen(Color.Black);
                        ev.Graphics.DrawLine(p, start, end);
                    };
                    //picture.Controls.Add(pic);
                }
            }
            Bitmap bitmap = new Bitmap(picture.Width, picture.Height);
            picture.DrawToBitmap(bitmap, picture.ClientRectangle);
            PictureBox addPic = new PictureBox();
            addPic.Size = new Size(300, 200);
            addPic.BackgroundImage = bitmap;
            addPic.BackgroundImageLayout = ImageLayout.Stretch;
            if (PictureBoxContainer.Count == 0)
            {
                addPic.Location = new Point(10, 10);
            }
            else
            {
                if (PictureBoxContainer.Last().Location.X + PictureBoxContainer.Last().Width > Width)
                {
                    addPic.Location = new Point(10, PictureBoxContainer.Last().Location.Y + 200 + 10);
                }
                else
                {
                    addPic.Location = new Point(PictureBoxContainer.Last().Location.X
                        + PictureBoxContainer.Last().Width + 10,
                        PictureBoxContainer.Last().Location.Y);
                }
            }
            Controls.Add(addPic);
            PictureBoxContainer.Add(addPic);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            paneles.Clear();
            MainPanel.Controls.Clear();
            PictureBoxContainer.Clear();
            DataContext db = new DataContext(ConnectionString);
            var table = db.GetTable<Uzsakymai>().Where(x => x.State != "Done");
            //Controls.Add(data);
            int i = 1;
            foreach (var item in table)
            {
                CreateNewPanel(i++, item.Id);
            }
        }
    }
}