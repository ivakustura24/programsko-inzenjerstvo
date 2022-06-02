using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_zanrovi_knjiga
{
    public partial class BooksFrm : Form
    {

        
        public BooksFrm()
        {
            InitializeComponent();
        }

        private void BooksFrm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            dgvGenre.DataSource = DohvatiZanrove();
            dgvGenre.Columns["Books"].Visible = false;
            
            dgvBooks.DataSource = DohvatiKnjige();
            dgvBooks.Columns["Genre"].Visible = false;
            dgvBooks.Columns["IdGenres"].Visible = false;
        }

        private object DohvatiZanrove()
        {
            using (var context = new EF_DBEntities())
            { 
                return context.Genres.ToList();
            }
              
        }

        private void dgvGenre_SelectionChanged(object sender, EventArgs e)
        {
            Genre selectedGenre = DohvatiZanr();
            dgvBooks.DataSource = DohvatiKnjige(selectedGenre);
        }

        private object DohvatiKnjige(Genre selectedGenre)
        {
            using (var context = new EF_DBEntities())
            {
                context.Genres.Attach(selectedGenre);
                return selectedGenre.Books.ToList();
            }
        }

        private Genre DohvatiZanr()
        {
            return dgvGenre.CurrentRow.DataBoundItem as Genre;
            
        }

        private object DohvatiKnjige()
        {
             using (var context = new EF_DBEntities())
            {
                return context.Books.ToList();
            }
           
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            using (var context = new EF_DBEntities())
            {
                string title = tbTitle.Text;
                int num_pages = int.Parse(tbOfPages.Text.ToString());
                string mainAuthor = tbMainAuthor.Text;
                Genre selectedGenre = dgvGenre.CurrentRow.DataBoundItem as Genre;
                context.Genres.Attach(selectedGenre);
                Book newBook = new Book()
                {
                    Title = title,
                    NumOfPages = num_pages,
                    MainAuthor = mainAuthor,
                    IdGenres = selectedGenre.Id
                };
                context.Books.Add(newBook); 
                context.SaveChanges();  
            }
         
            dgvBooks.DataSource=DohvatiKnjige();
      
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            Book knjiga = dgvBooks.CurrentRow.DataBoundItem as Book;
            using (var context= new EF_DBEntities())
            {
                context.Books.Attach(knjiga);
                context.Books.Remove(knjiga);
                context.SaveChanges();
            }
            dgvBooks.DataSource = DohvatiKnjige();
        }
    }
}
