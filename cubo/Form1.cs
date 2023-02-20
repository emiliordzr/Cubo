using System.Numerics;

namespace cubo
{
    public partial class Form1 : Form
    {
        public Graphics g;
        Bitmap bmp;
        public Vertice[] vertices;
        public Scene scene;
        public int[,] faces;
        public int angle;
        public bool rotX, rotY, rotZ, rt;
        public Form1()
        {
            InitializeComponent();
            init();
            rotX = true;
            rotY = true;
            rotZ = true;
            scene = new Scene(new Figure(vertices, faces));
            pinta();
        }

        public void pinta()
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            scene.Draw(g, pictureBox1.Width, pictureBox1.Height, rotX, rotY, rotZ);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rotZ == false)
                rotZ = true;
            else if (rotZ == true)
                rotZ = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rotY == false)
                rotY = true;
            else if (rotY == true)
                rotY = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rotX && rotY && rotZ)
            {
                rotX = false;
                rotY = false;
                rotZ = false;
            }
            else if (!rotX && !rotY && !rotZ)
            {
                rotX = true;
                rotY = true;
                rotZ = true;
            }
            else
            {
                rotX = false;
                rotY = false;
                rotZ = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rotX == false)
                rotX = true;
            else if (rotX == true)
                rotX = false;
        }

        private void init()
        {
            vertices = new Vertice[]
            {
                new Vertice(-1, 1, -1),
                new Vertice(1, 1, -1),
                new Vertice(1, -1, -1),
                new Vertice  (-1, -1, -1),
                new Vertice(-1, 1, 1),
                new Vertice(1, 1, 1),
                new Vertice(1, -1, 1),
                new Vertice(-1, -1, 1)
            };

            faces = new int[,]
            {
                {
                    0, 1, 2, 3
                },
                {
                    1, 5, 6, 2
                },
                {
                    5, 4, 7, 6
                },
                {
                    4, 0, 3, 7
                },
                {
                    0, 4, 5, 1
                },
                {
                    3, 2, 6, 7
                }
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
            pinta();
            angle += 2;
        }
    }
}