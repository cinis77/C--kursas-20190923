using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string path = null;
            ofd.Filter = "Paveiksliukas mazas *.png|*.png| Internetinis *.jpg|*.jpg|All files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
            PictureBox picture = new PictureBox();
            picture.BackgroundImage = Image.FromFile(path);
            picture.Size =
                new Size(Tabai.SelectedTab.Size.Width - 20, Tabai.SelectedTab.Size.Height - 20);
            picture.BackgroundImageLayout = ImageLayout.Stretch;
            foreach (Control item in Tabai.SelectedTab.Controls)
            {
                if (item is Button)
                {
                    Tabai.SelectedTab.Controls.Remove(item);
                }
            }
            Tabai.SelectedTab.Controls.Add(picture);
        }

        private void Tabai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tabai.SelectedTab == NewTab)
            {
                Tabai.TabPages.Remove(NewTab);
                TabPage tabpage = new TabPage();
                Button mygtukas = new Button();
                mygtukas.Text = button1.Text;
                mygtukas.Size = button1.Size;
                mygtukas.Location = button1.Location;
                mygtukas.Click += button1_Click;
                tabpage.Controls.Add(mygtukas);
                Tabai.TabPages.Add(tabpage);
                Tabai.TabPages.Add(NewTab);
                Tabai.SelectedTab = tabpage;
            }
        }
    }
}