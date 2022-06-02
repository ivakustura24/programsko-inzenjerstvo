using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Products_and_categories
{
    public partial class productsFrm : Form
    {
        public productsFrm()
        {
            InitializeComponent();
        }

        private void productsFrm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            dgvProducts.DataSource = GetProducts();
            dgvProducts.Columns["Category"].Visible = false;
        }

        private object GetProducts()
        {
            using (var context = new EF_DBEntities())
            {
                return context.Products.ToList();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddProduct forma = new AddProduct();
            forma.ShowDialog();
            Osvjezi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using(var context = new EF_DBEntities())
            {
                Product selectedProduct = dgvProducts.CurrentRow.DataBoundItem as Product;
                context.Products.Attach(selectedProduct);
                context.Products.Remove (selectedProduct);
                context.SaveChanges();
            }
            Osvjezi();
        }
    }
}
