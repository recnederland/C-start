namespace ConsoleOpen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Console ortaminda calismak icin Solution kisminda projemize sag tikliyoruz
            // Orada properties/ozellikle kisminda acilan kisimda projemizi console olarak guncelliyoruz
            Console.WriteLine("Test");
            // Backend kismini gormek icin solution kisminda C# Program.cs tiklanabilir
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + "'in karesi: " + x * x);
        }
    }
}