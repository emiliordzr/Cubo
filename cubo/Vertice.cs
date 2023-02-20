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
        public float X, Y, Z;
        public Vertice(float a, float b, float c)
        {
            X = a;
            Y = b;
            Z = c;
        }

        public Vertice RotateX(int angle)
        {
            float rad = (float)(angle * Math.PI / 180);
            float cos = (float)Math.Cos(rad);
            float sin = (float)Math.Sin(rad);
            float y = (Y * cos) - (Z * sin);
            float z = (Y * sin) + (Z * cos);
            return new Vertice(X, y, z);
        }
        public Vertice RotateY(int angle)
        {
            float rad = (float)(angle * Math.PI / 180);
            float cos = (float)Math.Cos(rad);
            float sin = (float)Math.Sin(rad);
            float z = (Z * cos) - (X * sin);
            float x = (Z * sin) + (X * cos);
            return new Vertice(x, Y, z);
        }

        public Vertice RotateZ(int angle)
        {
            float rad = (float)(angle * Math.PI / 180);
            float cos = (float)Math.Cos(rad);
            float sin = (float)Math.Sin(rad);
            float x = (X * cos) - (Y * sin);
            float y = (X * sin) + (Y * cos);
            return new Vertice(x, y, Z);
        }

        public Vertice Project(int viewWidth, int viewHeight, int fov, int viewDistance)
        {
            float factor = fov / (viewDistance + Z);
            float x = X * factor + viewWidth / 2;
            float y = Y * factor + viewHeight / 2;
            return new Vertice(x, y, 0);
        }
    }
}
