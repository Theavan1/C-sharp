namespace Timer_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            sayac++;
            label1.Text = sayac.ToString();
            if (sayac ==1)
            {
                
                this.BackColor = Color.Red;
            }
            if (sayac ==30)
            {
                this.BackColor = Color.Yellow;
            }
            if(sayac ==40)
            {
                this.BackColor = Color.Green;

            }
            if((sayac ==60))
            {
                sayac = 0;
            }
           
            
            



        }
    }
}