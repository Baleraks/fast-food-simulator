using System.Text;
using DesktopApp.Models;

namespace DesktopApp.Services;

public class Simulator
{
    private readonly Queue<Customer> _queueToOrderTaker;

    private readonly Queue<Customer> _queueToServer;

    private readonly Queue<Order> _ordersToCook;

    private readonly Queue<Order> _cookReadyOrders;

    private readonly Queue<Order> _serverReadyOrders;

    private readonly OrderTaker _orderTaker;

    private readonly Kitchen _kitchen;

    private readonly Server _server;

    private readonly MainForm _form;

    public Simulator(MainForm form,uint cookLeadTime, uint orderTakerOrderingTime, uint customerArrivalTime, uint serverDeliveryTime, uint customerOrderPickUpTime)
    {
        _form = form;
        _queueToOrderTaker = new Queue<Customer>();
        _queueToServer = new Queue<Customer>();
        _ordersToCook = new Queue<Order>();
        _cookReadyOrders = new Queue<Order>();
        _serverReadyOrders = new Queue<Order>();

        _orderTaker = new OrderTaker(_ordersToCook, orderTakerOrderingTime);
        _kitchen = new Kitchen(_ordersToCook, _cookReadyOrders, cookLeadTime);
        _server = new Server(_serverReadyOrders, serverDeliveryTime);

        CookLeadTime = cookLeadTime;
        CustomerArrivalTime = customerArrivalTime;
        OrderTakerOrderingTime = orderTakerOrderingTime;
        ServerDeliveryTime = serverDeliveryTime;
        CustomerOrderPickUpTime = customerOrderPickUpTime;

        IsSimulatorWorking = true;
    }

    public uint CustomerArrivalTime { get; set; }

    public uint CookLeadTime { get; set; }

    public uint OrderTakerOrderingTime
    {
        get => _orderTaker.TimeToOrder;
        set => _orderTaker.TimeToOrder = value;
    }

    public uint ServerDeliveryTime
    {
        get => _server.DeliveryTime;
        set => _server.DeliveryTime = value;
    }

    public uint CustomerOrderPickUpTime { get; set; }

    public bool IsSimulatorWorking { get; set; }

    public int NumberOfCustomersWaitingToPlaceOrder => _queueToOrderTaker.Count;

    public string CurrentOrder => _kitchen.CurrentOrder == null ? "null" : _kitchen.CurrentOrder.Id.ToString();

    public int CountOfWaitingOrders => _ordersToCook.Count;

    public int ContOfCurrentlyAvailableOrders => _serverReadyOrders.Count;

    public int CountOfWaitingCustomers => _queueToServer.Count;

    public string OrdersReadyToCook
    {
        get
        {
            var answer = new StringBuilder();

            foreach (var order in _ordersToCook)
            {
                answer.Append(order.Id + " ");
            }

            return answer.ToString();
        }
    }

    public string CurrentOrderTakerOrder => _orderTaker.CurrentOrder == null ? "null" : _orderTaker.CurrentOrder.Id.ToString();

    public void Start()
    {
        IsSimulatorWorking = true;
        Task.Run(GenerateCustomers);
        Task.Run(OrderTakerWork);
        Task.Run(CookWork);
        Task.Run(ServerWork);
        Task.Run(QueueToServerWork);
    }

    private void GenerateCustomers()
    {
        while (IsSimulatorWorking)
        {
            Thread.Sleep((int)CustomerArrivalTime);
            _queueToOrderTaker.Enqueue(new Customer());
            _form.Update();
        }
    }

    private void OrderTakerWork()
    {
        while (IsSimulatorWorking)
        {
            if (_queueToOrderTaker.Count <= 0) continue;

            var customer = _queueToOrderTaker.Dequeue();
            _orderTaker.ReceiveAnOrder(customer);
            _queueToServer.Enqueue(customer);
            _form.Update();
        }
    }

    private void CookWork()
    {
        while (IsSimulatorWorking)
        {
            if (_ordersToCook.Count <= 0) continue;

            _kitchen.CookAnOrder();
            _form.Update();
        }
    }

    private void ServerWork()
    {
        while (IsSimulatorWorking)
        {
            if (_cookReadyOrders.Count <= 0) continue;

            _server.DeliverOrder(_cookReadyOrders.Dequeue());
            _form.Update();
        }
    }

    private void QueueToServerWork()
    {
        while (IsSimulatorWorking)
        {
            if (_queueToServer.Count <= 0 || _serverReadyOrders.Count <= 0) continue;

            Thread.Sleep((int)CustomerOrderPickUpTime);
            _serverReadyOrders.Dequeue();
            _queueToServer.Dequeue();

        }
    }
}