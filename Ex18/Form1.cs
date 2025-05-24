namespace Ex18
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
            Label label1 = new Label() { Text = "Panel 1", Dock = DockStyle.Fill };
            Label label2 = new Label() { Text = "Panel 2", Dock = DockStyle.Fill };
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(label2);
        }
    }
}
