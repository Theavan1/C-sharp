namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + " Uçuþ Tarih: " + textBox1.Text + " " + Text + dateTimePicker1.Text + " " + maskedTextBox2.Text + "Yolcu Bilgileri " + textBox1.Text + " " + maskedTextBox1.Text + " " + maskedTextBox3 + MessageBox.Show(" Yolcu kaydý yapýldý")





                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label10.Text;
        }
    }
}