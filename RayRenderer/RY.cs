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
            graphics.ResetTransform();
        }
    }
}
