namespace DesktopApp.Models;

public class Server
{
    public Queue<Order> OrdersReady { get; }

    public uint DeliveryTime { get; set; }

    public Server(Queue<Order> ordersReady, uint deliveryTime)
    {
        OrdersReady = ordersReady;
        DeliveryTime = deliveryTime;
    }

    public void DeliverOrder(Order order)
    {
        //server is delivering an order
        Thread.Sleep(Convert.ToInt32(DeliveryTime));

        OrdersReady.Enqueue(order);
    }
}