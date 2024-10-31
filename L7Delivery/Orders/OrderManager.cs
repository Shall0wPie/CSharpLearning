using ConsoleApp1.L7Delivery.Companies;

namespace ConsoleApp1.L7Delivery.Orders;

public static class OrderManager
{
    private static List<Order> orders = new List<Order>();

    public static void CreateNewOrder(Company requester, OrderInformation orderInformation)
    {
        var totalPrice = PriceCalculator.CalculatePrice(orderInformation);

        orders.Add(new Order(requester, orderInformation, totalPrice));
    }

    public static void SendOrdersToDelivery(int orderAmount)
    {
        if (orderAmount > orders.Count)
            orderAmount = orders.Count;
        
        var orderedList = orders.OrderBy(order => order.OrderInformation.Priority);

        Console.WriteLine();
        Console.WriteLine("Курьер забрал следующие заказы");
        
        for (int i = 0; i < orderAmount; i++)
        {
            var currentOrder = orderedList.First();
            Console.WriteLine(GetFullOrderDetails(currentOrder));
            orders.Remove(currentOrder);
        }
    }

    public static void ShowOrderList()
    {
        var orderedList = orders.OrderBy(order => order.OrderInformation.Priority);

        Console.WriteLine();

        foreach (var order in orderedList)
        {
            Console.WriteLine(GetFullOrderDetails(order));
        }
    }

    private static string GetFullOrderDetails(Order order)
    {
        return $"Заказ компании {order.Requester.GetType().Name} от {order.OrderDate} для клиента {order.OrderInformation.ClientName}\n" +
               $" - Цена заказа: {order.TotalPrice}\n" +
               $" - Адрес: {order.OrderInformation.Address}\n" +
               $" - Детали заказа: \n{GetOrderDetails(order.OrderInformation)}" +
               "----------------------------------------";
    }

    private static string GetOrderDetails(OrderInformation orderInformation)
    {
        var details = "";

        details += $"Срочность заказа: {orderInformation.Priority}\n";
        
        details += $"Тип коробки: {orderInformation.BoxType}\n";
        
        if (orderInformation.BoxColor is not null)
            details += $"Цвет коробки: {orderInformation.BoxColor}\n";

        if (orderInformation.TapeColor is not null)
            details += $"Цвет ленты: {orderInformation.TapeColor}\n";
        
        if (orderInformation.IsFragile)
            details += "С наполнителем\n";
        
        return details;
    }
}