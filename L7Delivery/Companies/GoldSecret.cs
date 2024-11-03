using ConsoleApp1.L7Delivery.Enums;
using ConsoleApp1.L7Delivery.Orders;

namespace ConsoleApp1.L7Delivery.Companies;

public class GoldSecret : Company
{
    public void MakeOrderRequest(string address, string clientName, decimal orderPrice)
    {
        var orderInformation =  new OrderInformation
        {
            Address = address,
            ClientName = clientName,
            OrderPrice = orderPrice,
            Priority = PriorityLevel.High,
            BoxType = BoxType.Solid,
            IsFragile = true
        };
        
        SendEvent(orderInformation);
    }
}