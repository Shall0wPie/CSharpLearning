namespace ConsoleApp1.L6Pets;

public class Pet
{
    public readonly string Name;
    public readonly Client Owner;

    public Pet(string name, Client owner)
    {
        Name = name;
        Owner = owner;
    }
}