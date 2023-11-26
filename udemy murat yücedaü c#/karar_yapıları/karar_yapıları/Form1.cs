namespace karar_yapıları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sınav1, sınav2, sınav3, ortalma;
            string durum;
            sınav1 = Convert.ToDouble(textBox1.Text);
            sınav2 = Convert.ToDouble(textBox2.Text);
            sınav3 = Convert.ToDouble(textBox3.Text);
            ortalma = (sınav1 + sınav2 + sınav3) / 3;

            if (ortalma < 55)
            {
                durum = " kaldınız";

            }
            else
            {
                durum = " GEÇTİNİZ ";
            }
            textBox4.Text = durum + " / " + ortalma;



        }
    }
}