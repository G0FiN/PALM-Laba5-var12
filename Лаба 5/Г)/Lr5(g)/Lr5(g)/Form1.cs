using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lr5_g_
{
    public partial class Form1 : Form
    {
        int step = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            picEarth.BackColor = Color.Transparent;
            picUFO.BackColor = Color.Transparent;
            picUFO.Image = Properties.Resources.ufo1;
            Random XY = new Random();
            int x = XY.Next(10, 1500);
            int y = XY.Next(10, 300);
            picUFO.Location = new Point(x, y);

            timer1.Enabled = true;
            timer1.Interval = 100;            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            step++;
            Point near_Earth = new Point(this.ClientSize.Width / 2 - 68, this.ClientSize.Height / 2 - 200);
            Point landing_point = new Point(this.ClientSize.Width / 2 - 68, this.ClientSize.Height / 2 - 89);

            if (step >= 35)
                picUFO.Image = Properties.Resources.ufo2;
            if (step > 20 && step < 35)
                picUFO.Location = new Point((this.picUFO.Location.X + near_Earth.X)/2, (this.picUFO.Location.Y + near_Earth.Y) / 2);            
            else if(step > 40)
                picUFO.Location = new Point((this.picUFO.Location.X + landing_point.X) / 2, (this.picUFO.Location.Y + landing_point.Y) / 2);
        }
    }
}
