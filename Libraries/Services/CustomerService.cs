using System.Globalization;
using Libraries.Entities;

namespace Libraries.Services;

public class CustomerService
{
    private MyQueue<Customer> _customers = new();
    private bool IsCircular => _customers is CircularMyQueue<Customer>;
    private bool hasDummyData = false;

    public void AddCustomer(Customer customer)
    {
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
        if (IsCircular) return;
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

    public void UseQueue()
    {
        if (!IsCircular) return;
        var newQueue = new MyQueue<Customer>();
        foreach (var customer in _customers.ToArray())
        {
            newQueue.Enqueue(customer);
        }
        _customers = newQueue;
    }

    public void AddDummyData()
    {
        if(hasDummyData) throw new Exception("Dummy data already added");
        AddCustomer(new Customer("John Doe", 25.ToString(), "123 Main St", 100.00f));
        AddCustomer(new Customer("Jane Doe", 30.ToString(), "123 Main St", 200.00f));
        AddCustomer(new Customer("John Smith", 35.ToString(), "123 Main St", 300.00f));
        AddCustomer(new Customer("Jane Smith", 40.ToString(), "123 Main St", 400.00f));
        AddCustomer(new Customer("John Johnson", 45.ToString(), "123 Main St", 500.00f));
        hasDummyData = true;
    }
}