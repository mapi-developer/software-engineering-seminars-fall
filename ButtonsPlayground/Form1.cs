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

                Controls.Add(b);
            }
        }
    }
}
