namespace degiskenler_double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string model;
            int fiyat;
            double sat��1, sat��2;
            model = textBox1.Text;
            fiyat = Convert.ToInt16(textBox3.Text);
            sat��1 = (0.8 * fiyat)+fiyat;
            sat��2 = (1.2 * fiyat)+ fiyat;
            listBox1.Items.Add("telefon modeli = " + model + " fiyat = " + fiyat + " %8 vergili fiyat = " + sat��1 + " %20 vergili fiyat = " + sat��2);






        }
    }
}