namespace Ex17
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
            ToolStripStatusLabel statusLabel = new ToolStripStatusLabel("Ready");
            statusStrip1.Items.Add(statusLabel);
        }
    }
}
