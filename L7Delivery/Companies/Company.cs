using ConsoleApp1.L7Delivery.Orders;

namespace ConsoleApp1.L7Delivery.Companies;

public abstract class Company
{
    public event EventHandler<MyEventArgs> NewOrderEvent;

    protected Company()
    {
        OrderManager.RegisterCompany(this);
    }
    
    public void MakeOrderRequest(string address, string clientName, decimal orderPrice)
    {
        var orderInformation = new OrderInformation
        {
            Address = address,
            ClientName = clientName,
            OrderPrice = orderPrice
        };

        SendEvent(orderInformation);
    }

    protected void SendEvent(OrderInformation orderInformation)
    {
        NewOrderEvent.Invoke(this, new MyEventArgs { OrderInformation = orderInformation });
    }
}

// Не знаю правильно ли в этом же файле это объявлять или это нужно переносить в другой
public class MyEventArgs : EventArgs
{
    public OrderInformation OrderInformation { get; init; } 
}