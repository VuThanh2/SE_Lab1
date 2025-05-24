namespace Ex06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.form1_Load); // Make sure this is present
            this.addButton.Click += new System.EventHandler(this.addButton_Click); // Make sure this is present
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click); // Make sure this is present
        }
        private void form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Age";

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Options";
            comboBoxColumn.Items.AddRange("Option 1", "Option 2", "Option 3");
            dataGridView1.Columns.Add(comboBoxColumn);

            string[] row1 = new string[] { "1", "Ky-Trung Pham", "25" };
            string[] row2 = new string[] { "2", "Thai Ky Trung", "30" };
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { textBoxID.Text, textBoxName.Text, textBoxAge.Text };
            dataGridView1.Rows.Add(row);
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }
    }
}
