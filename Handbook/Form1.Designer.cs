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
            searchResultsListBox = new ListBox();
            personBindingSource = new BindingSource(components);
            addButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            detailsButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).BeginInit();
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
            idNumericUpDown.Name = "idNumericUpDown";
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
            postcodeTextBox.KeyPress += OnlyDigit_KeyPress;
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
            // searchResultsListBox
            // 
            resources.ApplyResources(searchResultsListBox, "searchResultsListBox");
            searchResultsListBox.DataSource = personBindingSource;
            searchResultsListBox.DisplayMember = "FullName";
            searchResultsListBox.FormattingEnabled = true;
            searchResultsListBox.Name = "searchResultsListBox";
            searchResultsListBox.ValueMember = "Id";
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Person);
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
            // 
            // editButton
            // 
            resources.ApplyResources(editButton, "editButton");
            editButton.Name = "editButton";
            editButton.UseVisualStyleBackColor = true;
            // 
            // detailsButton
            // 
            resources.ApplyResources(detailsButton, "detailsButton");
            detailsButton.Name = "detailsButton";
            detailsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(detailsButton);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(searchResultsListBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ResumeLayout(false);
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
        private ListBox searchResultsListBox;
        private Button addButton;
        private Button deleteButton;
        private Button editButton;
        private Button detailsButton;
        private Label label7;
        private TextBox surnameTextBox;
        private Label label8;
        private TextBox nameTextBox;
        private BindingSource personBindingSource;
    }
}
