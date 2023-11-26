namespace Degiskenler_integer
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 60);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 0;
            label1.Text = "sayı 1:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 36);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 107);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 2;
            label2.Text = "sayı 2:";
            // 
            // button1
            // 
            button1.Location = new Point(156, 149);
            button1.Name = "button1";
            button1.Size = new Size(125, 46);
            button1.TabIndex = 3;
            button1.Text = "hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 36);
            textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1200, 630);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Corbel", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private TextBox textBox2;
    }
}