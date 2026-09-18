namespace Seminar_first
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
            decimal monthlyInterest = decimal.Parse(tbMonthlyInterest.Text);
            decimal monthlyPayment = decimal.Parse(tbMonthlyPayment.Text);

            decimal remaining = loanAmount;
            decimal paid = 0;

            while (remaining > 0)
            {
                decimal interest = remaining * (monthlyInterest / 100);

                if (interest >= monthlyPayment)
                {
                    tbTotalPayment.Text = "Loan can't be covered";
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

            tbTotalPayment.Text = Math.Ceiling(paid).ToString();
        }


        // Reset Button handlers
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbLoanAmount.Text = "";
            tbMonthlyInterest.Text = "";
            tbMonthlyPayment.Text = "";
            tbTotalPayment.Text = "";
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
    }
}
