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
    public partial class ProductsFrm : Form
    {
        private int supplierId;
        private int categoryId;  

        public ProductsFrm()
        {
            InitializeComponent();
        }

        public ProductsFrm(int supplierID, int categoryID)
        {
            InitializeComponent();
           
           
            if(supplierID != 0)
            {
                
                supplierId = supplierID;

            }
            if (supplierId != 0)
            {
                tbSupplierID.Text = supplierId.ToString();
            }
                
            if (categoryID !=0)
            {
             
                categoryId = categoryID;
            }
            if (categoryId != 0)
            {
                tbCategoryID.Text = categoryId.ToString();
            }
        }

        private void btnChoose1_Click(object sender, EventArgs e)
        {
            ChooseSupplier chooseSupplier = new ChooseSupplier();
            chooseSupplier.Show();
            this.Hide();
        }

        private void btnchoose2_Click(object sender, EventArgs e)
        {
            ChooseCategoryFrm chooseCategoryFrm = new ChooseCategoryFrm(supplierId);
            chooseCategoryFrm.Show();
            this.Hide();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities())
            {
                var query = from p in context.Products
                            where p.CategoryID == categoryId && p.SupplierID == supplierId
                            orderby p.ProductName
                            select new
                            {
                                p.ProductID,
                                p.ProductName,
                                p.Category.CategoryName,
                                p.Supplier.CompanyName

                            };

                dgvProduct.DataSource = query.ToList();
            }
        }
    }
}
