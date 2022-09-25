namespace DesktopApp.Models;

public class OrderTaker
{
    public Order? CurrentOrder { get; private set; }

    public Queue<Order> OrdersToCook { get; }

    public uint TimeToOrder { get; set; }

    public OrderTaker(Queue<Order> ordersToCook, uint timeToOrder)
    {
        OrdersToCook = ordersToCook;
        TimeToOrder = timeToOrder;
    }

    public void ReceiveAnOrder(Customer customer)
    {
        if (customer == null)
        {
            throw new NullReferenceException("Customer cannot be null.");
        }

        CurrentOrder = customer.MakeAnOrder(TimeToOrder);

        OrdersToCook.Enqueue(CurrentOrder);
    }
}