using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
   

    public partial class paint : Form
    {
        Graphics g;
        Pen pe;
        int x = -1;
        int y = -1;
        bool move;
        public paint()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            pe = new Pen(Color.Red, 3);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pe.Color = p.BackColor;
            
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move && x != -1 && y != -1)
            {
                g.DrawLine(pe, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            x = -1;
            y = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
