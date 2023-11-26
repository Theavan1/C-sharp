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
            int çay, su, bilet, mýsýr, toplam;
            çay = Convert.ToInt16(Txtcay.Text);
            su = Convert.ToInt16(TxtSu.Text);
            mýsýr = Convert.ToInt16(TxtMýsýr.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            toplam = mýsýr * 120 + su * 20 + çay * 50 + bilet * 100;
            Lbltoplam.Text = toplam.ToString() + " TL ";
            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + " TL ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            Txtcay.Text = "";
            TxtMýsýr.Text = "";
            TxtSu.Text = "";
            TxtMýsýr.Focus();

        }
    }
}