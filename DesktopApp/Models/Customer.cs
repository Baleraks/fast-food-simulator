namespace DesktopApp.Models;

public class Customer : Entity
{
    private static uint _customerCounter;

    public Customer()
    {
        Id = ++_customerCounter;
    }

    public Order MakeAnOrder(uint timeToOrder)
    {
        //customer is thinking
        Thread.Sleep(Convert.ToInt32(timeToOrder));

        return new Order();
    }
}