using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._5D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics   ;
           
            for (int xj = 0; xj < 33; xj++)
            {
                rect(Vector3(0.0f + pictureBox1.Width / 2, 0.0f + pictureBox1.Height / 2,  xj), new Size(1, 80), Color.FromArgb(255,0,255-xj,255-xj), false);
            }
            for (int xj = 0; xj < 33; xj++)
            {
                rect(Vector3(0.0f + pictureBox1.Width / 2, 0.0f + pictureBox1.Height / 2, 33+xj), new Size(1, 80), Color.FromArgb(255, 100+xj, 255 - xj, 255 - xj), false);
            }
            for (int xj = 0; xj < 33; xj++)
            {
                rect(Vector3(333.0f + pictureBox1.Width / 2, 0.0f + pictureBox1.Height / 2, 33 + xj), new Size(1, 10), Color.FromArgb(255, 100 - xj, 100 + xj, 100 + xj), false);
            }

        }

        public static Vector3 Vector3(float x, float y, float z)
        {
            return new Vector3(x, y, z);
        }
        public static Vector3 position = Vector3(0.0F, 0.0F, 100.0F);
        public static Graphics graphics;


        public static float perspectiveEffect(float x, float y, bool mode)
        {
            float check = y * 0.8f;
            if (mode == false)
            {
                float perspective = -80.0f - x;


                if (check > -30.0f - x)
                {
                    perspective = check;

                }
                else
                {
                    perspective = -30.0f - x;
                }
                // if()
                //Console.WriteLine(perspective);

                return perspective;
            }
            if (mode == true)
            {
                float perspective = 80.0f - x;


                if (check > 30.0f - x)
                {
                    perspective = check;

                }
                else
                {
                    perspective = -30.0f - x;
                }
                // if()
                //Console.WriteLine(perspective);

                return -perspective;

            }
            return 1.0f;
        }
        public static float vec_ = (float)Math.Sqrt(position.Z * position.Z + 80 * 80); ////////  
       
        public static void rect(Vector3 vector3, Size rectsize, Color color, bool mode)//,
        {



            float vec =vector3.Z+vec_+position.Z;

        graphics.TranslateTransform(vector3.X + perspectiveEffect(vector3.X, position.X, mode) * vec / 30* 3 + position.X * 10.0f, vector3.Y);
            Size size = new Size(rectsize.Width +(int)vec/3 , rectsize.Height + (int)vec/3);//

          

            PointF[] points = {    new PointF(position.X-size.Width, 1f-position.Y-size.Height),
new PointF(position.X-size.Width, size.Height), new PointF(27f+size.Width, size.Height), new PointF(26f+size.Width, 2f-position.Y-size.Height)};
            if(vec < vector3.Z+vec_+150)//+180
                graphics.FillPolygon(new SolidBrush(color), points);

            graphics.ResetTransform();


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Size = this.Size;
            pictureBox1.Location = new Point(1, 1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                position.Z--;

            if (e.KeyCode == Keys.S)
               position.Z++;

            if (e.KeyCode == Keys.D)
                position.X -= 3;
            if (e.KeyCode == Keys.A)
                position.X += 3;
            if (e.KeyCode == Keys.E)
                position.Y++;
        }
    }
}
