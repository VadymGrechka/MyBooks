using MyBooks.Data;
using MyBooks.Entities;
using MyBooks.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBooks
{
    public partial class MainForm : Form
    {
        private BookRepository bookRepository = new BookRepository();

        public MainForm()
        {
            InitializeComponent();
            GetAndDrawBooks();
        }

        private void DrawBooks(IEnumerable<Book> books)
        {
            booksListView.Items.Clear();

            foreach (var item in books)
            {
                var viewItem = booksListView.Items.Add(item.Name);
                viewItem.SubItems.Add(item.Author);
                viewItem.SubItems.Add(item.Description);
                viewItem.SubItems.Add(item.DateCreated.ToShortDateString());
                viewItem.Tag = item.Id;
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            DetailsForm addBookForm = new DetailsForm();
            if (addBookForm.ShowDialog() == DialogResult.OK)
                GetAndDrawBooks();
        }


        private void GetAndDrawBooks()
        {
            var books = bookRepository.GetAll();
            DrawBooks(books);
        }

        private void deleteBookMenuItem_Click(object sender, EventArgs e)
        {
            if (booksListView.SelectedItems == null && booksListView.SelectedItems.Count == 0)
                return;

            if (MessageBox.Show("Вы точно хотите удалить?", "Удаление", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var id = Convert.ToInt32(booksListView.SelectedItems[0].Tag);
                bookRepository.Delete(id);
                GetAndDrawBooks();
            }
        }
    }
}