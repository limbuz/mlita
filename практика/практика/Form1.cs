using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика
{
    public partial class Form1 : Form
    {
        float rot1, rot2, rot3, rot4, rot5, rot6;
        int cnt, p = 255, t = 0, u = 255;
        List<PointF> points = new List<PointF>();
        SolidBrush brush = new SolidBrush(Color.White);
        SolidBrush sb = new SolidBrush(Color.FromArgb(150, 0, 0, 0));
        SolidBrush sb1 = new SolidBrush(Color.FromArgb(150, 255, 255, 255));

        private void timer3_Tick(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g1 = Graphics.FromImage(bmp);
            Graphics g2 = Graphics.FromImage(bmp);
            Graphics g3 = Graphics.FromImage(bmp);
            Graphics g4 = Graphics.FromImage(bmp);
            Graphics g5 = Graphics.FromImage(bmp);
            Graphics g6 = Graphics.FromImage(bmp);

            u--;
            t++;
            if (u == 0)
            {
                timer3.Stop();
                timer1.Start();
            }
            sb.Color = Color.FromArgb(150, u, u, u);
            sb1.Color = Color.FromArgb(150, t, t, t);
            animation();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Bitmap tbmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(tbmp);
            p--;
            if (p == 0)
            {
                timer2.Stop();
                timer3.Start();
            }
            brush.Color = Color.FromArgb(p, p, p);
            g.FillRectangle(brush, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
            pictureBox1.BackgroundImage = tbmp;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void polygon(Graphics gr, float rot, int vrt, int r, int a, SolidBrush solid)
        {
            var angle = Math.PI * 2 / vrt;
            for (int i = 0; i < vrt; i++)
            {
                points.Add(new PointF((float)Math.Sin(i * angle) * r, (float)Math.Cos(i * angle) * r));
            }
            gr.TranslateTransform((float)pictureBox1.Width / 4 * a, (float)pictureBox1.Height / 2);
            gr.RotateTransform(rot);
            gr.FillPolygon(solid, points.ToArray());
            points.Clear();
        }

        private void animation()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g1 = Graphics.FromImage(bmp);
            Graphics g2 = Graphics.FromImage(bmp);
            Graphics g3 = Graphics.FromImage(bmp);
            Graphics g4 = Graphics.FromImage(bmp);
            Graphics g5 = Graphics.FromImage(bmp);
            Graphics g6 = Graphics.FromImage(bmp);

            brush.Color = Color.White;
            g1.FillRectangle(brush, 0, 0, pictureBox1.Width / 2, pictureBox1.Height);
            brush.Color = Color.Black;
            g2.FillRectangle(brush, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);

            polygon(g1, -rot1, 5, 50, 1, sb);
            polygon(g2, rot2, 5, 50, 3, sb1);
            polygon(g3, -rot3, 6, 100, 1, sb);
            polygon(g4, rot4, 6, 100, 3, sb1);
            polygon(g5, -rot5, 8, 150, 1, sb);
            polygon(g6, rot6, 8, 150, 3, sb1);

            pictureBox1.BackgroundImage = bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt++;
            if (cnt == 3600) 
            {
                cnt = 0;
                rot1 = 0;
                rot2 = 0;
                rot3 = 0;
                rot4 = 0;
                rot5 = 0;
                rot6 = 0;
            }

            rot1 += 1.8f;
            rot2 += 0.8f;
            rot3 += 0.6f;
            rot4 += 0.4f;
            rot5++;
            rot6 += 1.5f;

            animation();
        }
    }
}
