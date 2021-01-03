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
        public static Size screenSize;
        public static void initGraphics(Graphics graphic, Size size)
        {
            graphics = graphic;
            screenSize = size;
        }
        public static float perspectiveEffect(float x )
        {
            float check = RY.x_ * 0.8f ;
            float perspective = -80.0f - x;
            
            
            if (check >-80.0f - x)
            {
                perspective = check;

            }else
            {
                perspective = -80.0f-x;
            }
            // if()
            //Console.WriteLine(perspective);
            return perspective;
        
        }
        public static void Side(Vector3 vector3,Size size,Color color)
        {
            /*  Point[] points = {new Point(300, size.Height),
      new Point(300, 1),/////(int)position.Z
      new Point(315, 1),//+size.Height size.Height-
              new Point(315, size.Height)};//[]
              */
            
            int effect = 1 ;
            if (position.Z < 0)
            {
                effect = (int)RY.position.Z;
                //effect = 0;
            }
           
            Console.WriteLine(effect);
       
            PointF[] points = {    new PointF(1f,1f),
new PointF(1f,90f), new PointF(27f,90f+(int)RY.position.Z), new PointF(26f,2f-(int)RY.position.Z)};
            graphics.TranslateTransform(vector3.X, vector3.Y);//

            //81+
            graphics.FillPolygon(new SolidBrush(color), points);
            graphics.ResetTransform();
           // graphics.TranslateTransform(0, 0);
            //81+
        }
        public static class shapes
        {

            public static void rectngularpyrism(Vector3 vector3, Size rectsize,Color color)//,
            {

                float vec = dist(position, Vector3(0.0F, 0.0F, vector3.Z));
               
               
      
                Size size = new Size(rectsize.Width + (int)vec, rectsize.Height + (int)vec);//
                PointF[] points = {    new PointF(position.X-size.Width, 1f-position.Y-size.Height),
new PointF(position.X-size.Width, size.Height), new PointF(27f+size.Width, size.Height), new PointF(26f+size.Width, 2f-position.Y-size.Height)};

               // float vec = dist(position, vector3);//new RayRenderer.Vector3(0.0f,0.0f,-30.0f)
                //Side(RY.Vector3((int)vector3.X/2, (int)vector3.Y/2, (int)vector3.Z), new Size((int)vec, (int)vec / 8), Color.Purple);//graphics
                
                graphics.TranslateTransform(vector3.X + perspectiveEffect(vector3.X), vector3.Y);

                if (vec < -vector3.Z + 180+vec/3)
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
