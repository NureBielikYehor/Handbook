namespace Handbook
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            nameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            label6 = new Label();
            idNumericUpDown = new NumericUpDown();
            searchButton = new Button();
            label5 = new Label();
            postcodeTextBox = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            districtTextBox = new TextBox();
            countryTextBox = new TextBox();
            settlementTextBox = new TextBox();
            regionTextBox = new TextBox();
            addButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            операціїToolStripMenuItem = new ToolStripMenuItem();
            додатиToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            resultsDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            personBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(surnameTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(idNumericUpDown);
            groupBox1.Controls.Add(searchButton);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(postcodeTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(districtTextBox);
            groupBox1.Controls.Add(countryTextBox);
            groupBox1.Controls.Add(settlementTextBox);
            groupBox1.Controls.Add(regionTextBox);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(nameTextBox, "nameTextBox");
            nameTextBox.Name = "nameTextBox";
            nameTextBox.KeyPress += OnlyLetter_KeyPress;
            // 
            // surnameTextBox
            // 
            resources.ApplyResources(surnameTextBox, "surnameTextBox");
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.KeyPress += OnlyLetter_KeyPress;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // idNumericUpDown
            // 
            resources.ApplyResources(idNumericUpDown, "idNumericUpDown");
            idNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            idNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            idNumericUpDown.Name = "idNumericUpDown";
            idNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // searchButton
            // 
            resources.ApplyResources(searchButton, "searchButton");
            searchButton.Name = "searchButton";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // postcodeTextBox
            // 
            resources.ApplyResources(postcodeTextBox, "postcodeTextBox");
            postcodeTextBox.Name = "postcodeTextBox";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // districtTextBox
            // 
            resources.ApplyResources(districtTextBox, "districtTextBox");
            districtTextBox.Name = "districtTextBox";
            districtTextBox.KeyPress += OnlyLetter_KeyPress;
            // 
            // countryTextBox
            // 
            resources.ApplyResources(countryTextBox, "countryTextBox");
            countryTextBox.Name = "countryTextBox";
            countryTextBox.KeyPress += OnlyLetter_KeyPress;
            // 
            // settlementTextBox
            // 
            resources.ApplyResources(settlementTextBox, "settlementTextBox");
            settlementTextBox.Name = "settlementTextBox";
            settlementTextBox.KeyPress += OnlyLetter_KeyPress;
            // 
            // regionTextBox
            // 
            resources.ApplyResources(regionTextBox, "regionTextBox");
            regionTextBox.Name = "regionTextBox";
            regionTextBox.KeyPress += OnlyLetter_KeyPress;
            // 
            // addButton
            // 
            resources.ApplyResources(addButton, "addButton");
            addButton.Name = "addButton";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            resources.ApplyResources(deleteButton, "deleteButton");
            deleteButton.Name = "deleteButton";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            resources.ApplyResources(editButton, "editButton");
            editButton.Name = "editButton";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, операціїToolStripMenuItem, helpToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(файлToolStripMenuItem, "файлToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(exitToolStripMenuItem, "exitToolStripMenuItem");
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // операціїToolStripMenuItem
            // 
            операціїToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { додатиToolStripMenuItem, deleteToolStripMenuItem, editToolStripMenuItem });
            операціїToolStripMenuItem.Name = "операціїToolStripMenuItem";
            resources.ApplyResources(операціїToolStripMenuItem, "операціїToolStripMenuItem");
            // 
            // додатиToolStripMenuItem
            // 
            додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            resources.ApplyResources(додатиToolStripMenuItem, "додатиToolStripMenuItem");
            додатиToolStripMenuItem.Click += addButton_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(deleteToolStripMenuItem, "deleteToolStripMenuItem");
            deleteToolStripMenuItem.Click += deleteButton_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(editToolStripMenuItem, "editToolStripMenuItem");
            editToolStripMenuItem.Click += editButton_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(aboutToolStripMenuItem, "aboutToolStripMenuItem");
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.AllowUserToAddRows = false;
            resultsDataGridView.AllowUserToDeleteRows = false;
            resources.ApplyResources(resultsDataGridView, "resultsDataGridView");
            resultsDataGridView.AutoGenerateColumns = false;
            resultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            resultsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            resultsDataGridView.BackgroundColor = SystemColors.ButtonFace;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            resultsDataGridView.DataSource = personBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            resultsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            resultsDataGridView.MultiSelect = false;
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            resultsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resultsDataGridView.RowHeadersVisible = false;
            resultsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            resources.ApplyResources(dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Surname";
            resources.ApplyResources(dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            resources.ApplyResources(dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Country";
            resources.ApplyResources(dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Region";
            resources.ApplyResources(dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "District";
            resources.ApplyResources(dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Settlement";
            resources.ApplyResources(dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Postcode";
            resources.ApplyResources(dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Models.Person);
            // 
            // Form1
            // 
            AcceptButton = searchButton;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(resultsDataGridView);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox districtTextBox;
        private TextBox countryTextBox;
        private TextBox settlementTextBox;
        private TextBox regionTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox postcodeTextBox;
        private Label label6;
        private NumericUpDown idNumericUpDown;
        private Button searchButton;
        private Button addButton;
        private Button deleteButton;
        private Button editButton;
        private Label label7;
        private TextBox surnameTextBox;
        private Label label8;
        private TextBox nameTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem операціїToolStripMenuItem;
        private ToolStripMenuItem додатиToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn settlementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postcodeDataGridViewTextBoxColumn;
        private DataGridView resultsDataGridView;
        private BindingSource personBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
