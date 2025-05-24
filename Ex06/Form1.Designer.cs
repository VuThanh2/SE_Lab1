namespace Ex06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBoxID = new TextBox();
            textBoxName = new TextBox();
            textBoxAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addButton = new Button();
            deleteButton = new Button();
            comboBoxColumn = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(121, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.Size = new Size(595, 180);
            dataGridView1.TabIndex = 0;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(227, 242);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(169, 26);
            textBoxID.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(227, 287);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(169, 26);
            textBoxName.TabIndex = 2;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(227, 327);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(169, 26);
            textBoxAge.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 242);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 287);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 5;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 327);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 6;
            label3.Text = "Age:";
            // 
            // addButton
            // 
            addButton.Location = new Point(227, 390);
            addButton.Name = "addButton";
            addButton.Size = new Size(120, 28);
            addButton.TabIndex = 7;
            addButton.Text = "Add New Row";
            addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(428, 390);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(142, 28);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete Row";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // comboBoxColumn
            // 
            comboBoxColumn.FormattingEnabled = true;
            comboBoxColumn.Location = new Point(772, 28);
            comboBoxColumn.Name = "comboBoxColumn";
            comboBoxColumn.Size = new Size(145, 27);
            comboBoxColumn.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 450);
            Controls.Add(comboBoxColumn);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxName);
            Controls.Add(textBoxID);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private TextBox textBoxAge;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addButton;
        private Button deleteButton;
        private ComboBox comboBoxColumn;
    }
}
