using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_prijevoznici_i_kupci
{
    public partial class OrderINFOFrm : Form
    {
        public OrderINFOFrm()
        {
            InitializeComponent();
        }

        private void OrderINFOFrm_Load(object sender, EventArgs e)
        {
            PopuniKupce();
            PopuniDobavljace();
        }

        private void DohvatiSveDetalje()
        {
           using (var context = new NorthwindEntities())
            {
                var query = from o in context.Order_Details.Include("Order")
                            select o;
                dgvOrderDetail.DataSource = query.ToList();
            }
        }


        private void PopuniDobavljace()
        {
            using (var context = new NorthwindEntities())
            {
                var query = from s in context.Shippers
                            select s;

                cmbShipper.DataSource = query.ToList();

            }
        }

        private void PopuniKupce()
        {
            using (var context = new NorthwindEntities())
            {
                var query = from k in context.Customers
                            select k;

                cmbCustomer.DataSource = query.ToList();

            }
        }

        private void DohvatiNarudzbe()
        {
            using (var context = new NorthwindEntities())
            {
                var query = from k in context.Orders.Include("Customer").Include("Shipper").Include("Order_Details")
                            select k;
                
                dgvOrders.DataSource = query.ToList();
            }
        }

        private void btnPrikažiSve_Click(object sender, EventArgs e)
        {
            DohvatiNarudzbe();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            Customer customer = cmbCustomer.SelectedItem as Customer;
            Shipper shipper = cmbShipper.SelectedItem as Shipper;

            using(var context = new NorthwindEntities())
            {
                var query = from k in context.Orders.Include("Customer").Include("Shipper").Include("Order_Details")
                            where k.CustomerID == customer.CustomerID && k.ShipVia == shipper.ShipperID
                            select k;

                dgvOrders.DataSource = query.ToList();
            }
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            Order order = dgvOrders.CurrentRow.DataBoundItem as Order;
            using (var context = new NorthwindEntities())
            {
                var query = from o in context.Order_Details
                            where o.OrderID == order.OrderID
                            select o;

                dgvOrderDetail.DataSource = query.ToList();
                dgvOrderDetail.Columns["Order"].Visible = false;
            }
        }
    }
}
