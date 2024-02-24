using CustomerManager.Libraries.Entities;
using CustomerManager.Libraries.Interfaces;
using Customer = CustomerManager.Libraries.Entities.Customer;

namespace CustomerManager.Libraries.Services;

public class CustomerService: ICustomerService
{
    private readonly MyQueue<Customer> _customers;

    public CustomerService(int size)
    {
        _customers = new CircularMyQueue<Customer>(size);
    }
    public CustomerService()
    {
        _customers = new MyQueue<Customer>();
    }
    
    public void AddCustomer(Customer customer)
    {
        _customers.Enqueue(customer);
    }
    
    public Customer GetNextCustomer()
    {
        return _customers.Dequeue();
    }
    
    public int GetCustomerCount()
    {
        return _customers.Count();
    }
    
    public Customer PeekAtNextCustomer()
    {
        return _customers.Peek();
    }
    
    public float GetTotalAmountOwed()
    {
        return _customers
            .ToArray()
            .Sum(c => c.AmountOwed);
    }
    
    public Customer GetCustomerWithMostAmountOwed()
    {
        return _customers
            .ToArray()
            .OrderByDescending(c => c.AmountOwed)
            .First();
    }

    public MyQueue<Customer> GetCustomers()
    {
        return _customers;
    }
}