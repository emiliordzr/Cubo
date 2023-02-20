using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubo
{
    public class Figure
    {
        public Figure(Vertice[] vertices, int[,] faces)
        {
            Vertices = vertices;
            Faces = faces;
        }

        public Vertice[] Vertices { get; set; }

        public int[,] Faces { get; set; }
    }
}
