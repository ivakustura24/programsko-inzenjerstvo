using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PublisherTracker;
using TitleLogic;

namespace ADO_Publishers
{
    public partial class FrmPublishersTitles : Form
    {
        public FrmPublishersTitles()
        {
            InitializeComponent();
        }

        private void FrmPublishersTitles_Load(object sender, EventArgs e)
        {
            
            Osvjezi();
        }

        private void dgvPublishers_SelectionChanged(object sender, EventArgs e)
        {
            Publisher publisher = dgvPublishers.CurrentRow.DataBoundItem as Publisher;
            string id = publisher.Id;
            TitleRepository titleRepository = new TitleRepository();
            List<Title> titles = titleRepository.GetTitles(id);
            dgvTitles.DataSource = titles;
         
        }

        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text; 
            string type = txtType.Text;
            Publisher pub = dgvPublishers.CurrentRow.DataBoundItem as Publisher;
            string pubid = pub.Id;
            TitleRepository titleRepository = new TitleRepository();
            int i=titleRepository.InsertTitle(id, name, type, pubid);
            Osvjezi();

        }
        public void Osvjezi()
        {
            List<Publisher> publishers = new List<Publisher>();
            PublisherRepository repositoryP = new PublisherRepository();
            publishers = repositoryP.GetPublishers();
            dgvPublishers.DataSource = publishers;
        }
    }
}
