using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace cubo
{
    public class Vertice
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public Vertice(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vertice RotateX(int angle)
        {
            float rad = (float)(angle * Math.PI / 180);
            float cos = (float)Math.Cos(rad);
            float sin = (float)Math.Sin(rad);
            float yn = (Y * cos) - (Z * sin);
            float zn = (Y * sin) + (Z * cos);
            return new Vertice(X, yn, zn);
        }
        public Vertice RotateY(int angle)
        {
            float rad = (float)(angle * Math.PI / 180);
            float cos = (float)Math.Cos(rad);
            float sin = (float)Math.Sin(rad);
            float Zn = (Z * cos) - (X * sin);
            float Xn = (Z * sin) + (X * cos);
            return new Vertice(Xn, Y, Zn);
        }

        public Vertice RotateZ(int angle)
        {
            float rad = (float)(angle * Math.PI / 180);
            float cos = (float)Math.Cos(rad);
            float sin = (float)Math.Sin(rad);
            float Xn = (X * cos) - (Y * sin);
            float Yn = (X * sin) + (Y * cos);
            return new Vertice(Xn, Yn, Z);
        }

        public Vertice Project(int viewWidth, int viewHeight, int fov, int viewDistance)
        {
            float factor = fov / (viewDistance + Z);
            float Xn = X * factor + viewWidth / 2;
            float Yn = Y * factor + viewHeight / 2;
            return new Vertice(Xn, Yn, 0);
        }
    }
}
