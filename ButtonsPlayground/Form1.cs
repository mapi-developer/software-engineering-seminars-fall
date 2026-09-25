using System.Numerics;

namespace ButtonsPlayground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Button b = new();
                b.Left = 0;
                b.Top = i * 30;
                b.Height = 30;
                b.Width = 100;

                b.Text = Fibonacci(i).ToString();

                Controls.Add(b);
            }
        }

        int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();

            int result = 1;

            for (int i = 2; i <= number;i++)
            {
                result *= i;
            }

            return result;
        }

        int Fibonacci(int number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;

            int a = 0;
            int b = 1;

            for (int i = 2; i <= number; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }


            return b;
        }
    }
}
