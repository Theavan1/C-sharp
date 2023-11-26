namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat = 0, dakika = 0, saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label3.Text = saniye.ToString();
            if (saniye == 60)
            {
                saniye = 0;
                dakika += 1;
                label2.Text = dakika.ToString();
            }
            if (dakika == 3)
            {
                dakika = 0;
                saat += 1;
                label1.Text = saat.ToString();
            }

        }
    }
}