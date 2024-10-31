using ConsoleApp1.L7Delivery.Companies;

namespace ConsoleApp1.L7Delivery.Orders;

public class Order
{
    public Company Requester { get; private set; }
    public OrderInformation OrderInformation { get; private set; }
    public decimal TotalPrice { get; private set; }
    public DateTime OrderDate { get; private set; }

    public Order(Company requester, OrderInformation orderInformation, decimal totalPrice)
    {
        Requester = requester;
        OrderInformation = orderInformation;
        TotalPrice = totalPrice;
        OrderDate = DateTime.Now;
    }
}