namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad = textBox1.Text;
            string meslek = textBox2.Text;
            string cinsiyet = textBox3.Text;
            string yas = maskedTextBox1.Text;
            listBox1.Items.Add(adsoyad+ " "+ meslek+ " "+ cinsiyet+" "+yas);
            


        }
    }
}