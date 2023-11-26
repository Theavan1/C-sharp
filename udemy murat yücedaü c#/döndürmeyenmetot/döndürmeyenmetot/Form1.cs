namespace döndürmeyenmetot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temzile()
        {
            textBox1.Text = "isim = izzettin avan";
            textBox5.Text = " meslek = yazılım mühendisi";
            textBox4.Text = "yaş = 21";
            textBox3.Text = "fenerbahçe";
            textBox1.Focus();
        }
        private void renklendir()
        {
            textBox1.BackColor = Color.Azure;
            textBox5.BackColor = Color.Aqua;
            textBox4.BackColor = Color.Bisque;
            textBox3.BackColor = Color.Gainsboro;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temzile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           renklendir();
        }
    }
}