namespace WinFormsApp2
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
            components = new System.ComponentModel.Container();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            button3 = new Button();
            bindingSource1 = new BindingSource(components);
            textBox2 = new TextBox();
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ankara", "istanbul", "van", "adana", "mersin", "antalya", "izmir", "rize", "trakya" });
            comboBox1.Location = new Point(22, 23);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(22, 54);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(132, 22);
            button1.TabIndex = 1;
            button1.Text = "Şehir Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(557, 54);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(132, 22);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(560, 21);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(503, 26);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "Şehir:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "fenerbahçe", "galatasaray", "demirspor" });
            listBox1.Location = new Point(22, 179);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(132, 79);
            listBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(22, 272);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(131, 22);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 302);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 23);
            textBox2.TabIndex = 7;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(244, 27);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(229, 94);
            listBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 135);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 9;
            label2.Text = "İsim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 168);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 10;
            label3.Text = "Soyİsim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 200);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 11;
            label4.Text = "Meslek";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 230);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 12;
            label5.Text = "Maaş";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(335, 127);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(335, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(335, 192);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(335, 222);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 16;
            // 
            // button4
            // 
            button4.Location = new Point(268, 271);
            button4.Name = "button4";
            button4.Size = new Size(167, 23);
            button4.TabIndex = 17;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button4);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private ListBox listBox1;
        private Button button3;
        private BindingSource bindingSource1;
        private TextBox textBox2;
        private ListBox listBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button4;
    }
}