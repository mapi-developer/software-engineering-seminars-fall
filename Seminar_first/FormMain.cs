namespace Seminar_first
{
    public partial class FormMain : Form
    {
        private string btnTextClicked = "You're just clicked me !!!";
        private string btnTextMain = "Click Me!";

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            btnClickMe.Text = btnTextClicked;
        }

        private void btnClickMe_MouseLeave(object sender, EventArgs e)
        {
            btnClickMe.Text = btnTextMain;
        }
    }
}
