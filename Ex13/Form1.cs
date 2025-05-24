namespace Ex13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Form1_Load(null, null);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TabPage tabPage1 = new TabPage("Tab 1");
            TabPage tabPage2 = new TabPage("Tab 2");
            Label label1 = new Label() { Text = "Content of Tab 1", Location = new Point(20, 20) };
            Label label2 = new Label() { Text = "Content of Tab 2", Location = new Point(20, 20) };
            tabPage1.Controls.Add(label1); 
            tabPage2.Controls.Add(label2); 
            tabControl1.TabPages.Add(tabPage1); 
            tabControl1.TabPages.Add(tabPage2);
        }
    }
}
