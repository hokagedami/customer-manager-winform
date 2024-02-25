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
            _customerService = new CustomerService();
            _customerService.AddCustomer(new Customer("John Doe", "25", "123 Main St", 100.00f));
            _customerService.AddCustomer(new Customer("Jane Doe", "22", "123 Main St", 200.00f));
            _customerService.AddCustomer(new Customer("Jim Doe", "20", "123 Main St", 300.00f));
            _customerService.AddCustomer(new Customer("Jill Doe", "18", "123 Main St", 400.00f));
            _customerService.AddCustomer(new Customer("Jack Doe", "15", "123 Main St", 500.00f));
            // bind the customers to the grid
            customersGridView.DataSource = _customerService.GetCustomers().ToList();
        }

        private void IsCircularQueueCheckedChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBoxNameTextChanged(object sender, EventArgs e)
        {

        }

        private void NameLabelClick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
