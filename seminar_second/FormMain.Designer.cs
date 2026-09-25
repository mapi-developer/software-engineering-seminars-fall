namespace seminar_second
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalculate = new Button();
            labelMainTitle = new Label();
            tbLoanAmount = new TextBox();
            labelLoanAmount = new Label();
            tbAnnualInterest = new TextBox();
            tbMonths = new TextBox();
            tbMonthlyPayment = new TextBox();
            labelAnnualInterest = new Label();
            labelMonths = new Label();
            labelMonthlyPayment = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.White;
            btnCalculate.Location = new Point(506, 202);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 33);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // labelMainTitle
            // 
            labelMainTitle.AutoSize = true;
            labelMainTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelMainTitle.ForeColor = SystemColors.ControlText;
            labelMainTitle.Location = new Point(12, 9);
            labelMainTitle.Name = "labelMainTitle";
            labelMainTitle.Size = new Size(314, 54);
            labelMainTitle.TabIndex = 1;
            labelMainTitle.Text = "Loan Calculator";
            // 
            // tbLoanAmount
            // 
            tbLoanAmount.Location = new Point(48, 155);
            tbLoanAmount.Name = "tbLoanAmount";
            tbLoanAmount.Size = new Size(260, 31);
            tbLoanAmount.TabIndex = 2;
            tbLoanAmount.TextChanged += tbAny_TextChanged;
            tbLoanAmount.KeyPress += tbAny_KeyPress;
            // 
            // labelLoanAmount
            // 
            labelLoanAmount.AutoSize = true;
            labelLoanAmount.Font = new Font("Segoe UI", 12F);
            labelLoanAmount.Location = new Point(48, 120);
            labelLoanAmount.Name = "labelLoanAmount";
            labelLoanAmount.Size = new Size(197, 32);
            labelLoanAmount.TabIndex = 3;
            labelLoanAmount.Text = "Loan Amount ($):";
            // 
            // tbAnnualInterest
            // 
            tbAnnualInterest.Location = new Point(48, 237);
            tbAnnualInterest.Name = "tbAnnualInterest";
            tbAnnualInterest.Size = new Size(260, 31);
            tbAnnualInterest.TabIndex = 4;
            tbAnnualInterest.KeyPress += tbAny_KeyPress;
            // 
            // tbMonths
            // 
            tbMonths.Location = new Point(48, 321);
            tbMonths.Name = "tbMonths";
            tbMonths.Size = new Size(260, 31);
            tbMonths.TabIndex = 5;
            tbMonths.KeyPress += tbAny_KeyPress;
            // 
            // tbMonthlyPayment
            // 
            tbMonthlyPayment.BackColor = SystemColors.Info;
            tbMonthlyPayment.Enabled = false;
            tbMonthlyPayment.Location = new Point(386, 155);
            tbMonthlyPayment.Name = "tbMonthlyPayment";
            tbMonthlyPayment.Size = new Size(232, 31);
            tbMonthlyPayment.TabIndex = 6;
            // 
            // labelAnnualInterest
            // 
            labelAnnualInterest.AutoSize = true;
            labelAnnualInterest.Font = new Font("Segoe UI", 12F);
            labelAnnualInterest.Location = new Point(48, 202);
            labelAnnualInterest.Name = "labelAnnualInterest";
            labelAnnualInterest.Size = new Size(222, 32);
            labelAnnualInterest.TabIndex = 7;
            labelAnnualInterest.Text = "Annual interest (%):";
            // 
            // labelMonths
            // 
            labelMonths.AutoSize = true;
            labelMonths.Font = new Font("Segoe UI", 12F);
            labelMonths.Location = new Point(48, 286);
            labelMonths.Name = "labelMonths";
            labelMonths.Size = new Size(101, 32);
            labelMonths.TabIndex = 8;
            labelMonths.Text = "Months:";
            // 
            // labelMonthlyPayment
            // 
            labelMonthlyPayment.AutoSize = true;
            labelMonthlyPayment.Font = new Font("Segoe UI", 12F);
            labelMonthlyPayment.Location = new Point(386, 120);
            labelMonthlyPayment.Name = "labelMonthlyPayment";
            labelMonthlyPayment.Size = new Size(242, 32);
            labelMonthlyPayment.TabIndex = 9;
            labelMonthlyPayment.Text = "Monthly Payment ($):";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(196, 372);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 10;
            btnReset.Text = "reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(677, 494);
            Controls.Add(btnReset);
            Controls.Add(labelMonthlyPayment);
            Controls.Add(labelMonths);
            Controls.Add(labelAnnualInterest);
            Controls.Add(tbMonthlyPayment);
            Controls.Add(tbMonths);
            Controls.Add(tbAnnualInterest);
            Controls.Add(labelLoanAmount);
            Controls.Add(tbLoanAmount);
            Controls.Add(labelMainTitle);
            Controls.Add(btnCalculate);
            Name = "FormMain";
            Text = "Simple Loan Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label labelMainTitle;
        private TextBox tbLoanAmount;
        private Label labelLoanAmount;
        private TextBox tbAnnualInterest;
        private TextBox tbMonths;
        private TextBox tbMonthlyPayment;
        private Label labelAnnualInterest;
        private Label labelMonths;
        private Label labelMonthlyPayment;
        private Button btnReset;
    }
}