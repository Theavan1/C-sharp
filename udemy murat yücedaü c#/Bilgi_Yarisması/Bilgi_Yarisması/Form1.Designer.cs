namespace Bilgi_Yarisması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnD = new Button();
            btnC = new Button();
            btnsonraki = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblyanlış = new Label();
            lbldoğru = new Label();
            lblsoruno = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(473, 192);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Location = new Point(0, 188);
            btnA.Name = "btnA";
            btnA.Size = new Size(167, 39);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(215, 188);
            btnB.Name = "btnB";
            btnB.Size = new Size(186, 39);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(215, 260);
            btnD.Name = "btnD";
            btnD.Size = new Size(186, 39);
            btnD.TabIndex = 3;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(0, 260);
            btnC.Name = "btnC";
            btnC.Size = new Size(167, 39);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnsonraki
            // 
            btnsonraki.Location = new Point(577, 232);
            btnsonraki.Name = "btnsonraki";
            btnsonraki.Size = new Size(174, 43);
            btnsonraki.TabIndex = 5;
            btnsonraki.Text = "Sonraki";
            btnsonraki.UseVisualStyleBackColor = true;
            btnsonraki.Click += btnsonraki_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(613, 24);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 6;
            label1.Text = "Soru no:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(553, 165);
            label2.Name = "label2";
            label2.Size = new Size(146, 23);
            label2.TabIndex = 7;
            label2.Text = "Yanlış Sayısı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(558, 89);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 8;
            label3.Text = "Doğru sayısı:";
            // 
            // lblyanlış
            // 
            lblyanlış.AutoSize = true;
            lblyanlış.Location = new Point(737, 165);
            lblyanlış.Name = "lblyanlış";
            lblyanlış.Size = new Size(23, 23);
            lblyanlış.TabIndex = 9;
            lblyanlış.Text = "0";
            lblyanlış.Click += label4_Click;
            // 
            // lbldoğru
            // 
            lbldoğru.AutoSize = true;
            lbldoğru.Location = new Point(737, 89);
            lbldoğru.Name = "lbldoğru";
            lbldoğru.Size = new Size(23, 23);
            lbldoğru.TabIndex = 10;
            lbldoğru.Text = "0";
            // 
            // lblsoruno
            // 
            lblsoruno.AutoSize = true;
            lblsoruno.Location = new Point(737, 24);
            lblsoruno.Name = "lblsoruno";
            lblsoruno.Size = new Size(23, 23);
            lblsoruno.TabIndex = 11;
            lblsoruno.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 329);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(193, 329);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 426);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(737, 426);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 494);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblsoruno);
            Controls.Add(lbldoğru);
            Controls.Add(lblyanlış);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsonraki);
            Controls.Add(btnC);
            Controls.Add(btnD);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(6, 4, 6, 4);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnD;
        private Button btnC;
        private Button btnsonraki;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblyanlış;
        private Label lbldoğru;
        private Label lblsoruno;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}