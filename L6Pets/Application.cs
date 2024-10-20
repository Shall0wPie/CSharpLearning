using ConsoleApp1.L6Pets.Factory;
using ConsoleApp1.L6Pets.Factory.Pets;

namespace ConsoleApp1.L6Pets;

public static class Application
{
    private static List<Client> Clients = new();
    private static List<Pet> Pets = new();
    private static List<Order> Orders = new();

    public static void AddOrder(string clientName, string clientPhone, string petName, PetTypes petType)
    {
        var client = Clients.Find(client => client.Name == clientName && client.PhoneNumber == clientPhone);
        var pet = Pets.Find(pet => pet.Name == petName);

        if (client == null)
        {
            client = new Client(clientName, clientPhone);
            Clients.Add(client);
        }

        if (pet == null)
        {
            pet = PetFactory.CreatePet(petType, petName);
            Pets.Add(pet);
        }
        
        // Если что то не создалось, то не создаем заказ.
        if (pet != null && client != null)
            Orders.Add(new Order(client, pet));
    }

    public static void GetOrdersInfo()
    {
        foreach (var order in Orders)
        {
            Console.WriteLine($"Заказ клиента {order.Client.Name} для питомца {order.Pet.Name} от {order.OrderDate}" +
                              $" стоимостью {order.Price} руб.");
        }
    }
}