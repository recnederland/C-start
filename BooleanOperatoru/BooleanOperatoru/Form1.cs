namespace BooleanOperatoru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Operatorler ve BOOLEAN Veri Tipi:
        // ==  !=  >=  <=  && (ve)  || (veya)
        private void button1_Click(object sender, EventArgs e)
        {
            // Dogru: true
            // Yanlis: false
            int x = Convert.ToInt32(textBox1.Text);
            bool sonuc;
            if (sonuc = ((x < 8) || (x > 4))) ;
            label1.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 3;
            bool son;
            son = ((x == 8) || (x > 4));
            label2.Text = son.ToString();

            // ... boolean bagli if ile karar verelim
            if (son == true)
                label3.Text = "Sonuc Basarili";
            else
                label3.Text = "Sonuc basarisiz";
        }

    }
}