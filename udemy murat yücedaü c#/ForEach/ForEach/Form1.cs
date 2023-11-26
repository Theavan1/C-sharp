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
            //string[] isimler = { "ali", "inanç", "yusuf", "mamL", "göko" };
            //foreach (string k in isimler) 
            //{
            //    listBox1.Items.Add(k);
            //}
            int toplam = 0;
            int[] sýnavlar = { 1, 2, 3, 34, 9, 12, 32 };
            foreach (int k in sýnavlar)
            {
                listBox1.Items.Add(k);
                toplam = toplam + k;
                
            }
            label1.Text = toplam.ToString();

        }
    }
}