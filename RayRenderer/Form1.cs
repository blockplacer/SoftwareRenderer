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



        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           //float vec = RY.dist(RY.position, RY.Vector3(0.0f, 0.0f, 20.0f));
            //float vec_ = RY.dist(RY.position, RY.Vector3(0.0f, 0.0f, 30.0f)); //grdient object
            RY.initGraphics(e.Graphics,pictureBox1.Size);//

            //if (vec < 130)
            //{
            /* for (int xj = 0; xj <20f; xj++)
             {
                 e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(xj,0,1,1)), new Rectangle(new Point(pictureBox1.Width / 2 + (int)x_ + 80, pictureBox1.Height / 2 + (int)RY.position.Y + xj), new Size((int)vec, (int)vec)));
             }
             *///////////

            // RY.shapes.rectngularpyrism(RY.Vector3(pictureBox1.Width / 2 + (int)RY.x_ - 303 / RY.position.Z * 15, pictureBox1.Height / 2, -80.0f), new Size(0, 5), Color.Purple);
            // RY.shapes.rectngularpyrism(RY.Vector3(pictureBox1.Width / 2 + (int)RY.x_ + 303 / RY.position.Z * 15, pictureBox1.Height / 2, -80.0f), new Size(0, 5), Color.Orange);
            //// RY.shapes.rectngularpyrism(RY.Vector3(pictureBox1.Width / 2 + (int)RY.x_, pictureBox1.Height / 2, -30.0f), new Size(0, 10), Color.BlueViolet);//

            //pictureBox1.Width / 2 + (int),RY.x_pictureBox1.Height / 2,30

            // RY.shapes.rectngularpyrism(RY.Vector3(150, 0, 130), new Size(0, 5), Color.FromArgb(255, 0, 255, 100),true);
            //RY.shapes.rectngularpyrism(RY.Vector3(100 , 0 , 130 ),new Size(0, 5), Color.FromArgb(255,0, 255, 255 ),true);////// RY.position.Z * 15



            //   RY.shapes.rectngularpyrism(RY.Vector3(300, 0, 80), new Size(0, 5), Color.FromArgb(255, 0, 255, 100), true);
            
           // RY.shapes.rectngularpyrism(RY.Vector3(0, 0, 80), new Size(0, 5), Color.FromArgb(255, 0, 255, 255), false);
            //    RY.shapes.rectngularpyrism(RY.Vector3(300, 0, 100), new Size(0, 5), Color.FromArgb(255, 0, 255, 100), true);
            
           // RY.shapes.rectngularpyrism(RY.Vector3(0, 0, 100), new Size(0, 5), Color.FromArgb(255, 0, 255, 255), false);
            RY.shapes.rectngularpyrism(RY.Vector3(0, -100, 100), new Size(0, 5), Color.FromArgb(255, 0, 255, 255), false);
            /*RY.shapes.rectngularpyrism(RY.Vector3(300, 0, 50), new Size(0, 5), Color.FromArgb(255, 0, 100, 255), true);
            RY.shapes.rectngularpyrism(RY.Vector3(0, 0, 50), new Size(0, 5), Color.FromArgb(255, 255, 255, 255), false);
            RY.shapes.rectngularpyrism(RY.Vector3(0, 0, 70), new Size(10, 10), Color.FromArgb(255, 255, 255, 255), false);
            RY.shapes.rectngularpyrism(RY.Vector3(0, 50, 1), new Size(10, 10), Color.FromArgb(255, 255, 100, 255), false);*/
           // Console.WriteLine(RY.position.Z);
            // RY.Side
            //  e.Graphics.FillRectangle(new SolidBrush(Color.Purple), new Rectangle(new Point(pictureBox1.Width / 2+(int)x_+80, pictureBox1.Height / 2+(int) RY.position.Y), new Size((int)vec, (int)vec)));
            // }


            // if (perspective  30)
            //  {

            //perspective -= 0.1f;
            // }
            //perspective = ;
            // Console.WriteLine(perspective); 
            //  if (vec_ < 130)//
            //   RY.shapes.rectngularpyrism(RY.Vector3(pictureBox1.Width / 2 + (int)RY.x_+30+ RY.perspectiveEffect(), pictureBox1.Height / 2, -20.0f), new Size((int)vec_, (int)vec_+10 ), Color.Orange);//+ 10
            //// RY.Side(RY.Vector3(pictureBox1.Width/2+(int)RY.x_,pictureBox1.Height/2 , -30.0f), new Size((int)vec_, (int)vec_ + 10), Color.Purple);
            // e.Graphics.FillRectangle(new SolidBrush(Color.Cyan), new Rectangle(new Point(pictureBox1.Width / 2+(int)x_, pictureBox1.Height / 2+(int)RY.position.Y ), new Size((int)vec_, (int)vec_)));


            //RY.Side(RY.Vector3(-300.0f, 0.0f, 0.1f),e.Graphics);//
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                RY.position.Z--;

            if (e.KeyCode == Keys.S)
                    RY.position.Z++;
            
            if (e.KeyCode == Keys.D)
                RY.x_-=3;
            if (e.KeyCode == Keys.A)
                RY.x_+=3;
            if (e.KeyCode == Keys.E)
                RY.position.Y++;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Size = this.Size;
        }
    }
}
