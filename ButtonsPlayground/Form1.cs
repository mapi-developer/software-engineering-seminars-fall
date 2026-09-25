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

                b.Text = Factorial(i).ToString();

                Controls.Add(b);
            }
        }

        int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();

            int result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        int Fib(int n)
        {
            return (n < 2) ? n : Fib(n - 1) + Fib(n - 2);
        }

        private void buttonFib_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int FibEntry)) return;

            MessageBox.Show(Fib(FibEntry).ToString());
        }
    }
}
