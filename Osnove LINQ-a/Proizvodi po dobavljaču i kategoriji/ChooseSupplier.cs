using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_proizvodi_po_dobavljaču_i_kategoriji
{
    public partial class ChooseSupplier : Form
    {
        public ChooseSupplier()
        {
            InitializeComponent();
        }

        private void ChooseSupplier_Load(object sender, EventArgs e)
        {
            GetSuppliers();
        }

        private void GetSuppliers()
        {
            using(var context = new NorthwindEntities())
            {
                var query = from supplier in context.Suppliers
                            select new SupplierView
                            {
                                supplierID= supplier.SupplierID,
                                companyName= supplier.CompanyName,
                                country= supplier.Country,
                                city= supplier.City
                            };
                dgvSupplier.DataSource = query.ToList();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var selected = dgvSupplier.CurrentRow.DataBoundItem ;
            SupplierView selectedSupplier = selected as SupplierView;
            int productID = 0;
         
                ProductsFrm forma = new ProductsFrm(selectedSupplier.supplierID, productID);
                forma.Show();
                this.Hide();
            
            
           
            
        }
    }
}
