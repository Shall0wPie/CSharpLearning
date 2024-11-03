using System.Drawing;
using ConsoleApp1.L7Delivery.Enums;
using ConsoleApp1.L7Delivery.Orders;

namespace ConsoleApp1.L7Delivery.Companies;

public class MagicColor : Company
{
    public void MakeOrderRequest(string address, string clientName, decimal orderPrice, Colors boxColor, Colors tapeColor)
    {
        var orderInformation = new OrderInformation
        {
            Address = address,
            ClientName = clientName,
            OrderPrice = orderPrice,
            BoxColor = boxColor,
            TapeColor = tapeColor
        };
        
        SendEvent(orderInformation);
    }
}