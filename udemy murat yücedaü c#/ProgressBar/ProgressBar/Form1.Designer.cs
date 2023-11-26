namespace ProgressBar
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
            progressBar1 = new System.Windows.Forms.ProgressBar();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(142, 37);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(624, 143);
            progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(184, 239);
            button1.Name = "button1";
            button1.Size = new Size(159, 71);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(560, 239);
            button2.Name = "button2";
            button2.Size = new Size(129, 71);
            button2.TabIndex = 2;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 643);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private Button button1;
        private Button button2;
    }
}