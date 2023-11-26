namespace WinFormsApp4
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
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 62);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 35);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "mayonez";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(22, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(491, 326);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "sosolar";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 197);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 35);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "hardal";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 135);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(104, 35);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "ketçap";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(39, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 35);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "kadın";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(39, 88);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(89, 35);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "erkek";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(554, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 208);
            panel1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(554, 281);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(213, 120);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(1082, 602);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel1;
        private RichTextBox richTextBox1;
    }
}