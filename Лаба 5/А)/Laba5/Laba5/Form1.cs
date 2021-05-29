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
            Pen pencil = new Pen(Color.MediumVioletRed, 3);

            //Сектор кола
            Graphics sector = Graphics.FromImage(picture);            
            sector.DrawArc(pencil, 70, 70, 400, 400, -45, -90);
            sector.DrawLine(pencil, 129, 129, 412, 129);

            //Ромб
            Point romb_point1 = new Point(750, 30);
            Point romb_point2 = new Point(650, 150);
            Point romb_point3 = new Point(750, 270);
            Point romb_point4 = new Point(850, 150);
            Point[] RombPoints = {romb_point1, romb_point2, romb_point3, romb_point4};
            Graphics romb = Graphics.FromImage(picture);
            romb.DrawPolygon(pencil, RombPoints);

            //Зафарбований паралелограм
            Point paralelogram_point1 = new Point(60, 400);
            Point paralelogram_point2 = new Point(200, 550);
            Point paralelogram_point3 = new Point(500, 550);
            Point paralelogram_point4 = new Point(360, 400);
            Point[] ParalelogramPoints = { paralelogram_point1, paralelogram_point2, paralelogram_point3, paralelogram_point4 };
            Graphics paralelogram = Graphics.FromImage(picture);
            SolidBrush brush = new SolidBrush(Color.RoyalBlue);
            paralelogram.FillPolygon(brush, ParalelogramPoints);
            Graphics paralelogram_frame = Graphics.FromImage(picture);
            paralelogram_frame.DrawPolygon(pencil, ParalelogramPoints);

            //Восьмикутник
            Point octagon_point1 = new Point(750, 350);
            Point octagon_point2 = new Point(675, 375);
            Point octagon_point3 = new Point(650, 450);
            Point octagon_point4 = new Point(675, 525);
            Point octagon_point5 = new Point(750, 550);
            Point octagon_point6 = new Point(825, 525);
            Point octagon_point7 = new Point(850, 450);
            Point octagon_point8 = new Point(825, 375);
            Point[] OctagonPoints = {octagon_point1, octagon_point2, octagon_point3, octagon_point4, 
                                      octagon_point5, octagon_point6, octagon_point7, octagon_point8};
            Graphics octagon = Graphics.FromImage(picture);
            octagon.DrawPolygon(pencil, OctagonPoints);

            PicBox.Image = picture;
        }
    }
}
