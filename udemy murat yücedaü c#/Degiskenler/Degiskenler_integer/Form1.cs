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
            // convert = d�n��t�rme i�lemi / ToInt16-32-64 inti stringe �evirme 
            int say�1, say�2, toplam, �arp�m, fark, b�l�m;
            say�1 = Convert.ToInt32(textBox1.Text);
            say�2 = Convert.ToInt32(textBox2.Text);
            �arp�m = say�2 * say�1;
            toplam = say�1 + say�2;
            fark = say�2 - say�1;
            b�l�m = say�1 / say�2;
            MessageBox.Show("Toplam = " + toplam + "\n" + "Fark = " + fark + "\n" + "b�l�m = " + b�l�m + "\n" + "�arp�m = " + �arp�m);




        }
    }
}