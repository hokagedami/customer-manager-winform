namespace CustomerManager.Libraries.Entities;

public class Customer(string name, string age, string address, float amountOwed)
{
    public string Name { get; set; } = name;
    public string Age { get; set; } = age;
    public string Address { get; set; } = address;
    public float AmountOwed { get; set; } = amountOwed;

    public string GetInformation()
    {
        return $"Name: {Name}, Age: {Age}, Address: {Address}, Amount Owed: {AmountOwed}";
    }
}