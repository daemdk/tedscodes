public enum OrderState { New, Processing, Shipped, Delivered, Canceled }

public class Order
{
    public int OrderId { get; set; }
    public OrderState State { get; private set; }

    public Order()
    {
        State = OrderState.New;
    }

    public void ProcessOrder()
    {
        if (State == OrderState.New)
        {
            Console.WriteLine("Processing order...");
            State = OrderState.Processing;
        }
        else
        {
            Console.WriteLine("Order cannot be processed in the current state.");
        }
    }

    public void ShipOrder()
    {
        if (State == OrderState.Processing)
        {
            Console.WriteLine("Shipping order...");
            State = OrderState.Shipped;
        }
        else
        {
            Console.WriteLine("Order cannot be shipped in the current state.");
        }
    }

    public void DeliverOrder()
    {
        if (State == OrderState.Shipped)
        {
            Console.WriteLine("Delivering order...");
            State = OrderState.Delivered;
        }
        else
        {
            Console.WriteLine("Order cannot be delivered in the current state.");
        }
    }

    public void CancelOrder()
    {
        if (State == OrderState.New || State == OrderState.Processing)
        {
            Console.WriteLine("Canceling order...");
            State = OrderState.Canceled;
        }
        else
        {
            Console.WriteLine("Order cannot be canceled in the current state.");
        }
    }
}