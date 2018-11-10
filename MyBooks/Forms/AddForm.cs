using MyBooks.Data;
using MyBooks.Entities;
using System;
using System.Windows.Forms;

namespace addForm.Forms
{
    public partial class DetailsForm : Form
    {
        private string Name { get { return nameTextBox.Text; } set { nameTextBox.Text = value; } }
        private string Author { get { return autorTextBox.Text; } set { autorTextBox.Text = value; } }
        private string Description { get { return descriptionTextBox.Text; } set { descriptionTextBox.Text = value; } }
        public DateTime DateStart { get { return dateStartPicker.Value; } set { dateStartPicker.Value = value; } }

        private readonly Book _entry;

        private readonly BookRepository _repository = new BookRepository();

        private void saveBookButton_Click(object sender, EventArgs e)
        {
            _entry.Name = Name;
            _entry.Description = Description;
            _entry.Author = Author;
            _entry.DateCreated = DateStart;
            _repository.Create(_entry);
        }
    }
}
