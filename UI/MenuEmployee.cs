using BlApi;
using BO;
using System.Windows.Forms;

namespace UI;

public partial class MenuEmployee : Form
{
    private readonly IBl _bl = Factory.Get();
    Order order;
    public MenuEmployee()
    {
        InitializeComponent();
        closeAllPanel();
        panelStartOrder.Visible = true;
    }

    public void closeAllPanel()
    {
        panelStartOrder.Visible = false;
        panelCategory.Visible = false;
        panelShowProduct.Visible = false;
        panelOrderFinish.Visible = false;
    }

    private void buttonStartOrder_Click(object sender, EventArgs e)
    {
        closeAllPanel();
        panelCategory.Visible = true;
        order = new Order();
        order.IsFavoriteCustomer = checkBoxClub.Checked;
    }

    private void buttonAddToOrder_Click(object sender, EventArgs e)
    {
        try
        {
            if (dataGridViewShowProduct.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridViewShowProduct.SelectedRows[0];
                int productId = Convert.ToInt32(selectedRow.Cells["IdProduct"].Value);
                string productName = selectedRow.Cells["Name"].Value.ToString();
                Categories category = (Categories)Enum.Parse(typeof(Categories), (selectedRow.Cells["Category"].Value.ToString()));
                double productPrice = Convert.ToDouble(selectedRow.Cells["Price"].Value);
                int amountInStock = Convert.ToInt32(selectedRow.Cells["AmountInStock"].Value);
                Product selectedProduct = new Product(productId, productName, category, productPrice, amountInStock);
                int amount = Convert.ToInt32(numericUpDownAmountProduct.Value);
                List<SaleInProduct> sales = _bl.Order.AddProductToOrder(order, selectedProduct.IdProduct, amount);
                if (sales.Count > 0)
                {
                    foreach (SaleInProduct sale in sales)
                    {
                        MessageBox.Show($"מבצע!! {sale.AmountForSale} ב{sale.Price}");
                    }
                }
                MessageBox.Show("המוצר נוסף להזמנה");
                closeAllPanel();
                panelCategory.Visible = true;
            }
            else
            {
                if (dataGridViewShowProduct.SelectedRows.Count < 0)
                    MessageBox.Show("מוצר לא נבחר");
                else
                    MessageBox.Show("בחר מוצר אחד בלבד");
            }
        }
        catch
        {
            MessageBox.Show("הוספת המוצר נכשלה");
        }

    }

    private void buttonFinishOrder_Click(object sender, EventArgs e)
    {
        try
        {
            if (dataGridViewShowProduct.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridViewShowProduct.SelectedRows[0];
                int productId = Convert.ToInt32(selectedRow.Cells["IdProduct"].Value);
                string productName = selectedRow.Cells["Name"].Value.ToString();
                Categories category = (Categories)Enum.Parse(typeof(Categories), (selectedRow.Cells["Category"].Value.ToString()));
                double productPrice = Convert.ToDouble(selectedRow.Cells["Price"].Value);
                int amountInStock = Convert.ToInt32(selectedRow.Cells["AmountInStock"].Value);
                Product selectedProduct = new Product(productId, productName, category, productPrice, amountInStock);
                int amount = Convert.ToInt32(numericUpDownAmountProduct.Value);
                List<SaleInProduct> sales = _bl.Order.AddProductToOrder(order, selectedProduct.IdProduct, amount);
                if (sales.Count > 0)
                {
                    foreach (SaleInProduct sale in sales)
                    {
                        MessageBox.Show($"מבצע!! {sale.AmountForSale} ב{sale.Price}");
                    }
                }
                MessageBox.Show("המוצר נוסף להזמנה");
            }
            else
            {
                if (dataGridViewShowProduct.SelectedRows.Count < 0)
                    MessageBox.Show("מוצר לא נבחר");
                else
                    MessageBox.Show("בחר מוצר אחד בלבד");
            }
        }
        catch
        {
            MessageBox.Show("הוספת המוצר נכשלה");
        }
        closeAllPanel();
        panelOrderFinish.Visible = true;
        _bl.Order.DoOrder(order);
        dataGridViewProductInOrder.DataSource = order.ProductList;
        labelShowPrice.Text = order.TotalPrice.ToString();
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
        closeAllPanel();
        panelCategory.Visible = true;
    }

    private void buttonFinishOrderMenu_Click(object sender, EventArgs e)
    {
        try
        {
            closeAllPanel();
            panelOrderFinish.Visible = true;
            _bl.Order.DoOrder(order);
            dataGridViewProductInOrder.DataSource = order.ProductList;
            labelShowPrice.Text = order.TotalPrice.ToString();
        }
        catch
        {
            MessageBox.Show("הזמנה נכשלה");
        }

    }

    private void buttonSkincare_Click(object sender, EventArgs e)
    {
        closeAllPanel();
        panelShowProduct.Visible = true;
        dataGridViewShowProduct.DataSource = _bl.Product.ReadAll(p => p.Category == Categories.Skincare);
    }

    private void buttonLipMakeup_Click(object sender, EventArgs e)
    {
        closeAllPanel();
        panelShowProduct.Visible = true;
        dataGridViewShowProduct.DataSource = _bl.Product.ReadAll(p => p.Category == Categories.LipMakeup);
    }

    private void buttonMakeupToolsAndAccessories_Click(object sender, EventArgs e)
    {
        closeAllPanel();
        panelShowProduct.Visible = true;
        dataGridViewShowProduct.DataSource = _bl.Product.ReadAll(p => p.Category == Categories.MakeupToolsAndAccessories);
    }

    private void buttonEyeMakeup_Click(object sender, EventArgs e)
    {
        closeAllPanel();
        panelShowProduct.Visible = true;
        dataGridViewShowProduct.DataSource = _bl.Product.ReadAll(p => p.Category == Categories.EyeMakeup);
    }

    private void buttonFaceMakeup_Click(object sender, EventArgs e)
    {
        closeAllPanel();
        panelShowProduct.Visible = true;
        dataGridViewShowProduct.DataSource = _bl.Product.ReadAll(p => p.Category == Categories.FaceMakeup);
    }
}
