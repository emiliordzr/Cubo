using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubo
{
    public class Matriz
    {
        private static Matriz ins;
        public static Matriz Ins
        {
            get
            {
                if (ins == null)
                    ins = new Matriz();
                return ins;
            }
            set { ins = value; }
        }

        public PointF RotateZ(PointF a, float angle)
        {
            if (angle > 360)
                angle = 360;

            if (angle < -360)
                angle = 0;

            PointF c = new PointF();
            angle = angle / 57.2958f;

            c.X = (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            c.Y = (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));

            return c;
        }
        public PointF RotateY(PointF a, float angle)
        {
            if (angle > 360)
                angle = 360;

            if (angle < -360)
                angle = 0;

            PointF c = new PointF();
            angle = angle / 57.2958f;

            c.X = (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            c.Y = (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));

            return c;
        }
        public PointF RotateX(PointF a, float angle)
        {
            if (angle > 360)
                angle = 360;

            if (angle < -360)
                angle = 0;

            PointF c = new PointF();
            angle = angle / 57.2958f;

            c.X = (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            c.Y = (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));

            return c;
        }

    }
}
