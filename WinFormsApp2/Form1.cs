namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1, s2;
            double a, b, c;
            bool a1, b1;
            s1 = textBox1.Text;
            s2 = textBox2.Text;
            a1 = double.TryParse(s1, out a);
            b1 = double.TryParse(s2, out b);
            if (a1 & b1)
            {
                c = a * b;
                label5.Text = c.ToString();
                c *= 0.8;
                label6.Text = c.ToString();
            }
            else
            {
                label7.Text = "Неверный формат";
            }
        }
    }
}
