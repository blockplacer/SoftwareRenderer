using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayRenderer
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        // public float dist(Vector3 vector3)
        //{ return (float)Math.Sqrt(((double)vector3.X*vector3.X) +((double) vector3.Y*vector3.Y)+Math.Sqrt((double)vector3.Z*vector3.Z)); }
       
        
        float x_ = 0.0f; 
        public float dist(Vector3 a, Vector3 b)
        {
            return (float)Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y) + (a.Z - b.Z) * (a.Z - b.Z));
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           float vec = dist(RY.position, RY.Vector3(0.0f, 0.0f, 30.0f));
            float vec_ = dist(RY.position, RY.Vector3(0.0f, 0.0f, 60.0f));
            
            if (vec_ < 130)
            {
                for (int xj = 0; xj <20f; xj++)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(xj,0,1,1)), new Rectangle(new Point(pictureBox1.Width / 2 + (int)x_ + 80, pictureBox1.Height / 2 + (int)RY.position.Y + xj), new Size((int)vec, (int)vec)));
                }
               
            }
            if (vec<130)
             e.Graphics.FillRectangle(new SolidBrush(Color.Cyan), new Rectangle(new Point(pictureBox1.Width / 2+(int)x_, pictureBox1.Height / 2+(int)RY.position.Y ), new Size((int)vec_, (int)vec_)));
            
            RY.Side(RY.Vector3(-300.0f, 0.0f, 0.1f),e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                RY.position.Z --;
            if (e.KeyCode == Keys.S)
                RY.position.Z ++;
            if (e.KeyCode == Keys.D)
                x_-=3;
            if (e.KeyCode == Keys.A)
                x_+=3;
        }
    }
}
