namespace Ex19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Button button1 = new Button() { Text = "Button 1" };
            Button button2 = new Button() { Text = "Button 2" };
            Button button3 = new Button() { Text = "Button 3" };
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
        }
    }
}
