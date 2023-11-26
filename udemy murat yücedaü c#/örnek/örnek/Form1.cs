namespace örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet;
            double toplam;
            adet = Convert.ToInt16(textBox1.Text);
            if (0 < adet && adet <= 20)
            {
                toplam = (adet * 8) - (adet * 8 * 0.2);
                label2.Text = toplam.ToString();

            }
            if (adet > 21 && adet <= 40) 
            {
                toplam = (adet * 8) - (adet * 8 * 0.4);
                label2.Text = toplam.ToString();
            }
            else
            {
                toplam = (adet * 8) - (adet * 8 * 0.5);
                label2.Text = toplam.ToString();
            }
            
        }
    }
}