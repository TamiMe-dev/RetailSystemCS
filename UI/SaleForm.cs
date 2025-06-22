using BlApi;
using BO;
namespace UI;

public partial class SaleForm : Form
{
    private readonly IBl _bl = BlApi.Factory.Get();
    private int idSale;
    public SaleForm()
    {
        InitializeComponent();
        try
        {
            closeAllSalesPanel();
            panelSaleReadAll.Visible = true;
            dataGridViewSRA.DataSource = _bl.Sale.ReadAll();
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת הצגת המבצעים");
        }
    }
    public void closeAllSalesPanel()
    {
        panelSaleCreate.Visible = false;
        panelSaleReadAll.Visible = false;
        panelSaleUpdate.Visible = false;
        panelSaleDelete.Visible = false;
        panelSaleRead.Visible = false;
    }

    private void buttonSaleCreate_Click(object sender, EventArgs e)
    {
        closeAllSalesPanel();
        panelSaleCreate.Visible = true;
    }

    private void buttonSaleUpdate_Click(object sender, EventArgs e)
    {
        closeAllSalesPanel();
        panelSaleUpdate.Visible = true;
    }

    private void buttonSaleDelete_Click(object sender, EventArgs e)
    {
        closeAllSalesPanel();
        panelSaleDelete.Visible = true;
    }

    private void buttonSaleReadAll_Click(object sender, EventArgs e)
    {
        try
        {
            closeAllSalesPanel();
            panelSaleReadAll.Visible = true;
            dataGridViewSRA.DataSource = _bl.Sale.ReadAll();
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת הצגת המבצעים");
        }
    }

    private void buttonIdSU_Click(object sender, EventArgs e)
    {
        try
        {
            Sale Sale = _bl.Sale.Read(int.Parse(textBoxIdSU.Text));
            idSale = int.Parse(textBoxIdSU.Text);
            textBoxIdSU.Text = "";
            textBoxIdProductSU.Text = Sale.ProductId.ToString();
            textBoxCountSU.Text = Sale.RequiredAmount.ToString();
            numericUpDownPriceSU.Value = (decimal)Sale.PriceSale;
            checkBoxClubSU.Checked = Sale.IsForClubMembers;
            dateTimePickerStartSU.Value = Sale.StartDate;
            dateTimePickerFinishSU.Value = Sale.EndDate;
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת חיפוש מזהה המבצעים");
        }
    }

    private void buttonSU_Click(object sender, EventArgs e)
    {
        try
        {
            Sale Sale = new Sale(idSale, int.Parse(textBoxCountSU.Text), Convert.ToDouble(numericUpDownPriceSU.Value), checkBoxClubSU.Checked, dateTimePickerStartSU.Value, dateTimePickerFinishSU.Value);
            _bl.Sale.Update(Sale);
            MessageBox.Show("המבצע עודכן");
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת עדכון המבצעים");
        }
    }

    private void buttonSD_Click(object sender, EventArgs e)
    {
        try
        {
            _bl.Sale.Delete(int.Parse(textBoxIdSD.Text));
            textBoxIdSD.Text = "";
            MessageBox.Show("המבצע נמחק");
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת מחיקת המבצעים");
        }
    }

    private void buttonSaveSale_Click(object sender, EventArgs e)
    {
        try
        {

            int idProduct = int.Parse(textBoxIdSC.Text);
            int count = int.Parse(textBoxCountSC.Text);
            double price = Convert.ToDouble(numericUpDownPriceSC.Value);
            bool club = checkBoxClubSC.Checked;
            DateTime start = dateTimePickerStart.Value;
            DateTime finish = dateTimePickerDateFinish.Value;
            _bl.Sale.Create(new Sale(idProduct, count, price, club, start, finish));
            textBoxIdSC.Text = "";
            textBoxCountSC.Text = "";
            numericUpDownPriceSC.Value = 0;
            checkBoxClubSC.Checked = false;
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerDateFinish.Value = DateTime.Now;
            MessageBox.Show("המבצע נוסף");
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת הוספת המבצעים");
        }
    }

    private void buttonFilterSRA_Click(object sender, EventArgs e)
    {
        try
        {
            switch (comboBoxFilterSRA.SelectedIndex)
            {
                case 0:
                    {
                        dataGridViewSRA.DataSource = _bl.Sale.ReadAll(s => s.EndDate < DateTime.Now);
                        break;
                    }
                case 1:
                    {
                        dataGridViewSRA.DataSource = _bl.Sale.ReadAll(s => s.StartDate <= DateTime.Now && s.EndDate >= DateTime.Now);
                        break;
                    }
                case 2:
                    {
                        dataGridViewSRA.DataSource = _bl.Sale.ReadAll(s => s.StartDate > DateTime.Now);
                        break;
                    }
                case 3:
                    {
                        dataGridViewSRA.DataSource = _bl.Sale.ReadAll();
                        break;
                    }
                default:
                    break;
            }
        }
        catch
        {
            MessageBox.Show("סינון המבצעים נכשל");
        }
    }

    private void buttonIdSR_Click(object sender, EventArgs e)
    {
        try
        {
            Sale sale = _bl.Sale.Read(int.Parse(textBoxIdPR.Text));
            textBoxIdProductPR.Text = sale.ProductId.ToString();
            textBoxCountPR.Text = sale.RequiredAmount.ToString();
            numericUpDownPricePR.Value = (decimal)sale.PriceSale;
            textBoxStartDatePR.Text = sale.StartDate.ToString();
            textBoxFinishDatePR.Text = sale.EndDate.ToString();
            textBoxClubPR.Text = sale.IsForClubMembers.ToString();
        }
        catch
        {
            MessageBox.Show("הצגת מבצע נכשלה");
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        closeAllSalesPanel();
        panelSaleRead.Visible = true;
        textBoxIdPR.Text = "";
        textBoxIdProductPR.Text = "";
        textBoxCountPR.Text = "";
        numericUpDownPricePR.Value = 0;
        textBoxStartDatePR.Text = "";
        textBoxFinishDatePR.Text = "";
        textBoxClubPR.Text ="";
    }
}