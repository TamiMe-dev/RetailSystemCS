using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class MenuManager : Form
    {
        public MenuManager()
        {
            InitializeComponent();

        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            this.Hide();
            customer.FormClosed += FormClosed;
            customer.Show();
        }


        private void FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();

        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            ProductForm customer = new ProductForm();
            this.Hide();
            customer.FormClosed += FormClosed;
            customer.Show();
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            SaleForm customer = new SaleForm();
            this.Hide();
            customer.FormClosed += FormClosed;
            customer.Show();
        }
    }
}
