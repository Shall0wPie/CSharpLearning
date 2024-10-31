using ConsoleApp1.L7Delivery.Orders;

namespace ConsoleApp1.L7Delivery.Companies;

public abstract class Company
{
    public OrderInformation MakeOrderRequest(string address, string clientName, decimal orderPrice)
    {
        return new OrderInformation
        {
            Address = address,
            ClientName = clientName,
            OrderPrice = orderPrice
        };
    }
}