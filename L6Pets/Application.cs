namespace ConsoleApp1.L6Pets;

public static class Application
{
    private static List<Client> Clients = new List<Client>();
    private static List<Pet> Pets = new List<Pet>();

    public static void AddOrder(string clientName, string clientPhone, string petName)
    {
        var client = Clients.Find(c => c.Name == clientName && c.PhoneNumber == clientPhone);
        var pet = Pets.Find(p => p.Name == petName);

        if (client == null)
        {
            client = new Client(clientName, clientPhone);
            Clients.Add(client);
        }

        if (pet == null)
        {
            pet = new Pet(petName, client);
        }
    }
}