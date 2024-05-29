using System.Runtime.InteropServices;

namespace Handbook
{
    public partial class Form1 : Form
    {
        private Handbook handbook;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            handbook = Handbook.LoadData();
            idNumericUpDown.Text = "";
            searchButton_Click(null, null);
        }

        private void searchButton_Click(object? sender, EventArgs? e)
        {
            int? id = null;
            if (idNumericUpDown.Text != "")
            {
                id = (int)idNumericUpDown.Value;
            }
            personBindingSource.DataSource = handbook.Search(id, nameTextBox.Text,
                surnameTextBox.Text, countryTextBox.Text, regionTextBox.Text,
                districtTextBox.Text, settlementTextBox.Text, postcodeTextBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PersonAddForm personAddForm = new PersonAddForm(handbook);
            personAddForm.ShowDialog();
            searchButton_Click(null, null);
        }

        private void OnlyLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void OnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
    }
}
