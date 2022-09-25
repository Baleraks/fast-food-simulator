namespace DesktopApp.Models;

public class Kitchen
{
    public Order? CurrentOrder { get; private set; }

    public Queue<Order> OrdersToCook { get; }
    public Queue<Order> OrdersReady { get; }

    public uint CookTime { get; }

    public Kitchen(Queue<Order> ordersToCook, Queue<Order> ordersReady, uint cookTime)
    {
        OrdersToCook = ordersToCook;
        OrdersReady = ordersReady;
        CookTime = cookTime;
    }

    public void CookAnOrder()
    {
        CurrentOrder = OrdersToCook.Dequeue();

        //kitchen cooking an order
        Thread.Sleep(Convert.ToInt32(CookTime));

        OrdersReady.Enqueue(CurrentOrder);
    }
}