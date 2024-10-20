using ConsoleApp1.L6Pets.Factory.Pets;

namespace ConsoleApp1.L6Pets;

public class Order
{
    public readonly Client Client;
    public readonly Pet Pet;
    public readonly DateTime OrderDate;
    public readonly float Price;

    public Order(Client client, Pet pet)
    {
        Client = client;
        Pet = pet;
        OrderDate = DateTime.Now;
        Price = PriceCalculator.CalculatePrice(pet);
    }
}