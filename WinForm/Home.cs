using System.Globalization;
using Libraries.Entities;
using Libraries.Services;

namespace WinForm
{
    public partial class Home : Form
    {
        private readonly CustomerService _customerService;
        private GroupView? _viewBeforeNotification;
        public Home(CustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            newCustomerBox.Visible = false;
            customerGroupBox.Visible = false;
            notificationGroupBox.Visible = false;
        }

        private void EnqueueCustomerButtonClick(object sender, EventArgs e)
        {
            // check if all fields are filled
            if (string.IsNullOrEmpty(nameTextBox.Text)
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
            customerGroupBox.Visible = false;
            customerNameTextBox.Text = string.Empty;
            customerAgeTextBox.Text = string.Empty;
            customerAddressTextBox.Text = string.Empty;
            customerAmountOwedTextBox.Text = string.Empty;
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
                customerNameTextBox.Text = customer.Name;
                customerAgeTextBox.Text = customer.Age;
                customerAddressTextBox.Text = customer.Address;
                customerAmountOwedTextBox.Text = customer.AmountOwed.ToString(CultureInfo.InvariantCulture);
                customerGroupBox.Visible = true;
                customerGroupBox.Name = "Dequeued Customer";
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
                defaultCircularQueueSize = int.Parse(circularQueueSizeTextBox.Text);
                _customerService.UseCircularQueue(defaultCircularQueueSize);
                UpdateCustomerQueue();
                circularQueueSizeTextBox.Text = string.Empty;
                ShowNotification(GroupView.CustomersQueue, "Queue size updated successfully");
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
            if (textSize.Width > notoficationTextBox.Width) notoficationTextBox.Multiline = true;
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
                    customerGroupBox.Visible = false;
                    break;
                case GroupView.Notification:
                default:
                    customersQueueGroupBox.Visible = false;
                    newCustomerBox.Visible = false;
                    customerGroupBox.Visible = false;
                    break;
            }
            _viewBeforeNotification = groupView;
            notificationGroupBox.Visible = true;
        }

        private void CloseNotificationButtonOnClick(object? sender, EventArgs e)
        {
            notoficationTextBox.Text = string.Empty;
            notificationGroupBox.Visible = false;
            switch (_viewBeforeNotification)
            {
                case GroupView.CustomersQueue:
                    customersQueueGroupBox.Visible = true;
                    break;
                case GroupView.NewCustomer:
                    newCustomerBox.Visible = true;
                    break;
                case GroupView.DequeuedCustomer:
                    customerGroupBox.Visible = true;
                    break;
                default:
                    notificationGroupBox.Visible = true;
                    break;
            }
        }
        private void ToggleQueueTypeButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (isCircularQueue)
                {
                    var circularQueueSizeTextIsNumber = int.TryParse(circularQueueSizeTextBox.Text,
                        out var circularQueueSize);
                    if (!circularQueueSizeTextIsNumber && !string.IsNullOrEmpty(circularQueueSizeTextBox.Text))
                    {
                        ShowNotification(GroupView.CustomersQueue, "Queue size must be a number", true);
                        return;
                    }
                    _customerService.UseCircularQueue(circularQueueSize);
                    defaultCircularQueueSize = circularQueueSize;
                }
                else
                {
                    _customerService.UseQueue();
                }
                isCircularQueue = !isCircularQueue;
                queueToggleButton.Text = isCircularQueue ? "Regular Queue" : "Circular Queue";
                UpdateCustomerQueue();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                ShowNotification(GroupView.CustomersQueue, exception.Message, true);
            }
        }

        private void DisplayCustomerWithHighestOwedAmount(object sender, EventArgs e)
        {
            try
            {
                // check if there are customers in the queue
                if (_customerService.GetCustomerCount() == 0)
                {
                    ShowNotification(GroupView.DequeuedCustomer, "No customers in the queue", true);
                    return;
                }
                var customer = _customerService.GetCustomerWithMostAmountOwed();
                customerNameTextBox.Text = customer.Name;
                customerAgeTextBox.Text = customer.Age;
                customerAddressTextBox.Text = customer.Address;
                customerAmountOwedTextBox.Text = customer.AmountOwed.ToString(CultureInfo.InvariantCulture);
                customerGroupBox.Visible = true;
                customerGroupBox.Name = "Customer With Most Amount Owed";
                customersQueueGroupBox.Visible = false;
                UpdateCustomerQueue();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                ShowNotification(GroupView.DequeuedCustomer, exception.Message, true);
            }
        }

        private void PopulateQueueWithDummyData(object sender, EventArgs e)
        {
            try
            {
                // get current customer count
                var customerCount = _customerService.GetCustomerCount();
                // get the default queue size
                var queueSize = isCircularQueue ? defaultCircularQueueSize : 5;
                // check if the queue is full
                if (customerCount == queueSize)
                {
                    ShowNotification(GroupView.CustomersQueue, "Queue is full", true);
                    return;
                }
                for (var i = 0; i < queueSize - customerCount; i++)
                {
                    // random age
                    var randomAge = new Random().Next(15, 80);
                    var randomAmountOwed = new Random().NextDouble();
                    _customerService.AddCustomer(new Customer($"Customer {i + 1}", randomAge.ToString(), "123 Main St", (float)randomAmountOwed));
                    UpdateCustomerQueue();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                ShowNotification(GroupView.CustomersQueue, exception.Message, true);
            }

        }
    }
}
