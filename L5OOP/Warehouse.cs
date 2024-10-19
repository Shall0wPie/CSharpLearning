namespace ConsoleApp1.L5OOP;

public class Warehouse
{
    public Weapon GiveWeapon(WeaponType weaponType)
    {
        return weaponType switch
        {
            WeaponType.AK47 => new АК47(),
            WeaponType.M4A1 => new M4A1()
        };
    }
}