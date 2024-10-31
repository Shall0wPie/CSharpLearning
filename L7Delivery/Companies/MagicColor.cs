using System.Drawing;
using ConsoleApp1.L7Delivery.Enums;
using ConsoleApp1.L7Delivery.Orders;

namespace ConsoleApp1.L7Delivery.Companies;

public class MagicColor : Company
{
    public OrderInformation MakeOrderRequest(string address, string clientName, decimal orderPrice, Colors boxColor, Colors tapeColor)
    {
        return new OrderInformation
        {
            Address = address,
            ClientName = clientName,
            OrderPrice = orderPrice,
            BoxColor = boxColor,
            TapeColor = tapeColor
        };
    }
}