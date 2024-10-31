using ConsoleApp1.L7Delivery.Enums;

namespace ConsoleApp1.L7Delivery.Orders;

public class OrderInformation
{
    public required string Address { get; init; }
    public required string ClientName { get; init; }
    public required decimal OrderPrice { get; init; }

    public PriorityLevel Priority { get; init; } = PriorityLevel.Low;
    public bool IsFragile { get; init; } = false;
    public BoxType BoxType { get; init; } = BoxType.Deffault;
    public Colors? BoxColor { get; init; }
    public Colors? TapeColor { get; init; }
}