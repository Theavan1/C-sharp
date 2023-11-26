using Microsoft.VisualBasic;

namespace Diziler
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

        
            //string[] kisiler = { "inanç","ahmet","nehir" };
            //label1.Text = kisiler[0];
            //int[] sayilar= { 1, 2, 3,5,5,2,6,7,9,2,67 };
            //label1.Text = sayilar[3].ToString();
            //double[] ondalýklý={1.2,2.5,5.6};
            //label1.Text = ondalýklý[0].ToString();

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string[] sehirler = { "eskiþehir", "ankara", "istanbul", "adana" };
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //}
            int[] sayi = { 1, 2, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, };
            for (int i = 0; i < sayi.Length; i++)
            {
                if (sayi[i] %2==0 && sayi[i]>10 )
                {
                    listBox1.Items.Add(sayi[i]);
                }
            }

        }
    }
}