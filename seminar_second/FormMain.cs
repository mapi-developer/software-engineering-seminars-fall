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
            decimal loanAmount = decimal.Parse(tbLoanAmount.Text);
            decimal monthlyInterest = decimal.Parse(tbAnnualInterest.Text);
            decimal monthlyPayment = decimal.Parse(tbMonths.Text);

            decimal remaining = loanAmount;
            decimal paid = 0;

            while (remaining > 0)
            {
                decimal interest = remaining * (monthlyInterest / 100);

                if (interest >= monthlyPayment)
                {
                    tbMonthlyPayment.Text = "Loan can't be covered";
                    return;
                }

                remaining += interest;

                if (remaining < monthlyPayment)
                {
                    monthlyPayment = remaining;
                }
                remaining -= monthlyPayment;

                paid += monthlyPayment;
            }

            tbMonthlyPayment.Text = Math.Ceiling(paid).ToString();
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
            System.Diagnostics.Debug.WriteLine(sender);
            if (double.TryParse(tbLoanAmount.Text, out double x))
            {
                tbLoanAmount.BackColor = Color.LightBlue;
            }
            else
            {
                if (tbLoanAmount.Text.Length == 0)
                {
                    tbLoanAmount.BackColor = Color.White;
                }
                else
                {
                    tbLoanAmount.BackColor = Color.Salmon;
                }
            }
        }
    }
}