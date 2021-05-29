using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            Bitmap picture = new Bitmap(PicBox.Width, PicBox.Height);

            //Олівці
            Pen pencil_1 = new Pen(Color.MediumVioletRed, 2);
            Pen pencil_2 = new Pen(Color.Red, 3);
            Pen pencil_3 = new Pen(Color.DarkRed, 5);

            //Силові балки
            Point radius_point1 = new Point(150, 50);
            Point radius_point2 = new Point(75, 75);
            Point radius_point3 = new Point(50, 150);
            Point radius_point4 = new Point(75, 225);
            Point radius_point5 = new Point(150, 250);
            Point radius_point6 = new Point(225, 225);
            Point radius_point7 = new Point(250, 150);
            Point radius_point8 = new Point(225, 75);
            Point centre_point = new Point(150, 150);
            Point[] RadiusPoints = {radius_point1, centre_point, radius_point2, centre_point, radius_point3,  centre_point, radius_point4,
            centre_point, radius_point5, centre_point, radius_point6, centre_point, radius_point7, centre_point, radius_point8, centre_point,};
            Graphics CentralFactening = Graphics.FromImage(picture);
            CentralFactening.DrawPolygon(pencil_1, RadiusPoints);

            //Круглий корпус
            Graphics circle = Graphics.FromImage(picture);
            circle.DrawEllipse(pencil_1, 50, 50, 200, 200);

            //Кабінки
            Graphics factening = Graphics.FromImage(picture);
            
            factening.DrawLine(pencil_2, 150, 50, 150, 75);
            factening.DrawLine(pencil_2, 125, 75, 175, 75);
            factening.DrawArc(pencil_2, 125, 50, 50, 50, 180, -180);

            factening.DrawLine(pencil_2, 75, 75, 75, 100);
            factening.DrawLine(pencil_2, 50, 100, 100, 100);
            factening.DrawArc(pencil_2, 50, 75, 50, 50, 180, -180);

            factening.DrawLine(pencil_2, 50, 150, 50, 175);
            factening.DrawLine(pencil_2, 25, 175, 75, 175);
            factening.DrawArc(pencil_2, 25, 150, 50, 50, 180, -180);

            factening.DrawLine(pencil_2, 75, 225, 75, 250);
            factening.DrawLine(pencil_2, 50, 250, 100, 250);
            factening.DrawArc(pencil_2, 50, 225, 50, 50, 180, -180);

            factening.DrawLine(pencil_2, 150, 250, 150, 275);
            factening.DrawLine(pencil_2, 125, 275, 175, 275);
            factening.DrawArc(pencil_2, 125, 250, 50, 50, 180, -180);

            factening.DrawLine(pencil_2, 225, 225, 225, 250);
            factening.DrawLine(pencil_2, 200, 250, 250, 250);
            factening.DrawArc(pencil_2, 200, 225, 50, 50, 180, -180);

            factening.DrawLine(pencil_2, 250, 150, 250, 175);
            factening.DrawLine(pencil_2, 225, 175, 275, 175);
            factening.DrawArc(pencil_2, 225, 150, 50, 50, 180, -180);

            factening.DrawLine(pencil_2, 225, 75, 225, 100);
            factening.DrawLine(pencil_2, 200, 100, 250, 100);
            factening.DrawArc(pencil_2, 200, 75, 50, 50, 180, -180);

            //Ніжки
            Graphics pillars = Graphics.FromImage(picture);

            pillars.DrawLine(pencil_3, 150, 150, 75, 375);
            pillars.DrawLine(pencil_3, 150, 150, 225, 375);
            pillars.DrawLine(pencil_3, 50, 375, 250, 375);

            PicBox.Image = picture;
        }
    }
}
