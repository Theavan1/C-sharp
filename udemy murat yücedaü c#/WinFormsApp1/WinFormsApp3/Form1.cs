namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox1.Text + " " + maskedTextBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Text);
        }
    }
}