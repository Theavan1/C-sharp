namespace switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt32(textBox1.Text);
            switch (ay)
            {
                case 1: label2.Text = "ocak"; break;
                case 2: label2.Text = "�ubat"; break;
                case 3: label2.Text = "mart"; break;
                case 4: label2.Text = "nisan"; break;
                case 5: label2.Text = "may�s"; break;
                case 6: label2.Text = "haziran"; break;
                case 7: label2.Text = "temmuz"; break;
                case 8: label2.Text = "a�ustos"; break;
                case 9: label2.Text = "eyl�l"; break;
                case 10: label2.Text = "ekim"; break;
                case 11: label2.Text = "kas�m"; break;
                case 12: label2.Text = "aral�k"; break;
                default: label2.Text = "hatal� ay"; break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int say�_1 = Convert.ToInt16(textBox1.Text), say�_2 = Convert.ToInt16(textBox2.Text), sonuc = Convert.ToInt16(textBox4.Text);
            switch (sonuc)
            {
                case 1:
                    textBox4.Text = (say�_1 + say�_2).ToString();
                    break;

                case 2:
                    textBox4.Text = (say�_1 - say�_2).ToString();
                    break;

                case 3:
                    textBox4.Text = (say�_1 / say�_2).ToString();
                    break;

                case 4:
                    textBox4.Text = (say�_1 * say�_2).ToString();
                    break;

                default:
                    textBox4.Text = "hata";
                    break;
            }
        }
    }
}