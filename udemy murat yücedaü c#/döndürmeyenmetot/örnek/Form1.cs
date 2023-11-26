using System.Security.Cryptography;

namespace örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kup(int sayi, int sayj)
        {

            int s3 = sayi + sayj;
            return s3;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            label1.Text = kup(s, s2).ToString();
        }
    }
}