using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lr5_v_
{
    public partial class Form1 : Form
    {
        public Form1(){InitializeComponent();}
        Graphics img;
        Bitmap pic;
        Pen pen;
        Point centr = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
        int x = 10;
        int speed = 5;
        int size = 350;                

        private void Form1_Load(object sender, EventArgs e)
        {
            pen = new Pen(Color.LightSeaGreen, 15);
            WindowState = FormWindowState.Maximized;
            pic = new Bitmap(background.Width, background.Height);
            img = Graphics.FromImage(pic);
            timer1.Interval = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            x -= speed;           
            if (x <= -size || x >= size)            
                speed = -speed;

            img.Clear(Color.Gray);            
            img.DrawEllipse(pen, centr.X - size/2, centr.Y + x/2, size, x);

            background.Image = pic;
        }
    }
}
