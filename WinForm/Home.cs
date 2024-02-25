using System.Globalization;
using Libraries.Entities;
using Libraries.Interfaces;
using Libraries.Services;

namespace WinForm
{
    public partial class Home : Form
    {
        private ICustomerService _customerService;
        public Home()
        {

            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // add some customers
            circularQueueSizeLabel.Visible = makeCircularQueueCheckBox.Checked;
            circularQueueSizeTextBox.Visible = makeCircularQueueCheckBox.Checked;
            updateCircularQueueSizeButton.Visible = makeCircularQueueCheckBox.Checked;
            _customerService = new CustomerService();
            _customerService.AddCustomer(new Customer("John Doe", "25", "123 Main St", 100.00f));
            _customerService.AddCustomer(new Customer("Jane Doe", "22", "123 Main St", 200.00f));
            _customerService.AddCustomer(new Customer("Jim Doe", "20", "123 Main St", 300.00f));
            _customerService.AddCustomer(new Customer("Jill Doe", "18", "123 Main St", 400.00f));
            _customerService.AddCustomer(new Customer("Jack Doe", "15", "123 Main St", 500.00f));
            // bind the customers to the grid
            customersGridView.DataSource = _customerService.GetCustomers().ToList();
            totalAmountOwedTextBox.Text = _customerService.GetTotalAmountOwed().ToString(CultureInfo.InvariantCulture);
            totalCustomerTextBox.Text = _customerService.GetCustomers().Count().ToString();
            newCustomerBox.Visible = false;
            dequeuedCustomerGroupBox.Visible = false;
        }

        private void IsCircularQueueCheckedChanged(object sender, EventArgs e)
        {
            if (makeCircularQueueCheckBox.Checked)
            {
                circularQueueSizeLabel.Visible = true;
                circularQueueSizeTextBox.Visible = true;
                updateCircularQueueSizeButton.Visible = true;
            }
            else
            {
                circularQueueSizeLabel.Visible = false;
                circularQueueSizeTextBox.Visible = false;
                updateCircularQueueSizeButton.Visible = false;
            }
        }

        private void EnqueueCustomerButtonClick(object sender, EventArgs e)
        {
            // check if all fields are filled
            if(string.IsNullOrEmpty(nameTextBox.Text)
               && string.IsNullOrEmpty(ageTextBox.Text)
               && string.IsNullOrEmpty(addressTextBox.Text)
               && string.IsNullOrEmpty(amountOwedTextBox.Text))
            {
                MessageBox.Show(@"All fields are required", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check if name textbox is empty
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show(@"Name is required", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check if age textbox is empty
            if (string.IsNullOrEmpty(ageTextBox.Text))
            {
                MessageBox.Show(@"Age is required");
                return;
            }
            // check if age is a positive number
            if (!int.TryParse(ageTextBox.Text, out _))
            {
                MessageBox.Show(@"Age must be a number greater than 0");
                return;
            }
            // check if address textbox is empty
            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show(@"Address is required");
                return;
            }
            // check if amount owed textbox is empty
            if (string.IsNullOrEmpty(amountOwedTextBox.Text))
            {
                MessageBox.Show(@"Amount owed is required");
                return;
            }
            // check if amount owed is a positive number
            if (!float.TryParse(amountOwedTextBox.Text, out _))
            {
                MessageBox.Show(@"Amount owed must be a number greater than 0");
                return;
            }
            // add the customer
            try
            {
                _customerService.AddCustomer(new Customer(nameTextBox.Text,
                    ageTextBox.Text,
                    addressTextBox.Text,
                    float.Parse(amountOwedTextBox.Text)));
                customersGridView.DataSource = null;
                customersGridView.DataSource = _customerService.GetCustomers().ToList();
                totalAmountOwedTextBox.Text = _customerService.GetTotalAmountOwed().ToString(CultureInfo.InvariantCulture);
                totalCustomerTextBox.Text = _customerService.GetCustomers().Count().ToString();
                // clear the textboxes
                ClearNewCustomerEditForm();
                newCustomerBox.Visible = false;
                customersQueueGroupBox.Visible = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearNewCustomerEditForm();
            }
        }

        private void ClearNewCustomerEditForm()
        {
            nameTextBox.Text = string.Empty;
            ageTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            amountOwedTextBox.Text = string.Empty;
        }

        private void CloseDequeuedCustomerButtonOnClick(object sender, EventArgs e)
        {
            // clear the textboxes
            customersQueueGroupBox.Visible = true;
            dequeuedCustomerGroupBox.Visible = false;
            dequeuedCustomerNameTextBox.Text = string.Empty;
            dequeuedCustomerAgeTextBox.Text = string.Empty;
            dequeuedCustomerAddressTextBox.Text = string.Empty;
            dequeuedCustomerAmountOwedTextBox.Text = string.Empty;
        }

        private void ShowEnqueueCustomerView(object sender, EventArgs e)
        {
            newCustomerBox.Visible = true;
            customersQueueGroupBox.Visible = false;
        }


        private void CloseEnqueueCustomerView(object sender, EventArgs e)
        {
            ClearNewCustomerEditForm();
            newCustomerBox.Visible = false;
            customersQueueGroupBox.Visible = true;
            UpdateCustomerQueue();
        }

        private void DequeueCustomerButtonClick(object sender, EventArgs e)
        {
            var customer = _customerService.GetNextCustomer();
            dequeuedCustomerNameTextBox.Text = customer.Name;
            dequeuedCustomerAgeTextBox.Text = customer.Age;
            dequeuedCustomerAddressTextBox.Text = customer.Address;
            dequeuedCustomerAmountOwedTextBox.Text = customer.AmountOwed.ToString(CultureInfo.InvariantCulture);
            dequeuedCustomerGroupBox.Visible = true;
            customersQueueGroupBox.Visible = false;
            UpdateCustomerQueue();
        }

        private void UpdateCustomerQueue()
        {
            customersGridView.DataSource = null;
            customersGridView.DataSource = _customerService.GetCustomers().ToList();
            totalAmountOwedTextBox.Text = _customerService.GetTotalAmountOwed().ToString(CultureInfo.InvariantCulture);
            totalCustomerTextBox.Text = _customerService.GetCustomers().Count().ToString();
        }

        private void UpdateCircularQueueSizeButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(circularQueueSizeTextBox.Text))
            {
                MessageBox.Show(@"Queue size is required");
                return;
            }
            if (!int.TryParse(circularQueueSizeTextBox.Text, out _))
            {
                MessageBox.Show(@"Queue size must be a number greater than 0");
                return;
            }

            try
            {
                _customerService.UseCircularQueue(int.Parse(circularQueueSizeTextBox.Text));
                UpdateCustomerQueue();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                 MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
