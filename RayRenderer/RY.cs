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
        public static Vector3 position = RY.Vector3(0.0f, 0.0f, -30.0f);

        public static float dist(Vector3 a, Vector3 b)
        {
            return (float)Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y) + (a.Z - b.Z) * (a.Z - b.Z));
        }
        public static Vector3 Vector3(float x, float y, float z)
        {
            return new Vector3(x, y, z);
        }
        public static void Side(Vector3 vector3,Graphics graphics)
        {
            graphics.TranslateTransform(vector3.X, vector3.Y);
            Point[] points = {new Point(300, 41),
    new Point(300, 1),///(int)position.Z
    new Point(315, 1+(int)RY.position.Z),
            new Point(315, 41-(int)RY.position.Z)};//[]
           graphics.FillPolygon(new SolidBrush(Color.BlueViolet), points);
            graphics.TranslateTransform(0, 0);
        }
        public static class shapes
        {
            public static void rectngularpyrism(Vector3 vector3, Size size, Graphics graphics)//,
            {



                graphics.TranslateTransform(vector3.X, vector3.Y);
            Point[] points = {new Point(300-size.Width, 41-size.Height),
    new Point(300-size.Width, 1-size.Height),///(int)position.Z
    new Point(315+size.Width, 1+size.Height),
            new Point(315+size.Width, 41)};//[]
            graphics.FillPolygon(new SolidBrush(Color.BlueViolet), points);
            graphics.TranslateTransform(0, 0);

            }
        }
    }
}
