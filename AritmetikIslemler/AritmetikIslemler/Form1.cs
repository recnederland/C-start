namespace AritmetikIslemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            double toplam;

            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);

            toplam = x + y;
            textBox3.Text = Convert.ToString(toplam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y, z;
            double cikarma;

            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);

            cikarma = x - y;
            textBox3.Text = Convert.ToString(cikarma);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, y, z;
            double carpma;

            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);

            carpma = x * y;
            textBox3.Text = Convert.ToString(carpma);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, y, z;
            double bolme;

            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);

            bolme = x / y;
            textBox3.Text = Convert.ToString(bolme);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x, y, z;
            double mod;

            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);

            mod = x % y;
            textBox3.Text = Convert.ToString(mod);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double x, y, z;
            double us;

            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);

            us = Math.Pow(x,y);
            textBox3.Text = Convert.ToString(us);
        }
    }
}