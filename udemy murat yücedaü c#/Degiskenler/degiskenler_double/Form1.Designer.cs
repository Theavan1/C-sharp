namespace degiskenler_double
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
            listBox1 = new ListBox();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 242);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(781, 67);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 22);
            label1.TabIndex = 1;
            label1.Text = "telefon modeli:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 29);
            textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(39, 434);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1120, 92);
            listBox1.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(208, 162);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(72, 29);
            textBox3.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 170);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 14;
            label3.Text = "telefon fiyatı:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 585);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private TextBox textBox3;
        private Label label3;
    }
}