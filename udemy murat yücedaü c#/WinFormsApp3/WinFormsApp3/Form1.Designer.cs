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
            groupBox1 = new GroupBox();
            label10 = new Label();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label8 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 263);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 199);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(244, 163);
            label10.Name = "label10";
            label10.Size = new Size(61, 21);
            label10.TabIndex = 12;
            label10.Text = "label10";
            label10.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Location = new Point(234, 40);
            button2.Name = "button2";
            button2.Size = new Size(118, 39);
            button2.TabIndex = 11;
            button2.Text = "Yön Değiştir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(100, 108);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(239, 29);
            dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 151);
            label5.Name = "label5";
            label5.Size = new Size(43, 21);
            label5.TabIndex = 9;
            label5.Text = "Saat:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(100, 143);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(113, 29);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ADANA", "2 ADIYAMAN", "3 AFYONKARAHİSAR", "4 AĞRI", "5 AKSARAY", "6 AMASYA", "7 ANKARA", "8 ANTALYA", "9 ARDAHAN", "10 ARTVİN", "11 AYDIN", "12 BALIKESİR", "13 BARTIN", "14 BATMAN", "15 BAYBURT", "16 BİLECİK", "17 BİNGÖL", "18 BİTLİS", "19 BOLU", "20 BURDUR", "21 BURSA", "22 ÇANAKKALE", "23 ÇANKIRI", "24 ÇORUM", "25 DENİZLİ", "26 DİYARBAKIR", "27 DÜZCE", "28 EDİRNE", "29 ELAZIĞ", "30 ERZİNCAN", "31 ERZURUM", "32 ESKİŞEHİR", "33 GAZİANTEP", "34 GİRESUN", "35 GÜMÜŞHANE", "36 HAKKARİ", "37 HATAY", "38 IĞDIR", "39 ISPARTA", "40 İSTANBUL", "41 İZMİR", "42 KAHRAMANMARAŞ", "43 KARABÜK", "44 KARAMAN", "45 KARS", "46 KASTAMONU", "47 KAYSERİ", "48 KIRIKKALE", "49 KIRKLARELİ", "50 KIRŞEHİR", "51 KİLİS", "52 KOCAELİ", "53 KONYA", "54 KÜTAHYA", "55 MALATYA", "56 MANİSA", "57 MARDİN", "58 MERSİN", "59 MUĞLA", "60 MUŞ", "61 NEVŞEHİR", "62 NİĞDE", "63 ORDU", "64 OSMANİYE", "65 RİZE", "66 SAKARYA", "67 SAMSUN", "68 SİİRT", "69 SİNOP", "70 SİVAS", "71 ŞANLIURFA", "72 ŞIRNAK", "73 TEKİRDAĞ", "74 TOKAT", "75 TRABZON", "76 TUNCELİ", "77 UŞAK", "78 VAN", "79 YALOVA", "80 YOZGAT", "81 ZONGULDAK" });
            comboBox2.Location = new Point(100, 69);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(113, 29);
            comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ADANA", "2 ADIYAMAN", "3 AFYONKARAHİSAR", "4 AĞRI", "5 AKSARAY", "6 AMASYA", "7 ANKARA", "8 ANTALYA", "9 ARDAHAN", "10 ARTVİN", "11 AYDIN", "12 BALIKESİR", "13 BARTIN", "14 BATMAN", "15 BAYBURT", "16 BİLECİK", "17 BİNGÖL", "18 BİTLİS", "19 BOLU", "20 BURDUR", "21 BURSA", "22 ÇANAKKALE", "23 ÇANKIRI", "24 ÇORUM", "25 DENİZLİ", "26 DİYARBAKIR", "27 DÜZCE", "28 EDİRNE", "29 ELAZIĞ", "30 ERZİNCAN", "31 ERZURUM", "32 ESKİŞEHİR", "33 GAZİANTEP", "34 GİRESUN", "35 GÜMÜŞHANE", "36 HAKKARİ", "37 HATAY", "38 IĞDIR", "39 ISPARTA", "40 İSTANBUL", "41 İZMİR", "42 KAHRAMANMARAŞ", "43 KARABÜK", "44 KARAMAN", "45 KARS", "46 KASTAMONU", "47 KAYSERİ", "48 KIRIKKALE", "49 KIRKLARELİ", "50 KIRŞEHİR", "51 KİLİS", "52 KOCAELİ", "53 KONYA", "54 KÜTAHYA", "55 MALATYA", "56 MANİSA", "57 MARDİN", "58 MERSİN", "59 MUĞLA", "60 MUŞ", "61 NEVŞEHİR", "62 NİĞDE", "63 ORDU", "64 OSMANİYE", "65 RİZE", "66 SAKARYA", "67 SAMSUN", "68 SİİRT", "69 SİNOP", "70 SİVAS", "71 ŞANLIURFA", "72 ŞIRNAK", "73 TEKİRDAĞ", "74 TOKAT", "75 TRABZON", "76 TUNCELİ", "77 UŞAK", "78 VAN", "79 YALOVA", "80 YOZGAT", "81 ZONGULDAK" });
            comboBox1.Location = new Point(100, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(113, 29);
            comboBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 116);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 5;
            label4.Text = "Tarih:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 77);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 4;
            label3.Text = "Nereye:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 3;
            label2.Text = "Nereden:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(486, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 199);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Location = new Point(122, 151);
            button1.Name = "button1";
            button1.Size = new Size(113, 30);
            button1.TabIndex = 13;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 116);
            label8.Name = "label8";
            label8.Size = new Size(62, 21);
            label8.TabIndex = 12;
            label8.Text = "Telefon:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(122, 108);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(113, 29);
            maskedTextBox3.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 29);
            textBox1.TabIndex = 10;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(122, 64);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(113, 29);
            maskedTextBox1.TabIndex = 9;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 72);
            label7.Name = "label7";
            label7.Size = new Size(30, 21);
            label7.TabIndex = 7;
            label7.Text = "TC:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 40);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 6;
            label6.Text = "Ad SoyAd:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(52, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 100);
            panel1.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(188, 26);
            label9.Name = "label9";
            label9.Size = new Size(369, 45);
            label9.TabIndex = 0;
            label9.Text = "TÜRK HAVA YOLLARI";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(43, 461);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(761, 109);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 565);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private MaskedTextBox maskedTextBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Label label8;
        private MaskedTextBox maskedTextBox3;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Label label9;
        private ListBox listBox1;
        private Button button2;
        private Label label10;
    }
}