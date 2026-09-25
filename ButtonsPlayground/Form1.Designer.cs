namespace ButtonsPlayground
{
    partial class Form1
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
            buttonFib = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonFib
            // 
            buttonFib.Location = new Point(271, 80);
            buttonFib.Name = "buttonFib";
            buttonFib.Size = new Size(315, 59);
            buttonFib.TabIndex = 0;
            buttonFib.Text = "Check Fib Number";
            buttonFib.UseVisualStyleBackColor = true;
            buttonFib.Click += buttonFib_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 31);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(buttonFib);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFib;
        private TextBox textBox1;
    }
}
