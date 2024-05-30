using System.Runtime.InteropServices;
using System.Windows.Forms;
using Handbook.Models;

namespace Handbook
{
    public partial class Form1 : Form
    {
        private PostalHandbook handbook;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            handbook = PostalHandbook.LoadData();
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
            PersonAddEditForm personAddForm = new PersonAddEditForm(handbook, null);
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

        private void editButton_Click(object sender, EventArgs e)
        {
            Person? person = GetSelectedPerson();
            if (person == null)
            {
                return;
            }
            PersonAddEditForm personEditForm = new PersonAddEditForm(handbook, person.Id);
            personEditForm.ShowDialog();
            searchButton_Click(null, null);
        }

        private Person? GetSelectedPerson()
        {
            if (resultsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Людина не обрана", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return resultsDataGridView.CurrentRow.DataBoundItem as Person;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Person? person = GetSelectedPerson();
            if (person == null)
            {
                return;
            }
            DialogResult result = MessageBox.Show($"Ви впенені, що хочете видалити {person.Name} {person.Surname}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                handbook.People.Remove(person);
                handbook.SaveData();
                searchButton_Click(null, null);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розробник програми: Бєлік Єгор. \nПрограма призначена для пошуку розташування людей, яких Ви додали до списку.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
