namespace ButtonsSandbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button test_button = new();

            Controls.Add(test_button);
        }
    }
}
