using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Kategorije_proizvoda
{
    public partial class CategoriesAndProductsFrm : Form
    {
        public CategoriesAndProductsFrm()
        {
            InitializeComponent();
        }

        private void CategoriesAndProductsFrm_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            FillCategories();
        }

        private void FillCategories()
        {
            using (var context = new EF_DBEntities())
            {
                dgvCategories.DataSource = context.Categories.ToList();
            }
            dgvCategories.Columns["Products"].Visible = false;

            FillProducts();
        }

        private void FillProducts()
        {

            dgvProducts.DataSource = GetCategoryProducts();

            dgvProducts.Columns["Category"].Visible = false;
        }

        private object GetCategoryProducts()
        {
            Category category_new = dgvCategories.CurrentRow.DataBoundItem as Category;
            if (category_new != null)
            {
                using (var context = new EF_DBEntities())
                {
                    context.Categories.Attach(category_new);
                    return category_new.Products.ToList();
                }

            }
            return null;
        }



        private void dgvCategories_MouseClick(object sender, MouseEventArgs e)
        {
            FillProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new EF_DBEntities())
            {
                string name = tbProductName.Text;
                int quantity = int.Parse(tbQuantity.Text.ToString());
                double price = double.Parse(tbUnitPrice.Text.ToString());
                Category category = dgvCategories.CurrentRow.DataBoundItem as Category;
                context.Categories.Attach(category);
                Product product = new Product()
                {
                    Name = name,
                    Quantity = quantity,
                    UnitPrice = price,
                    CategoryId = category.Id
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
            FillProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product product = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (product != null)
            {
                using (var context = new EF_DBEntities())
                {
                    context.Products.Attach(product);
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
                FillProducts();
            }
        }
    }
}