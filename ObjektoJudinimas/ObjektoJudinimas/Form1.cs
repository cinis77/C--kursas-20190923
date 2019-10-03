using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjektoJudinimas
{
    public partial class Form1 : Form
    {
        private Control SelectedControl;
        private bool MouseIsDown;
        private Point OldPosition;

        public Form1()
        {
            InitializeComponent();
            MouseIsDown = false;
            JudinamaPanele.MouseDown += MouseDownPanele;
            JudinamaPanele.MouseMove += MouseMovePanel;
            JudinamaPanele.MouseUp += MouseUpPanel;
            this.KeyDown += KEyFormPress;
            OldPosition = new Point();
        }

        private void MouseDownPanele(object sender, EventArgs ev)
        {
            Control selectedItem = (Panel)sender;
            SelectedControl = selectedItem;
            OldPosition = selectedItem.Location;
            MouseIsDown = true;
        }

        private void MouseMovePanel(object sender, MouseEventArgs ev)
        {
            if (MouseIsDown)
            {
                SelectedControl.Location =
                    new Point(SelectedControl.Location.X - (OldPosition.X - ev.Location.X),
                    SelectedControl.Location.Y - (OldPosition.Y - ev.Location.Y));
                //OldPosition = SelectedControl.Location;
            }
        }

        private void MouseUpPanel(object sender, EventArgs ev)
        {
            OldPosition = SelectedControl.Location;
            MouseIsDown = false;
            SelectedControl = null;
        }

        private bool ControlPressed = false;

        private void KEyFormPress(object sender, KeyEventArgs ev)
        {
            if (ev.KeyCode == Keys.C && ev.Modifiers == Keys.Control)
            {
                Panel panele = new Panel();
                panele.Size = JudinamaPanele.Size;
                panele.Location = new Point(0, 0);
                panele.BackColor = Color.Black;
                panele.MouseDown += MouseDownPanele;
                panele.MouseMove += MouseMovePanel;
                panele.MouseUp += MouseUpPanel;
                Controls.Add(panele);
                ControlPressed = false;
            }
        }
    }
}