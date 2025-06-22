using BlApi;
using BO;

namespace UI;

public partial class CustomerForm : Form
{
    private readonly IBl _bl = BlApi.Factory.Get();
    private int idCusomer;
    public CustomerForm()
    {
        InitializeComponent();
        try
        {
            closeAllCustomersPanel();
            panelCustomerReadAll.Visible = true;
            dataGridViewCR.DataSource = _bl.Customer.ReadAll();
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת הצגת הלקוחות");
        }
    }

    public void closeAllCustomersPanel()
    {
        panelCustomerCreate.Visible = false;
        panelCustomerReadAll.Visible = false;
        panelCustomerUpdate.Visible = false;
        panelCustomerDelete.Visible = false;
        panelCustomerRead.Visible = false;
    }
    private void buttonCustomerCreate_Click(object sender, EventArgs e)
    {
        closeAllCustomersPanel();
        panelCustomerCreate.Visible = true;
    }

    private void buttonCustomerUpdate_Click(object sender, EventArgs e)
    {
        closeAllCustomersPanel();
        panelCustomerUpdate.Visible = true;
    }

    private void buttonCustomerDelete_Click(object sender, EventArgs e)
    {
        closeAllCustomersPanel();
        panelCustomerDelete.Visible = true;
    }

    private void buttonCustomerReadAll_Click(object sender, EventArgs e)
    {
        try
        {
            closeAllCustomersPanel();
            panelCustomerReadAll.Visible = true;
            dataGridViewCR.DataSource = _bl.Customer.ReadAll();
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת הצגת הלקוחות");
        }
    }

    private void buttonIdCU_Click(object sender, EventArgs e)
    {
        try
        {
            Customer customer = _bl.Customer.Read(int.Parse(textBoxIdCU.Text));
            idCusomer = customer.IdCustomer;
            textBoxIdCU.Text = "";
            textBoxNameCU.Text = customer.Name;
            textBoxPhoneCU.Text = customer.Phone;
            textBoxAddressCU.Text = customer.Address;
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת חיפוש מזהה הלקוח");
        }
    }

    private void buttonCU_Click(object sender, EventArgs e)
    {
        try
        {
            Customer customer = new Customer(idCusomer, textBoxNameCU.Text, textBoxAddressCU.Text, textBoxPhoneCU.Text);
            _bl.Customer.Update(customer);
            textBoxNameCU.Text = "";
            textBoxAddressCU.Text = "";
            textBoxPhoneCU.Text = "";
            MessageBox.Show("הלקוח עודכן");
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת עדכון הלקוח");
        }
    }

    private void buttonCD_Click(object sender, EventArgs e)
    {
        try
        {
            _bl.Customer.Delete(int.Parse(textBoxIdCD.Text));
            textBoxIdCD.Text = "";
            MessageBox.Show("הלקוח נמחק");
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת מחיקת הלקוח");
        }
    }

    private void buttonSaveCustomer_Click(object sender, EventArgs e)
    {
        try

        {
            int id = int.Parse(textBoxIdCC.Text);
            string name = textBoxNameCC.Text;
            string phone = textBoxPhoneCC.Text;
            string address = textBoxAddressCC.Text;
            Console.WriteLine("" + id + " " + name + " " + phone + "" + address);
            _bl.Customer.Create(new Customer(id, name, address, phone));
            textBoxIdCC.Text = "";
            textBoxNameCC.Text = "";
            textBoxPhoneCC.Text = "";
            textBoxAddressCC.Text = "";
            MessageBox.Show("הלקוח נוסף");
        }
        catch
        {
            MessageBox.Show("משהו השתבש בעת הוספת לקוח");
        }
    }

    private void buttonFilterCRA_Click(object sender, EventArgs e)
    {
        try
        {
            dataGridViewCR.DataSource = _bl.Customer.ReadAll(c => c.Name.StartsWith(textBoxFilterCRA.Text));
        }
        catch
        {
            MessageBox.Show("סינון לקוחות נכשל");
        }
    }

    private void buttonIdCR_Click(object sender, EventArgs e)
    {
        try
        {
            Customer customer = _bl.Customer.Read(int.Parse(textBoxIdCR.Text));
            textBoxNameCR.Text = customer.Name;
            textBoxPhoneCR.Text = customer.Phone;
            textBoxAddressCR.Text = customer.Address;
        }
        catch
        {
            MessageBox.Show("הצגת לקוח נכשלה");
        }
    }

    private void buttonCustomerRead_Click(object sender, EventArgs e)
    {
        closeAllCustomersPanel();
        panelCustomerRead.Visible = true;
        textBoxIdCR.Text = "";
        textBoxNameCR.Text = "";
        textBoxPhoneCR.Text = "";
        textBoxAddressCR.Text = "";
    }
}
