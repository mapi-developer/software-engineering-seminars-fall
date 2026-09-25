namespace seminar_second
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // Calculate button handlers
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tbAnnualInterest.Text, out double principal) ||
                !double.TryParse(tbAnnualInterest.Text, out double annualRate) ||
                !int.TryParse(tbMonths.Text, out int months) ||
                principal <= 0 || annualRate < 0 || months <= 0)
            {
                MessageBox.Show("Please enter valid positive numbers.");
                return;
            }

            double loanAmount = double.Parse(tbLoanAmount.Text);
            double annualInterest = double.Parse(tbAnnualInterest.Text);
            int monthsAmount = int.Parse(tbMonths.Text);

            double r = annualInterest / 100.0 / 12.0;

            double monthlyPayment;
            
            if (r == 0)
            {
                monthlyPayment = loanAmount / monthsAmount;
            }
            else
            {
                monthlyPayment = loanAmount *
                                 (r * Math.Pow(1 + r, monthsAmount)) /
                                 (Math.Pow(1 + r, monthsAmount) - 1);
            }

            tbMonthlyPayment.Text = Math.Ceiling(monthlyPayment).ToString();
        }


        // Reset Button handlers
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbLoanAmount.Text = "";
            tbAnnualInterest.Text = "";
            tbMonths.Text = "";
            tbMonthlyPayment.Text = "";
        }

        // Text boxes handlers
        private void tbAny_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsControl(c) && !char.IsDigit(c) && (c != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbAny_TextChanged(object sender, EventArgs e)
        {
            if (sender is not TextBox tb)
                return;

            if (double.TryParse(tb.Text, out double x))
            {
                tb.BackColor = Color.LightBlue;
            }
            else
            {
                if (tb.Text.Length == 0)
                {
                    tb.BackColor = Color.White;
                }
                else
                {
                    tb.BackColor = Color.Salmon;
                }
            }
        }
    }
}