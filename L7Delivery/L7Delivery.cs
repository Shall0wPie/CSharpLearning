﻿using ConsoleApp1.L7Delivery.Companies;
using ConsoleApp1.L7Delivery.Enums;
using ConsoleApp1.L7Delivery.Orders;

namespace ConsoleApp1.L7Delivery;

public class L7Delivery : ILesson
{
    public void Run()
    {
        var goldSecret  = new GoldSecret();
        var magicColor = new MagicColor();
        var simpleFirm = new SimpleFirm();
        
        OrderManager.CreateNewOrder(
            goldSecret,
            goldSecret.MakeOrderRequest("Адрес1", "Биба", 80));
        
        OrderManager.CreateNewOrder(
            magicColor,
            magicColor.MakeOrderRequest("Адрес2", "Стас Барецкий", 100, Colors.Red, Colors.Yellow));
        
        OrderManager.CreateNewOrder(
            goldSecret,
            goldSecret.MakeOrderRequest("Адрес3", "Боба", 90));
        
        OrderManager.CreateNewOrder(
            simpleFirm,
            simpleFirm.MakeOrderRequest("Адрес4", "Чича", 50));
        
        Console.WriteLine("Текущие заказы");
        OrderManager.ShowOrderList();
        
        OrderManager.SendOrdersToDelivery(3);
        
        Console.WriteLine("Оставшиеся заказы");
        OrderManager.ShowOrderList();
    }
}