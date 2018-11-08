using MyBooks.Data;
using MyBooks.Entities;
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
            var books = bookRepository.GetAll();
            DrawBooks(books);
        }

        private void DrawBooks(IEnumerable<Book> books)
        {
            foreach (var item in books)
            {
                var viewItem = booksListView.Items.Add(item.Name);
                viewItem.SubItems.Add(item.Author);
                viewItem.SubItems.Add(item.Description);
                viewItem.SubItems.Add(item.DateCreated.ToShortDateString());
                viewItem.Tag = item.Id;
            }
        }
    }
}