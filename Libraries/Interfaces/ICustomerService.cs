using Libraries.Entities;

namespace Libraries.Interfaces;

public interface ICustomerService
{
    void AddCustomer(Customer customer);
    Customer GetNextCustomer();
    int GetCustomerCount();
    Customer PeekAtNextCustomer();
    float GetTotalAmountOwed();
    Customer GetCustomerWithMostAmountOwed();
    MyQueue<Customer> GetCustomers();
}