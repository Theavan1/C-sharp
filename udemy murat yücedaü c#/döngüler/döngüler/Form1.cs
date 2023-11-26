namespace döngüler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // while ile do while arasındaki fark do while = şart sağlansın sağlanmasın en az 1 kere işlemi gerçekleştiriyor
            int i = 1;
            do
            {
                listBox1.Items.Add("merhaba güzellik");
                i++;
            }
            while (i<=10);
            {
           
            }
            
        }
    }
}