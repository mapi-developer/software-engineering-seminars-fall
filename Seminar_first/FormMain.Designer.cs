namespace Seminar_first
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
            tbMonthlyInterest = new TextBox();
            tbMonthlyPayment = new TextBox();
            tbTotalPayment = new TextBox();
            labelMonthlyInterest = new Label();
            labelMonthlyPayment = new Label();
            label1 = new Label();
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
            labelMainTitle.Font = new Font("Segoe UI", 20F);
            labelMainTitle.Location = new Point(12, 9);
            labelMainTitle.Name = "labelMainTitle";
            labelMainTitle.Size = new Size(296, 54);
            labelMainTitle.TabIndex = 1;
            labelMainTitle.Text = "Loan Calculator";
            // 
            // tbLoanAmount
            // 
            tbLoanAmount.Location = new Point(48, 155);
            tbLoanAmount.Name = "tbLoanAmount";
            tbLoanAmount.Size = new Size(260, 31);
            tbLoanAmount.TabIndex = 2;
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
            // tbMonthlyInterest
            // 
            tbMonthlyInterest.Location = new Point(48, 237);
            tbMonthlyInterest.Name = "tbMonthlyInterest";
            tbMonthlyInterest.Size = new Size(260, 31);
            tbMonthlyInterest.TabIndex = 4;
            tbMonthlyInterest.KeyPress += tbAny_KeyPress;
            // 
            // tbMonthlyPayment
            // 
            tbMonthlyPayment.Location = new Point(48, 321);
            tbMonthlyPayment.Name = "tbMonthlyPayment";
            tbMonthlyPayment.Size = new Size(260, 31);
            tbMonthlyPayment.TabIndex = 5;
            tbMonthlyPayment.KeyPress += tbAny_KeyPress;
            // 
            // tbTotalPayment
            // 
            tbTotalPayment.BackColor = SystemColors.Info;
            tbTotalPayment.Enabled = false;
            tbTotalPayment.Location = new Point(386, 155);
            tbTotalPayment.Name = "tbTotalPayment";
            tbTotalPayment.Size = new Size(232, 31);
            tbTotalPayment.TabIndex = 6;
            // 
            // labelMonthlyInterest
            // 
            labelMonthlyInterest.AutoSize = true;
            labelMonthlyInterest.Font = new Font("Segoe UI", 12F);
            labelMonthlyInterest.Location = new Point(48, 202);
            labelMonthlyInterest.Name = "labelMonthlyInterest";
            labelMonthlyInterest.Size = new Size(237, 32);
            labelMonthlyInterest.TabIndex = 7;
            labelMonthlyInterest.Text = "Monthly interest (%):";
            // 
            // labelMonthlyPayment
            // 
            labelMonthlyPayment.AutoSize = true;
            labelMonthlyPayment.Font = new Font("Segoe UI", 12F);
            labelMonthlyPayment.Location = new Point(48, 286);
            labelMonthlyPayment.Name = "labelMonthlyPayment";
            labelMonthlyPayment.Size = new Size(242, 32);
            labelMonthlyPayment.TabIndex = 8;
            labelMonthlyPayment.Text = "Monthly Payment ($):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(386, 120);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 9;
            label1.Text = "Total Payment ($):";
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
            ClientSize = new Size(677, 494);
            Controls.Add(btnReset);
            Controls.Add(label1);
            Controls.Add(labelMonthlyPayment);
            Controls.Add(labelMonthlyInterest);
            Controls.Add(tbTotalPayment);
            Controls.Add(tbMonthlyPayment);
            Controls.Add(tbMonthlyInterest);
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
        private TextBox tbMonthlyInterest;
        private TextBox tbMonthlyPayment;
        private TextBox tbTotalPayment;
        private Label labelMonthlyInterest;
        private Label labelMonthlyPayment;
        private Label label1;
        private Button btnReset;
    }
}
