//https://www.youtube.com/watch?v=uWzPe_S-RVE
//Tobias Ondra 2022

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Doube_Pendulum
{
    public partial class Main_window : Form
    {
        Graphics panel_gr;
        Graphics path_gr;
        Pen path_pen;
        Pen pen;
        SolidBrush brush;
        Bitmap path;

        float y_offset = 150;
        float prev_x = -1;
        float prev_y = -1;

        double r1 = 150; //radius
        double r2 = 150;
        double m1 = 30; //mass
        double m2 = 30;
        double a1 = 1; //angle
        double a2 = 1.5;
        double a1_v = 0; //velocity
        double a2_v = 0;
        double a1_a = 0; //akcelerace
        double a2_a = 0;
        double g = 1; //gravity

        public Main_window()
        {
            InitializeComponent();
            panel_gr = panel1.CreateGraphics();
            path = new Bitmap(panel1.Width, panel1.Height);
            path_gr = Graphics.FromImage(path);
            path_gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 2);
            path_pen = new Pen(Color.Black, 1);
            brush = new SolidBrush(Color.Black);
        }

        private void Update(object sender, EventArgs e)
        {
            formula();
            a1_v += a1_a;
            a2_v += a2_a;
            a1 += a1_v;
            a2 += a2_v;
            Draw();
        }

        private void Draw() //Nakresleni kyvadel podle uhlu
        {
            Bitmap tmp = new Bitmap(panel1.Width, panel1.Height);
            Graphics gr = Graphics.FromImage(tmp);
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gr.Clear(Color.White);
            gr.DrawImage(path,0,0);
            float x1 = (float)r1 * (float)Math.Sin(a1);
            float y1 = (float)r1 * (float)Math.Cos(a1);
            float x2 = (float)r2 * (float)Math.Sin(a2);
            float y2 = (float)r2 * (float)Math.Cos(a2);
            gr.DrawLine(pen, panel1.Width/2, y_offset, panel1.Width / 2 + x1, y_offset + y1);
            gr.FillEllipse(brush, panel1.Width / 2 + x1 - (float)m1/2, y_offset + y1 - (float)m1 /2, (float)m1, (float)m1);
            gr.DrawLine(pen, panel1.Width / 2 + x1, y_offset + y1, panel1.Width / 2 + x2 + x1, y_offset + y1 +y2);
            gr.FillEllipse(brush, panel1.Width / 2 + x2 + x1 - (float)m2 /2, y_offset + y1 + y2 - (float)m2 /2, (float)m2, (float)m2);
            panel_gr.DrawImage(tmp,0,0);
            gr.Dispose();
            tmp.Dispose();

            var x = panel1.Width / 2 + x2 + x1;
            var y = y_offset + y1 + y2;
            if (prev_x != -1 && Timer.Enabled == true)
            {
                path_gr.DrawLine(path_pen, prev_x, prev_y, x, y);
            }

            prev_x = x;
            prev_y = y;
        }

        private void formula() //rovnice ktere nerozumim
        {
            var c1 = -g * (2 * m1 + m2) * Math.Sin(a1); //čitatel
            var c2 = -m2 * g * Math.Sin(a1 - 2 * a2);
            var c3 = -2 * Math.Sin(a1 - a2) * m2;
            var c4 = a2_v * a2_v * r2 + a1_v * a1_v * r1 * Math.Cos(a1 - a2);
            var j = r1 *(2 * m1 + m2 - m2 * Math.Cos(2 * a1 - 2 * a2)); //jmenovatel
            a1_a = (c1 + c2 + c3 * c4) / j;

            c1 = 2 * Math.Sin(a1 - a2);
            c2 = a1_v * a1_v * r1 * (m1 + m2);
            c3 = g * (m1 + m2) * Math.Cos(a1);
            c4 = a2_v * a2_v * r2 * m2 * Math.Cos(a1 - a2);
            j = r2 * (2 * m1 + m2 - m2 * Math.Cos(2 * a1 - 2 * a2));
            a2_a = (c1 * (c2+c3+c4) ) / j;
        }

        private void Start(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void Stop(object sender, EventArgs e)
        {
            Timer.Stop();
            path_gr.Clear(Color.White);
            Draw();
        }

        private void a1_change(object sender, EventArgs e)
        {
            a1 = (float)a1_slider.Value/100;
            Draw();
        }

        private void a2_change(object sender, EventArgs e)
        {
            a2 = (float)a2_slider.Value/100;
            Draw();
        }

        private void r2_change(object sender, EventArgs e)
        {
            r2 = r2_slider.Value;
            Draw();
        }

        private void r1_change(object sender, EventArgs e)
        {
            r1 = r1_slider.Value;
            Draw();
        }

        private void m1_change(object sender, EventArgs e)
        {
            m1 = m1_slider.Value;
            Draw();
        }

        private void m2_Change(object sender, EventArgs e)
        {
            m2 = m2_slider.Value;
            Draw();
        }

        private void Clear(object sender, EventArgs e)
        {
            path_gr.Clear(Color.White);
        }
    }
}
