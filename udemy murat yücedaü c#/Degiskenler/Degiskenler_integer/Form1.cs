namespace Degiskenler_integer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // convert = dönüþtürme iþlemi / ToInt16-32-64 inti stringe çevirme 
            int sayý1, sayý2, toplam, çarpým, fark, bölüm;
            sayý1 = Convert.ToInt32(textBox1.Text);
            sayý2 = Convert.ToInt32(textBox2.Text);
            çarpým = sayý2 * sayý1;
            toplam = sayý1 + sayý2;
            fark = sayý2 - sayý1;
            bölüm = sayý1 / sayý2;
            MessageBox.Show("Toplam = " + toplam + "\n" + "Fark = " + fark + "\n" + "bölüm = " + bölüm + "\n" + "çarpým = " + çarpým);




        }
    }
}