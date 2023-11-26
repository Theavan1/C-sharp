namespace Degiskenler
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(439, 229);
            button1.Name = "button1";
            button1.Size = new Size(110, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 45);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "adsoyad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 90);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "meslek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 146);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "cinsiyet";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(142, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(142, 199);
            maskedTextBox1.Mask = "00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 206);
            label4.Name = "label4";
            label4.Size = new Size(30, 20);
            label4.TabIndex = 8;
            label4.Text = "yaş";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 282);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(537, 104);
            listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private ListBox listBox1;
    }
}