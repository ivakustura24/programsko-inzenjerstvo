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
    public partial class ChooseCategoryFrm : Form
    {
        private int supplierId;
        public ChooseCategoryFrm()
        {
            InitializeComponent();
        }
        public ChooseCategoryFrm(int supplierID)
        {
            InitializeComponent();
            supplierId = supplierID;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            CategoryView selectedCategory = dgvCategory.CurrentRow.DataBoundItem as CategoryView;

            ProductsFrm forma = new ProductsFrm(supplierId, selectedCategory.categoryID);
            forma.Show();
            this.Hide();
        }

        private void ChooseCategoryFrm_Load(object sender, EventArgs e)
        {
            FillCategories();
        }

        private void FillCategories()
        {
           using (var context = new NorthwindEntities())
            {
                var query = from c in context.Categories
                            select new CategoryView
                            {
                                categoryID=c.CategoryID,
                                categoryName= c.CategoryName
                            };

                dgvCategory.DataSource = query.ToList();
            }
        }


    }
}
