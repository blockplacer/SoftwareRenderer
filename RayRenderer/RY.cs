using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayRenderer
{
    /* class RY
     {
     }*/
    public static class RY
    {
        public static Vector3 position = RY.Vector3(0.0f, 0.0f, -30.0f);
        public static float x_ = 0.0f;

        public static float dist(Vector3 a, Vector3 b)
        {
            return (float)Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y) + (a.Z - b.Z) * (a.Z - b.Z));
        }
        public static Vector3 Vector3(float x, float y, float z)
        {
            return new Vector3(x, y, z);
        }
        public static Graphics graphics;
        public static void initGraphics(Graphics graphic)
        {
            graphics = graphic;
        }
        public static void Side(Vector3 vector3,Size size,Color color)
        {
            graphics.TranslateTransform(vector3.X, vector3.Y);
            Point[] points = {new Point(300, size.Height),
    new Point(300, 1),/////(int)position.Z
    new Point(315, 1+(int)RY.position.Z),//+size.Height size.Height-
            new Point(315, size.Height-(int)RY.position.Z)};//[]
                                                            //81+
            graphics.FillPolygon(new SolidBrush(color), points);
            graphics.ResetTransform();
           // graphics.TranslateTransform(0, 0);
            //81+
        }
        public static class shapes
        {

            public static void rectngularpyrism(Vector3 vector3, Size size,Color color)//,
            {


                PointF[] points = {    new PointF(position.X-size.Width, 1f-position.Y-size.Height),
new PointF(position.X-size.Width, size.Height), new PointF(27f+size.Width, size.Height), new PointF(26f+size.Width, 2f-position.Y-size.Height)};

                float vec = dist(position, vector3);//new RayRenderer.Vector3(0.0f,0.0f,-30.0f)
                Side(RY.Vector3((int)vector3.X/2, (int)vector3.Y/2, (int)vector3.Z), new Size((int)vec, (int)vec / 3), Color.Purple);//graphics
                graphics.TranslateTransform(vector3.X, vector3.Y);

                
                graphics.FillPolygon(new SolidBrush(color), points);

                //  graphics.FillRectangle(new SolidBrush(Color.BlueViolet), new Rectangle(new Point((int)-vector3.X,(int)vector3.Y),size));//new Size()
                //  graphics.FillRectangle(new SolidBrush(Color.BlueViolet), new Rectangle(new Point((int)vector3.X, (int)vector3.Y), size));
                //  graphics.FillRectangle(new SolidBrush(Color.BlueViolet), new Rectangle(new Point(20+(int)vector3.X, (int)vector3.Y), size));
               
                //new Size()

                graphics.ResetTransform();
                // graphics.TranslateTransform(0, 0);
               
            }
        }
    }
}
