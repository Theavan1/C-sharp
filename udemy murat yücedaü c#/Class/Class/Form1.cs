namespace Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();
            rb.renk = "Mat siyah";
            rb.hýz = 320;
            rb.motor = 1.6;
            rb.fiyat = 2400000;
            rb.durum = 's';
            rb.YIL = 2023;
            rb.MARKA = "mercedes";
            rb.muayene = 2020;
            rb.AraçSahibi = "Ýzzettin Avan";
            rb.plaka = "01 ii 5313 ";
            label1.Text = rb.renk;
            label2.Text = rb.fiyat.ToString();
            label3.Text = rb.durum.ToString();
            label4.Text = rb.motor.ToString();
            label5.Text = rb.motor.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKA;
            label8.Text = rb.muayene.ToString();
            label9.Text = rb.plaka;
            label10.Text = rb.AraçSahibi;
            pictureBox1.BackColor = Color.AliceBlue;
        }
    }
}