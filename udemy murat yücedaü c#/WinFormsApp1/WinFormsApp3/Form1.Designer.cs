namespace WinFormsApp3
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 37);
            label1.Name = "label1";
            label1.Size = new Size(33, 21);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 78);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "SoyAdı";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(114, 124);
            button1.Name = "button1";
            button1.Size = new Size(100, 31);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(34, 308);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(327, 130);
            listBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 37);
            label3.Name = "label3";
            label3.Size = new Size(28, 21);
            label3.TabIndex = 6;
            label3.Text = "TC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 83);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 7;
            label4.Text = "Telefon";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(366, 29);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 29);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(366, 75);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 29);
            maskedTextBox2.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(366, 126);
            button2.Name = "button2";
            button2.Size = new Size(100, 29);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "antalya ", "izmir", "adana", "istanbul", "mersin" });
            comboBox1.Location = new Point(675, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(601, 37);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 12;
            label5.Text = "Şehir";
            // 
            // button3
            // 
            button3.Location = new Point(675, 80);
            button3.Name = "button3";
            button3.Size = new Size(121, 35);
            button3.TabIndex = 13;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(613, 140);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 29);
            dateTimePicker1.TabIndex = 14;
            // 
            // button4
            // 
            button4.Location = new Point(613, 187);
            button4.Name = "button4";
            button4.Size = new Size(229, 29);
            button4.TabIndex = 15;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(891, 478);
            Controls.Add(button4);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Button button2;
        private ComboBox comboBox1;
        private Label label5;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private Button button4;
    }
}