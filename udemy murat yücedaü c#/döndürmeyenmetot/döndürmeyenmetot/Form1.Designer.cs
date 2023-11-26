namespace döndürmeyenmetot
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(108, 248);
            button1.Name = "button1";
            button1.Size = new Size(125, 49);
            button1.TabIndex = 0;
            button1.Text = "Temizle.";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 38);
            textBox1.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 38);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(108, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 38);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(108, 116);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 38);
            textBox5.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(91, 303);
            button2.Name = "button2";
            button2.Size = new Size(154, 49);
            button2.TabIndex = 6;
            button2.Text = "Renklendir.";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 553);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button2;
    }
}