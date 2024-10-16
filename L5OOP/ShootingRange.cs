namespace ConsoleApp1;

public class ShootingRange
{
    private Warehouse warehouse;

    public ShootingRange()
    {
        warehouse = new Warehouse();
    }
    
    public void Enter(Customer customer)
    {
        try
        {
            CheckLicense(customer);
            GoShooting(customer);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Шуруй от сюда {customer.FullName}");
        }
    }

    private void CheckLicense(Customer customer)
    {
        if (customer is Military)
            return;
        
        var civilian = customer as Civilian;
        
        if (civilian.HaveLicense)
            return;

        throw new AccessViolationException(); // ну а что, вполне себе аксес вайолэйшн
    }

    private void GoShooting(Customer customer)
    {
        var weapon = warehouse.GiveWeapon(customer.DesiredWeapon);
        
        Console.WriteLine($"{customer.FullName} {customer} {customer.BirthDate.Year} года рождения стреляет из {weapon.GetType().Name}");
        customer.PerformShooting(weapon);
    }
}