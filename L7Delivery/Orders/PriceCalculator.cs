using ConsoleApp1.L7Delivery.Enums;

namespace ConsoleApp1.L7Delivery.Orders;

public static class PriceCalculator
{
    // Может куда то еще это можно перенести, а не хранить прямо в классе
    // Просто не хотелось хардкодить цены и запихал в словрь
    private static Dictionary<ConsumableType, decimal> consumablePrices = new()
    {
        { ConsumableType.DefaultBox, 10 },
        { ConsumableType.SolidBox, 30 },
        { ConsumableType.ColoredBox, 40 },
        { ConsumableType.ColoredTape, 15 },
        { ConsumableType.Filler, 45 }
    };
    
    public static decimal CalculatePrice(OrderInformation orderInformation)
    {
        var additionalPrice = 0M;

        // Цена за наполнитель
        if (orderInformation.IsFragile)
            additionalPrice += consumablePrices[ConsumableType.Filler];

        // Цена за тип коробки
        additionalPrice += orderInformation.BoxType switch
        {
            BoxType.Deffault => consumablePrices[ConsumableType.DefaultBox],
            BoxType.Solid => consumablePrices[ConsumableType.SolidBox],
            _ => 0M
        };
        
        // Цена за цветную коробку
        if (orderInformation.BoxColor is not null)
            additionalPrice += consumablePrices[ConsumableType.ColoredBox];
        
        // Цена за цветную ленту
        if (orderInformation.TapeColor is not null)
            additionalPrice += consumablePrices[ConsumableType.ColoredTape];
            
        return additionalPrice + orderInformation.OrderPrice;
    }
}