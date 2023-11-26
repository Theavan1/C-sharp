namespace Bilgi_Yarisması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, yanlis = 0, doğru = 0;
        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnsonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            lblsoruno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Son dünya kupasını hangi takım kazanmıştır?";
                btnA.Text = "Arjantin";
                btnB.Text = "Brezilya";
                btnC.Text = "Portekiz";
                btnD.Text = "Fransa";
                label4.Text = "Arjantin";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "cumriyet kaç yılında ilan eedilmiştir?";
                btnA.Text = "1923";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1920";
                label4.Text = "1923";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "hangi il ege bölgemizde bulunmaz?";
                btnA.Text = "balıkesir";
                btnB.Text = "izmir";
                btnC.Text = "manisa";
                btnD.Text = "aydın";
                label4.Text = "balıkesir";
                btnsonraki.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                    btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = false;
                MessageBox.Show("doğru sayınız = " + doğru +"\n"+ " yanlış sayınız = " + yanlis);

            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlış.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;
            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {

                yanlis++;
                lblyanlış.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;
            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {

                yanlis++;
                lblyanlış.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled= true;
            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {

                yanlis++;
                lblyanlış.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
    }
}