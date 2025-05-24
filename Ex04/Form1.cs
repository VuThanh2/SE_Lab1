namespace Ex04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Additions
        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 + num2;
            label1.Text = result.ToString();
        }

        // Subtractions
        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 - num2;
            label1.Text = result.ToString();
        }

        // Multiplications
        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 * num2;
            label1.Text = result.ToString();
        }

        // Divisions
        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 / num2;
            label1.Text = result.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
