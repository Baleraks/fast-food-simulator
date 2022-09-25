namespace DesktopApp.Models;

public class Order : Entity
{
    private static uint _orderCounter;

    public Order()
    {
        Id = ++_orderCounter;
    }
}