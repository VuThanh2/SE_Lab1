using System.Windows.Forms;

namespace Ex14
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
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            ToolStripMenuItem openItem = new ToolStripMenuItem("Open");
            ToolStripMenuItem saveItem = new ToolStripMenuItem("Save");
            fileMenu.DropDownItems.Add(openItem);
            fileMenu.DropDownItems.Add(saveItem);
            menuStrip1.Items.Add(fileMenu);
        }
    }
}
