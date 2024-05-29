namespace Handbook
{
    partial class PersonAddEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            nameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            okButton = new Button();
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(surnameTextBox);
            groupBox1.Controls.Add(okButton);
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
            groupBox1.Location = new Point(24, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 387);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(90, 59);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 15;
            label8.Text = "Ім'я";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(57, 97);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 13;
            label7.Text = "Прізвище";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(124, 55);
            nameTextBox.MaxLength = 50;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 23);
            nameTextBox.TabIndex = 0;
            nameTextBox.KeyPress += OnlyLetter_KeyPress;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(124, 93);
            surnameTextBox.MaxLength = 50;
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(250, 23);
            surnameTextBox.TabIndex = 1;
            surnameTextBox.KeyPress += OnlyLetter_KeyPress;
            // 
            // okButton
            // 
            okButton.ImeMode = ImeMode.NoControl;
            okButton.Location = new Point(299, 321);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 8;
            okButton.Text = "Додати";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(15, 287);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 9;
            label5.Text = "Поштовий індекс";
            // 
            // postcodeTextBox
            // 
            postcodeTextBox.Location = new Point(124, 283);
            postcodeTextBox.MaxLength = 5;
            postcodeTextBox.Name = "postcodeTextBox";
            postcodeTextBox.Size = new Size(250, 23);
            postcodeTextBox.TabIndex = 7;
            postcodeTextBox.KeyPress += OnlyDigit_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(16, 249);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 3;
            label2.Text = "Населений пункт";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(77, 211);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "Район";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(75, 135);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Країна";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(65, 173);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Область";
            // 
            // districtTextBox
            // 
            districtTextBox.Location = new Point(124, 207);
            districtTextBox.MaxLength = 50;
            districtTextBox.Name = "districtTextBox";
            districtTextBox.Size = new Size(250, 23);
            districtTextBox.TabIndex = 5;
            districtTextBox.KeyPress += OnlyLetter_KeyPress;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(124, 131);
            countryTextBox.MaxLength = 50;
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(250, 23);
            countryTextBox.TabIndex = 3;
            countryTextBox.KeyPress += OnlyLetter_KeyPress;
            // 
            // settlementTextBox
            // 
            settlementTextBox.Location = new Point(124, 245);
            settlementTextBox.MaxLength = 50;
            settlementTextBox.Name = "settlementTextBox";
            settlementTextBox.Size = new Size(250, 23);
            settlementTextBox.TabIndex = 6;
            settlementTextBox.KeyPress += OnlyLetter_KeyPress;
            // 
            // regionTextBox
            // 
            regionTextBox.Location = new Point(124, 169);
            regionTextBox.MaxLength = 50;
            regionTextBox.Name = "regionTextBox";
            regionTextBox.Size = new Size(250, 23);
            regionTextBox.TabIndex = 4;
            regionTextBox.KeyPress += OnlyLetter_KeyPress;
            // 
            // PersonAddEditForm
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 461);
            Controls.Add(groupBox1);
            MinimumSize = new Size(471, 500);
            Name = "PersonAddEditForm";
            Text = "PersonAddForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private TextBox nameTextBox;
        private TextBox surnameTextBox;
        private Button okButton;
        private Label label5;
        private TextBox postcodeTextBox;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label label3;
        private TextBox districtTextBox;
        private TextBox countryTextBox;
        private TextBox settlementTextBox;
        private TextBox regionTextBox;
    }
}