using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3dGraphLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int EarRadius = 90, NoseRadius = 15, HoleRadius = 33;
            float EarRad2 = EarRadius * 0.6f;
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            SolidBrush br_Black = new SolidBrush(Color.Black);
            SolidBrush br_Gray = new SolidBrush(Color.Gray);
            SolidBrush br_Pink = new SolidBrush(Color.Pink);

            //Мышь
            g.FillPolygon(br_Gray, new PointF[] {new PointF(115, 150), new PointF(220, 85), new PointF(250, 215)}); //Голова 1
            g.FillPolygon(br_Gray, new PointF[] { new PointF(123, 285), new PointF(190, 165), new PointF(230, 295) }); //Тело 1

            g.FillEllipse(br_Gray,115-EarRadius/2,150-EarRadius/2,EarRadius,EarRadius); //Ухо 1
            g.FillEllipse(br_Gray, 220 - EarRadius / 2, 85 - EarRadius / 2, EarRadius, EarRadius); //Ухо 2

            g.FillEllipse(br_Pink, 115 - EarRad2 / 2, 150 - EarRad2 / 2, EarRad2, EarRad2); //Ухо+ 1
            g.FillEllipse(br_Pink, 220 - EarRad2 / 2, 85 - EarRad2 / 2, EarRad2, EarRad2); //Ухо+ 2

            g.FillEllipse(br_Black, 250 - NoseRadius / 2, 215 - NoseRadius / 2, NoseRadius, NoseRadius); //Нос

            g.FillEllipse(new SolidBrush(Color.White), 180 - NoseRadius / 2, 165 - NoseRadius / 2, NoseRadius, NoseRadius);      //Глаз 1
            g.FillEllipse(br_Black, 180 - NoseRadius * 0.7f / 2, 165 - NoseRadius * 0.7f / 2, NoseRadius*0.7f, NoseRadius*0.7f);
            g.FillEllipse(new SolidBrush(Color.White), 220 - NoseRadius / 2, 140 - NoseRadius / 2, NoseRadius, NoseRadius);      //Глаз 2
            g.FillEllipse(br_Black, 220 - NoseRadius * 0.7f / 2, 140 - NoseRadius * 0.7f / 2, NoseRadius*0.7f, NoseRadius*0.7f);

            g.DrawLine(new Pen(Color.Black, 3), new PointF(264,170), new PointF(237,255)); //Усы
            g.DrawLine(new Pen(Color.Black, 3), new PointF(209, 211), new PointF(294, 225));  //Усы

            //Cыр
            g.FillPolygon(new SolidBrush(Color.Yellow), new[] { new PointF(438,40), new PointF(345, 255), new PointF(535, 275)}); //Перед
            g.FillPolygon(new SolidBrush(Color.Orange), new[] { new PointF(438, 40), new PointF(535, 275), new PointF(625,255)}); //Затенённая часть
            g.FillEllipse(new SolidBrush(Color.Orange), 410 - HoleRadius / 1, 215 - HoleRadius / 1, HoleRadius*2, HoleRadius*2);  //Отверстие 1
            g.FillEllipse(new SolidBrush(Color.Orange), 455 - HoleRadius / 2, 140 - HoleRadius / 2, HoleRadius, HoleRadius);      //Отверстие 2
            g.FillEllipse(new SolidBrush(Color.Orange), 515 - HoleRadius / 2, 230 - HoleRadius / 2, HoleRadius, HoleRadius);      //Отверстие 3
        }
    }
}
