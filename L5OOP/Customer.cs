namespace ConsoleApp1.L5OOP;

public abstract class Customer
{
    public string FullName { get; }
    public DateTime BirthDate { get; }
    public WeaponType DesiredWeapon { get; }

    protected Customer(string fullName, DateTime birthDate, WeaponType desiredWeapon)
    {
        FullName = fullName;
        BirthDate = birthDate;
        DesiredWeapon = desiredWeapon;
    }

    public void PerformShooting(Weapon weapon)
    {
        weapon.Shoot();
    }
}