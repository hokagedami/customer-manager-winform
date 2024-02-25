using System.Globalization;
using Libraries.Entities;
using Libraries.Interfaces;
using Libraries.Services;

namespace WinForm
{
    public partial class Home : Form
    {
        private CustomerService _customerService;
        private GroupView? viewBeforeNotification;
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
            newCustomerBox.Visible = false;
            dequeuedCustomerGroupBox.Visible = false;
            notificationGroupBox.Visible = false;
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
                ShowNotification(GroupView.NewCustomer, "All fields are required", true);
                return;
            }
            // check if name textbox is empty
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                ShowNotification(GroupView.NewCustomer, "Name is required", true);
                return;
            }
            // check if age textbox is empty
            if (string.IsNullOrEmpty(ageTextBox.Text))
            {
                ShowNotification(GroupView.NewCustomer, "Age is required", true);
                return;
            }
            // check if age is a positive number
            if (!int.TryParse(ageTextBox.Text, out _))
            {
                ShowNotification(GroupView.NewCustomer, "Age must be a number greater than 0", true);
                return;
            }
            // check if address textbox is empty
            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                ShowNotification(GroupView.NewCustomer, "Address is required", true);
                return;
            }
            // check if amount owed textbox is empty
            if (string.IsNullOrEmpty(amountOwedTextBox.Text))
            {
                ShowNotification(GroupView.NewCustomer, "Amount owed is required", true);
                return;
            }
            // check if amount owed is a positive number
            if (!float.TryParse(amountOwedTextBox.Text, out _))
            {
                ShowNotification(GroupView.NewCustomer, "Amount owed must be a number greater than 0", true);
                return;
            }
            // add the customer
            try
            {
                _customerService.AddCustomer(new Customer(nameTextBox.Text,
                    ageTextBox.Text,
                    addressTextBox.Text,
                    float.Parse(amountOwedTextBox.Text)));
                UpdateCustomerQueue();
                ClearNewCustomerEditForm();
                ShowNotification(GroupView.NewCustomer, "Customer added to queue successfully");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                ShowNotification(GroupView.NewCustomer, exception.Message, true);
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
        
        private void ClearEnqueueCustomerForm(object sender, EventArgs e)
        {
            ClearNewCustomerEditForm();
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
            UpdateCustomerQueue();
            newCustomerBox.Visible = false;
            customersQueueGroupBox.Visible = true;
        }

        private void DequeueCustomerButtonClick(object sender, EventArgs e)
        {
            try
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
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                ShowNotification(GroupView.DequeuedCustomer, exception.Message, true);
            }
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
                ShowNotification(GroupView.CustomersQueue, "Queue size is required", true);
                return;
            }
            if (!int.TryParse(circularQueueSizeTextBox.Text, out _))
            {
                ShowNotification(GroupView.CustomersQueue, "Queue size must be a number", true);
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
                ShowNotification(GroupView.CustomersQueue, exception.Message, true);
            }
        }
        
        private void ShowNotification(GroupView groupView, string message, bool error = false)
        {
            notoficationTextBox.Text = message;
            var textSize = TextRenderer.MeasureText(notoficationTextBox.Text, notoficationTextBox.Font);
            if(textSize.Width > notoficationTextBox.Width) notoficationTextBox.Multiline = true;
            notoficationTextBox.BackColor = error ? Color.Red : Color.Green;
            // change the text color to white
            notoficationTextBox.ForeColor = Color.White;
            switch (groupView)
            {
                case GroupView.CustomersQueue:
                    customersQueueGroupBox.Visible = false;
                    break;
                case GroupView.NewCustomer:
                    newCustomerBox.Visible = false;
                    break;
                case GroupView.DequeuedCustomer:
                    dequeuedCustomerGroupBox.Visible = false;
                    break;
                case GroupView.Notification:
                default:
                    customersQueueGroupBox.Visible = false;
                    newCustomerBox.Visible = false;
                    dequeuedCustomerGroupBox.Visible = false;
                    break;
            }
            viewBeforeNotification = groupView;
            notificationGroupBox.Visible = true;
        }

        private void CloseNotificationButtonOnClick(object? sender, EventArgs e)
        {
            notoficationTextBox.Text = string.Empty;
            notificationGroupBox.Visible = false;
            switch (viewBeforeNotification)
            {
                case GroupView.CustomersQueue:
                    customersQueueGroupBox.Visible = true;
                    break;
                case GroupView.NewCustomer:
                    newCustomerBox.Visible = true;
                    break;
                case GroupView.DequeuedCustomer:
                    dequeuedCustomerGroupBox.Visible = true;
                    break;
                case GroupView.Notification:
                default:
                    notificationGroupBox.Visible = true;
                    break;
            }
        }
        private void PopulateWithDummyCustomers()
        {
            _customerService.AddCustomer(new Customer("John Doe", "25", "123 Main St", 100.00f));
            _customerService.AddCustomer(new Customer("Jane Doe", "22", "123 Main St", 200.00f));
            _customerService.AddCustomer(new Customer("Jim Doe", "20", "123 Main St", 300.00f));
            _customerService.AddCustomer(new Customer("Jill Doe", "18", "123 Main St", 400.00f));
            _customerService.AddCustomer(new Customer("Jack Doe", "15", "123 Main St", 500.00f));
            UpdateCustomerQueue();
        }
    }
}
