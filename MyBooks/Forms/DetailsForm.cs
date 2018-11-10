using MyBooks.Data;
using MyBooks.Entities;
using System;
using System.Windows.Forms;

namespace MyBooks.Forms
{
    public partial class DetailsForm : Form
    {
        private string BookName { get { return nameTextBox.Text; } set { nameTextBox.Text = value; } }
        private string Author { get { return autorTextBox.Text; } set { autorTextBox.Text = value; } }
        private string Description { get { return descriptionTextBox.Text; } set { descriptionTextBox.Text = value; } }
    
        public DetailsForm()
        {
            InitializeComponent();
        }

        private Book _entry;

        private readonly BookRepository _repository = new BookRepository();

        private void saveBookButton_Click(object sender, EventArgs e)
        {
            _entry = new Book();

            _entry.Name = BookName;
            _entry.Description = Description;
            _entry.Author = Author;
            _repository.Create(_entry);

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
