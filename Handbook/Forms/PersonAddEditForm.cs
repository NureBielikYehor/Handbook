using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Handbook.Models;

namespace Handbook
{
    public partial class PersonAddEditForm : Form
    {
        private PostalHandbook Handbook;
        private int? EditId;
        public PersonAddEditForm(PostalHandbook handbook, int? editId)
        {
            InitializeComponent();
            Handbook = handbook;
            EditId = editId;
            Text = (editId != null ? "Редагування" : "Додавання") + " інформації про людину";
            okButton.Text = editId != null ? "Зберегти" : "Додати";
            if (EditId != null)
            {
                Person person = Handbook.People.Find(person => person.Id == EditId)!;
                nameTextBox.Text = person.Name;
                surnameTextBox.Text = person.Surname;
                countryTextBox.Text = person.Country;
                regionTextBox.Text = person.Region;
                districtTextBox.Text = person.District;
                settlementTextBox.Text = person.Settlement;
                postcodeTextBox.Text = person.Postcode;
            }
        }

        private void textBox_TextChanged(object? sender, EventArgs? e)
        {
            okButton.Enabled = nameTextBox.Text.Length != 0
                && surnameTextBox.Text.Length != 0
                && countryTextBox.Text.Length != 0
                && regionTextBox.Text.Length != 0
                && districtTextBox.Text.Length != 0
                && settlementTextBox.Text.Length != 0
                && postcodeTextBox.Text.Length != 0;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (EditId != null)
            {
                Person person = Handbook.People.Find(person => person.Id == EditId)!;
                person.Name = nameTextBox.Text;
                person.Surname = surnameTextBox.Text;
                person.Country = countryTextBox.Text;
                person.Region = regionTextBox.Text;
                person.District = districtTextBox.Text;
                person.Settlement = settlementTextBox.Text;
                person.Postcode = postcodeTextBox.Text;
            }
            else
            {
                int maxId = Handbook.People.Count == 0 ? 0 : Handbook.People.Max(person => person.Id);
                Person person = new Person(maxId + 1, nameTextBox.Text, surnameTextBox.Text, countryTextBox.Text, regionTextBox.Text, districtTextBox.Text, settlementTextBox.Text, postcodeTextBox.Text);
                Handbook.People.Add(person);
            }
            Handbook.SaveData();
            Close();
        }
       
        private void OnlyLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
    }
}
