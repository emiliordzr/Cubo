using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubo
{
    public class Figure
    {
        public Vertice[] Vertices;
        public int[,] Faces;
        public Figure(Vertice[] vertices, int[,] faces)
        {
            Vertices = vertices;
            Faces = faces;
        }

       
    }
}
