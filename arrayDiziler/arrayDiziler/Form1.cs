namespace arrayDiziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            double[] array1 = {2, 12, 24, 35, 47};
            
            richTextBox1.Text = array1[1].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // string[] ogrenciler = { "kazim", "kartal", "hulya", "turkmen" };
            int[] array = {2, 12, 24, 35, 47};
            for (int i = 0; i < array.Length; i++)
                // int i = 0;
                richTextBox1.Text = richTextBox1.Text + array[i] + "\n";         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] ogrenciler = { "kazim", "kartal", "hulya", "turkmen" };

            for(int i = 0; i < ogrenciler.Length; i++)
            {
                richTextBox1.Text = richTextBox1.Text + ogrenciler[i] + "\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] ogrenciler = { "kazim", "kartal", "hulya", "turkmen" };
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                comboBox1.Items.Add(ogrenciler[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = comboBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}