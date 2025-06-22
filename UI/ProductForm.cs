using BlApi;
using BO;
namespace UI;

public partial class ProductForm : Form
{
    private readonly IBl _bl = BlApi.Factory.Get();
    private int idProduct;
    public ProductForm()
    {
        InitializeComponent();
        try
        {
            closeAllProductsPanel();
            panelProductReadAll.Visible = true;
            dataGridViewPRA.DataSource = _bl.Product.ReadAll();
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת הצגת המוצרים");
        }
    }
    public void closeAllProductsPanel()
    {
        panelProductCreate.Visible = false;
        panelProductReadAll.Visible = false;
        panelProductUpdate.Visible = false;
        panelProductDelete.Visible = false;
        panelProductRead.Visible = false;
    }
    private void buttonProductCreate_Click(object sender, EventArgs e)
    {
        closeAllProductsPanel();
        panelProductCreate.Visible = true;
    }
    private void buttonProductReadAll_Click(object sender, EventArgs e)
    {
        try
        {
            closeAllProductsPanel();
            panelProductReadAll.Visible = true;
            dataGridViewPRA.DataSource = _bl.Product.ReadAll();
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת הצגת המוצרים");
        }
    }

    private void buttonProductUpdate_Click(object sender, EventArgs e)
    {
        closeAllProductsPanel();
        panelProductUpdate.Visible = true;
    }

    private void buttonProductDelete_Click(object sender, EventArgs e)
    {
        closeAllProductsPanel();
        panelProductDelete.Visible = true;
    }

    private void buttonSaveProduct_Click(object sender, EventArgs e)
    {
        try
        {

            string name = textBoxNamePC.Text;
            Categories category = (Categories)Enum.Parse(typeof(Categories), (comboBoxCateroryPC.Text));
            double price = Convert.ToDouble(numericUpDownPricePC.Value);
            int count = Convert.ToInt32(numericUpDownCountPC.Value);
            _bl.Product.Create(new Product(name, category, price, count));
            comboBoxCateroryPC.Text = "";
            numericUpDownPricePC.Value = 0;
            numericUpDownCountPC.Value = 0;
            MessageBox.Show("מוצר נוסף");
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת הוספת מוצר");
        }
    }

    private void buttonIdPU_Click(object sender, EventArgs e)
    {
        try
        {
            Product product = _bl.Product.Read(int.Parse(textBoxIdPU.Text));
            idProduct = int.Parse(textBoxIdPU.Text);
            textBoxIdPU.Text = "";
            textBoxNamePU.Text = product.Name;
            comboBoxPU.Text = product.Category.ToString();
            numericUpDownPricePU.Value = (decimal)product.Price;
            numericUpDownCountPU.Value = (decimal)product.AmountInStock;
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת חיפוש מזהה מוצר");
        }
    }

    private void buttonPU_Click(object sender, EventArgs e)
    {
        try
        {
            Product product = new Product(idProduct, textBoxNamePU.Text, (Categories)Enum.Parse(typeof(Categories), (comboBoxPU.Text)), Convert.ToDouble(numericUpDownPricePU.Value), Convert.ToInt32(numericUpDownCountPU.Value));
            _bl.Product.Update(product);
            textBoxNamePU.Text = "";
            comboBoxPU.Text = "";
            numericUpDownPricePU.Value = 0;
            numericUpDownCountPU.Value = 0;
            MessageBox.Show("מוצר עודכן");
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת עדכון מוצר");
        }
    }

    private void buttonPD_Click(object sender, EventArgs e)
    {
        try
        {
            _bl.Product.Delete(int.Parse(textBoxIdPD.Text));
            textBoxIdPD.Text = "";
            MessageBox.Show("מוצר נמחק");
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת מחיקת המוצר");
        }
    }

    private void buttonProductRead_Click(object sender, EventArgs e)
    {
        closeAllProductsPanel();
        panelProductRead.Visible = true;
        textBoxIdPR.Text = "";
        textBoxNamePR.Text = "";
        textBoxCategoryPR.Text = "";
        numericUpDownPricePR.Value = 0;
        numericUpDownCountPR.Value = 0;
    }

    private void buttonFilterPRA_Click(object sender, EventArgs e)
    {
        try
        {
            switch (comboBoxFilterPRA.SelectedIndex)
            {
                case 0:
                    dataGridViewPRA.DataSource = _bl.Product.ReadAll(p => p.Price <= 500);
                    break;
                case 1:
                    dataGridViewPRA.DataSource = _bl.Product.ReadAll(p => p.Price <= 1000);
                    break;
                case 2:
                    dataGridViewPRA.DataSource = _bl.Product.ReadAll(p => p.Price <= 5000);
                    break;
                case 3:
                    dataGridViewPRA.DataSource = _bl.Product.ReadAll(p => p.Price <= 10000);
                    break;
                case 4:
                    dataGridViewPRA.DataSource = _bl.Product.ReadAll(p => p.Price >= 10000);
                    break;
                case 5:
                    dataGridViewPRA.DataSource = _bl.Product.ReadAll();
                    break;
                default:
                    dataGridViewPRA.DataSource = _bl.Product.ReadAll();
                    break;

            }
        }
        catch {
            MessageBox.Show("סינון מוצרים נכשל");
        }
    }

    private void buttonIdPR_Click(object sender, EventArgs e)
    {
        try
        {
            Product product = _bl.Product.Read(int.Parse(textBoxIdPR.Text));
            textBoxIdPR.Text = "";
            textBoxNamePR.Text = product.Name;
            textBoxCategoryPR.Text = product.Category.ToString();
            numericUpDownPricePR.Value = (decimal)product.Price;
            numericUpDownCountPR.Value = (decimal)product.AmountInStock;
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת הצגת מוצר");
        }
    }
}
