using ConsoleApp1.L7Delivery.Enums;
using ConsoleApp1.L7Delivery.Orders;

namespace ConsoleApp1.L7Delivery.Companies;

public class GoldSecret : Company
{
    public OrderInformation MakeOrderRequest(string address, string clientName, decimal orderPrice)
    {
        return new OrderInformation
        {
            Address = address,
            ClientName = clientName,
            OrderPrice = orderPrice,
            Priority = PriorityLevel.High,
            BoxType = BoxType.Solid,
            IsFragile = true
        };
    }
}