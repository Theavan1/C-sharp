namespace ForEach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] isimler = { "ali", "inan�", "yusuf", "mamL", "g�ko" };
            //foreach (string k in isimler) 
            //{
            //    listBox1.Items.Add(k);
            //}
            int toplam = 0;
            int[] s�navlar = { 1, 2, 3, 34, 9, 12, 32 };
            foreach (int k in s�navlar)
            {
                listBox1.Items.Add(k);
                toplam = toplam + k;
                
            }
            label1.Text = toplam.ToString();

        }
    }
}