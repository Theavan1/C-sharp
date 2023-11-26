namespace Degisklenr_char
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char ders;
            ders = Convert.ToChar(textBox1.Text);
            label1.Text = ders.ToString();
        }
    }
}