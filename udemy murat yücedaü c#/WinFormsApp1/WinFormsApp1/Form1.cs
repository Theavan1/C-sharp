namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("merhaba");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Ýzzet";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "Ýzzettin";
            label6.Text = "Avan";
            label8.Text = "Mühendis";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ben Bir Ayyaþým";
            label9.Text = textBox1.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Ali";
            label13.Text = textBox2.Text;
            textBox3.Text = "KARAHANLI";
            label14.Text = textBox3.Text;
            textBox4.Text = "BABA";
            label15.Text = textBox4.Text;
        }
    }
}