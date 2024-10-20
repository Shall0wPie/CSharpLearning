using ConsoleApp1.L6Pets.Factory;
using ConsoleApp1.L6Pets.Factory.Pets;

namespace ConsoleApp1.L6Pets;

public static class Application
{
    private static List<Client> _clients = new();
    private static List<Pet> _pets = new();
    private static List<Order> _orders = new();

    public static void AddOrder(string clientName, string clientPhone, string petName, PetTypes petType)
    {
        var client = _clients.Find(client => client.Name == clientName && client.PhoneNumber == clientPhone);
        var pet = _pets.Find(pet => pet.Name == petName);

        if (client == null)
        {
            client = new Client(clientName, clientPhone);
            _clients.Add(client);
        }

        if (pet == null)
        {
            pet = PetFactory.CreatePet(petType, petName);
            _pets.Add(pet);
        }
        
        // Если что то не создалось, то не создаем заказ.
        if (pet != null && client != null)
            _orders.Add(new Order(client, pet));
    }

    public static void GetOrdersInfo()
    {
        foreach (var order in _orders)
        {
            Console.WriteLine($"Заказ клиента {order.Client.Name} для питомца {order.Pet.Name} от {order.OrderDate}" +
                              $" стоимостью {order.Price} руб.");
        }
    }
}