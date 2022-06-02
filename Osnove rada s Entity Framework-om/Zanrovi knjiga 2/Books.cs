using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Zanrovi_knjiga
{
    public partial class BooksFrm : Form
    {
        public BooksFrm()
        {
            InitializeComponent();
        }

        private void BooksFrm_Load(object sender, EventArgs e)
        {
            dgvBooks.DataSource = GetBooks();
            dgvBooks.Columns["Genre"].Visible = false;
            cmbGenre.DataSource = GetGenres();
        }

        private object GetGenres()
        {
            using (var context = new EF_DBEntities())
            {
                return context.Genres.ToList();
            }
        }

        private object GetBooks()
        {
            using (var context = new EF_DBEntities())
            {
                return context.Books.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new EF_DBEntities())
            {
                string title = tbTitle.Text;
                int number = int.Parse(tbOfPages.Text.ToString());
                string author = tbMainAuthor.Text;
                Genre genre = cmbGenre.SelectedItem as Genre;
                context.Genres.Attach(genre);

                Book book = new Book()
                {
                    Title = title,
                    NumOfPages = number,
                    MainAuthor = author,
                    IdGenres = genre.Id
                };
                context.Books.Add(book);
                context.SaveChanges();
            }
            dgvBooks.DataSource = GetBooks();

            tbMainAuthor.Clear();
            tbOfPages.Clear();
            tbTitle.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new EF_DBEntities())
            {
                Book book = dgvBooks.CurrentRow.DataBoundItem as Book;
                context.Books.Attach(book); 
                context.Books.Remove(book);
                context.SaveChanges();
            }
            dgvBooks.DataSource = GetBooks();
        }
    }
}
