using CustomerManager.Libraries.Entities;
using CustomerManager.Libraries.Interfaces;

namespace CustomerManager
{
    public partial class Home : Form
    {
        private readonly ICustomerService _customerService;
        public Home(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // add some customers
            _customerService.AddCustomer(new Customer("John Doe", "25", "123 Main St", 100.00f));
            _customerService.AddCustomer(new Customer("Jane Doe", "22", "123 Main St", 200.00f));
            _customerService.AddCustomer(new Customer("Jim Doe", "20", "123 Main St", 300.00f));
            _customerService.AddCustomer(new Customer("Jill Doe", "18", "123 Main St", 400.00f));
            _customerService.AddCustomer(new Customer("Jack Doe", "15", "123 Main St", 500.00f));
            // bind the customers to the grid
            customersGridView.DataSource = _customerService.GetCustomers().ToArray();
        }

    }
}
