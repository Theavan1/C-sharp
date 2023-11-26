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
            double satýþ1, satýþ2;
            model = textBox1.Text;
            fiyat = Convert.ToInt16(textBox3.Text);
            satýþ1 = (0.8 * fiyat)+fiyat;
            satýþ2 = (1.2 * fiyat)+ fiyat;
            listBox1.Items.Add("telefon modeli = " + model + " fiyat = " + fiyat + " %8 vergili fiyat = " + satýþ1 + " %20 vergili fiyat = " + satýþ2);






        }
    }
}