namespace ALAN_HESABI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar = Convert.ToInt32(textBoxkenar.Text);
            int karealan = kenar * kenar;
            labelkarealan.Text = karealan.ToString();

            int kisakenar = Convert.ToInt32(textBoxk�sakenar.Text);
            int uzunkenar = Convert.ToInt32(textBoxuzunkenar.Text);
            int dikd�rtgenalan = kisakenar * uzunkenar;
            labeldikd�rtgenalan.Text = dikd�rtgenalan.ToString();

            int yaricap = Convert.ToInt32(textBoxyaricap.Text);
            int dairealan = (int)Math.PI * yaricap;
            labeldairealan.Text = dairealan.ToString();

        }
    }
}