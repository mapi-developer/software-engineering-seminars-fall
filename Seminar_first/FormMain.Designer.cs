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
            btnClickMe = new Button();
            SuspendLayout();
            // 
            // btnClickMe
            // 
            btnClickMe.BackColor = Color.CadetBlue;
            btnClickMe.Location = new Point(269, 167);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(242, 109);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click me!";
            btnClickMe.UseVisualStyleBackColor = false;
            btnClickMe.Click += btnClickMe_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClickMe);
            Name = "FormMain";
            Text = "Form1";
            Click += btnClickMe_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClickMe;
    }
}
