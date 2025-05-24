namespace Ex16
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
            ToolStripButton newButton = new ToolStripButton("New");
            ToolStripButton openButton = new ToolStripButton("Open");
            ToolStripButton saveButton = new ToolStripButton("Save");
            toolStrip1.Items.Add(newButton);
            toolStrip1.Items.Add(openButton);
            toolStrip1.Items.Add(saveButton);
        }
    }
}
