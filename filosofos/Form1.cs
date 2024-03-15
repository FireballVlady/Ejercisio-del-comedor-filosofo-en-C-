using System.Reflection.Emit;
using System.Windows.Forms;

namespace filosofos
{
    public partial class Form1 : Form
    {
        

        public static int[] Palillos = new int[6];

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Activador_Click(object sender, EventArgs e)
        {
            Thread h1 = new Thread(Filosofo_1);
            Thread h2 = new Thread(Filosofo_2);
            Thread h3 = new Thread(Filosofo_3);
            Thread h4 = new Thread(Filosofo_4);
            Thread h5 = new Thread(Filosofo_5);

            h1.Start();
            h2.Start();
            h3.Start();
            h4.Start();
            h5.Start();

            Filosofo_1();
            Filosofo_2();
            Filosofo_3();
            Filosofo_4();
            Filosofo_5();

            Thread.Sleep(720);

            label9.Text = Palillos[1].ToString();
            label6.Text = Palillos[2].ToString();
            label8.Text = Palillos[3].ToString();
            label11.Text = Palillos[4].ToString();
            label10.Text = Palillos[5].ToString();


        }

        private void filosofo6_Click(object sender, EventArgs e)
        {
          
        }
        public static void Filosofo_1()
        {


            for (int i = 0; i < 2; i++)
            {
                Random myObject = new Random();
                int r = myObject.Next(1, 6);
                Palillos[r] = Palillos[r] + 1;

            }

        }

        public static void Filosofo_2()
        {


            for (int i = 0; i < 2; i++)
            {
                Random myObject = new Random();
                int r = myObject.Next(1, 6);
                Palillos[r] = Palillos[r] + 1;
            }


        }
        public static void Filosofo_3()
        {


            for (int i = 0; i < 2; i++)
            {
                Random myObject = new Random();
                int r = myObject.Next(1, 6);
                Palillos[r] = Palillos[r] + 1;
            }



        }
        public static void Filosofo_4()
        {


            for (int i = 0; i < 2; i++)
            {
                Random myObject = new Random();
                int r = myObject.Next(1, 6);
                Palillos[r] = Palillos[r] + 1;
            }



        }
        public static void Filosofo_5()
        {

            for (int i = 0; i < 2; i++)
            {
                Random myObject = new Random();
                int r = myObject.Next(1, 6);
                Palillos[r] = Palillos[r] + 1;
            }



        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}


