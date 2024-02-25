using System.Globalization;
using Libraries.Entities;
using Libraries.Interfaces;

namespace Libraries.Services;

public class CustomerService: ICustomerService
{
    private MyQueue<Customer> _customers;

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
        // check if the customer is null
        if (customer == null)
        {
            throw new ArgumentNullException(nameof(customer), "Customer cannot be null");
        }
        // check if the customer is already in the queue using simple iteration
        if (_customers.ToArray().Any(customerInQueue => customer.Name == customerInQueue.Name 
                                             && customer.Age == customerInQueue.Age 
                                             && customer.Address == customerInQueue.Address 
                                             && customer.AmountOwed.ToString(CultureInfo.InvariantCulture) 
                                                == customerInQueue.AmountOwed.ToString(CultureInfo.InvariantCulture)))
        {
            throw new InvalidOperationException("Customer already exists in the queue");
        }
        if (_customers.ToArray().Any(customerInQueue => customer.Name == customerInQueue.Name))
        {
            throw new InvalidOperationException($"Customer with name {customer.Name} already exists in the queue");
        }
        
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
    
    public void UseCircularQueue(int size)
    {
        if (_customers is CircularMyQueue<Customer>) return;
        if (_customers.Count() > size)
        {
            throw new InvalidOperationException("The new queue size is smaller than the current queue size");
        }
        var newQueue = new CircularMyQueue<Customer>(size);
        foreach (var customer in _customers.ToArray())
        {
            newQueue.Enqueue(customer);
        }
        _customers = newQueue;
    }
}