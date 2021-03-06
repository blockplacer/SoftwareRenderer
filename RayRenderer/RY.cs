﻿using System;
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
        public static Vector3 position = RY.Vector3(0.0f, 0.0f,110.0F);// -3
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
        public static float perspectiveEffect(float x ,float y,bool mode)
        {
            float check = y * 0.8f ;
            if(mode == false)
            {
                float perspective = -80.0f - x;
            
            
            if (check >-30.0f - x)
            {
                perspective = check;

            }else
            {
                perspective = -30.0f-x;
            }
            // if()
            //Console.WriteLine(perspective);

            return perspective;
            }
            if(mode == true)
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

            public static void rectngularpyrism(Vector3 vector3,Size size,Color objectcol,bool mode) {
                for (int xj = 0; xj < 33; xj++)
                {
                    graphics.TranslateTransform(x_, position.Y);
                    Color col = Color.FromArgb(objectcol.A, objectcol.R, objectcol.G-(int)xj, objectcol.B-(int)xj);
                    if(mode == false)
                        rect(Vector3(vector3.X  + screenSize.Width / 2 , vector3.Y+screenSize.Height / 2, vector3.Z+xj), size, col,mode);
                    if(mode == true)
                        rect(Vector3(vector3.X + screenSize.Width / 2 , vector3.Y + screenSize.Height / 2, vector3.Z + xj), size, col, mode);
                    graphics.ResetTransform();
                }
            }
            public static void rect(Vector3 vector3, Size rectsize, Color color, bool mode)//,
            {

                float vec = dist(position, Vector3(0.0F, 0.0F, vector3.Z));// 
                
                

                Size size = new Size(rectsize.Width + (int)vec/(int)vec+1, rectsize.Height + (int)vec*(int)3.5f);//

                PointF[] points = {    new PointF(position.X-size.Width, 1f-position.Y-size.Height),
new PointF(position.X-size.Width, size.Height), new PointF(27f+size.Width, size.Height), new PointF(26f+size.Width, 2f-position.Y-size.Height)};

               // float vec = dist(position, vector3);//new RayRenderer.Vector3(0.0f,0.0f,-30.0f)
                //Side(RY.Vector3((int)vector3.X/2, (int)vector3.Y/2, (int)vector3.Z), new Size((int)vec, (int)vec / 8), Color.Purple);//graphics
                if(mode == true)
                    graphics.TranslateTransform(x_*30+vector3.X + perspectiveEffect(vector3.X, -x_, mode)  * -vec/10 * 3, vector3.Y - perspectiveEffect(vector3.Y, position.Y, mode) * vec);
                if (mode == false)
                graphics.TranslateTransform(vector3.X + perspectiveEffect(vector3.X, RY.x_, mode) * vec/10 * 3, vector3.Y+perspectiveEffect(vector3.Y,position.Y,mode)*vec);/////33
                //  

                if (vec < -vector3.Z + 180)//+vec
                    //////
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
