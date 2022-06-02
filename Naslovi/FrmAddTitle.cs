using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ADO_Titles
{
    public partial class FrmAddTitle : Form
    {
        TitleRepository _titleRepository = new TitleRepository();
        PublisherRepository _publisherRepository = new PublisherRepository();
        public FrmAddTitle()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddTitle_Load(object sender, EventArgs e)
        { 
            List<string> types = _titleRepository.GetTitlesType();
            List<Publisher> publisher = _publisherRepository.GetPublisher();

            foreach(string t in types)
            {
                cmbType.Items.Add(t);
            }
            foreach(Publisher p in publisher)
            {
                cmbPublisher.Items.Add(p.PubName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string titleId = txtTitleId.Text.ToString();
            string title = txtBookTitle.Text.ToString();
            string type = cmbType.SelectedItem.ToString();
            string publisher = cmbPublisher.SelectedItem.ToString();
            List<Publisher> publishers = _publisherRepository.GetPublisher();
            string pubid = null;
            foreach(Publisher p in publishers)
            {
                if(p.PubName == publisher)
                {
                    pubid = p.PubId;
                }
            }
            int i = _titleRepository.Insert(titleId, title, type, pubid);
            FrmTitles frmTitles = new FrmTitles();
            frmTitles.ShowDialog();
            this.Close();

            
        }
    }
}
