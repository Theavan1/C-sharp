namespace switch_case
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 169);
            button1.Name = "button1";
            button1.Size = new Size(134, 39);
            button1.TabIndex = 0;
            button1.Text = "ay getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 84);
            label1.Name = "label1";
            label1.Size = new Size(111, 26);
            label1.TabIndex = 1;
            label1.Text = "Ay sayısı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(72, 26);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(630, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 40);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(630, 186);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(543, 37);
            label3.Name = "label3";
            label3.Size = new Size(72, 26);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 96);
            label4.Name = "label4";
            label4.Size = new Size(73, 26);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(630, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 40);
            textBox2.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(630, 84);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 40);
            textBox4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(544, 154);
            label6.Name = "label6";
            label6.Size = new Size(72, 26);
            label6.TabIndex = 12;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 591);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("MV Boli", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label6;
    }
}