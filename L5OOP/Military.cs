namespace ConsoleApp1.L5OOP;

public class Military : Customer
{
    public Military(string fullName, DateTime birthDate, WeaponType desiredWeapon) 
        : base(fullName, birthDate, desiredWeapon)
    {
    }
    
    public override string ToString()
    {
        return "военный";
    }
}