using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch6_Hands_On_Test
{
    public partial class Form1 : Form
    {
        public class Book
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public string Keyword { get; set; }
        }

        // Book list
        List<Book> books = new List<Book>
        {
            new Book
            {
                Name = "Hamlet",
                Description = "A Shakespearean tragedy about a young man coming home from college after the murder of his father.",
                Author = "William Shakespeare",
                ISBN = "978-1973844402",
                Keyword = "tragedy"
            },
            new Book
            {
                Name = "Dune",
                Description = "A science fiction saga set in a distant future.",
                Author = "Frank Herbert",
                ISBN = "978-0441172719",
                Keyword = "sci-fi"
            }
        };
        public Form1()
        {
            InitializeComponent();
        }
        private void DisplayBook(Book book)
        {
            if (book != null)
            {
                lblNameResult.Text = book.Name;
                lblAuthorResult.Text = book.Author;
                lblDescribeResult.Text = book.Description;
                lblISBNResult.Text = book.ISBN;
            }
            else
            {
                lblNameResult.Text = "Item not found";
                lblAuthorResult.Text = "";
                lblDescribeResult.Text = "";
                lblISBNResult.Text = "";
            }
        }
        

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            string input = txtAuthor.Text.ToLower();
            Book match = books.FirstOrDefault(b => b.Author.ToLower().Contains(input));
            DisplayBook(match);
        }

        // ISBN search
        private void btnISBN_Click(object sender, EventArgs e)
        {
            string input = txtISBN.Text;
            Book match = books.FirstOrDefault(b => b.ISBN == input);
            DisplayBook(match);
        }

        // Keyword search
        private void btnKeyword_Click(object sender, EventArgs e)
        {
            string input = txtKeyword.Text.ToLower();
            Book match = books.FirstOrDefault(b => b.Keyword.ToLower().Contains(input));
            DisplayBook(match);
        }
    }
}
