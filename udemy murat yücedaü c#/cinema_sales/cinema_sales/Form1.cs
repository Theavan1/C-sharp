namespace cinema_sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int �ay, su, bilet, m�s�r, toplam;
            �ay = Convert.ToInt16(Txtcay.Text);
            su = Convert.ToInt16(TxtSu.Text);
            m�s�r = Convert.ToInt16(TxtM�s�r.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            toplam = m�s�r * 120 + su * 20 + �ay * 50 + bilet * 100;
            Lbltoplam.Text = toplam.ToString() + " TL ";
            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + " TL ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            Txtcay.Text = "";
            TxtM�s�r.Text = "";
            TxtSu.Text = "";
            TxtM�s�r.Focus();

        }
    }
}