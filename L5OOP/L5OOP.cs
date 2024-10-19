namespace ConsoleApp1.L5OOP;

public class L5OOP : ILesson
{
    //https://app.diagrams.net/#G1JJWsLrfqf0Nt83Gp3XUd76CCUzb1jgbp#%7B%22pageId%22%3A%22JpzVyssMgkn1Ju5VMRQM%22%7D
    public void Run()
    {
        // Можно было и статиком сделать, но решил бахнуть композицию со складом
        var shootingRange = new ShootingRange();

        Customer[] customers =
        [
            new Military("Прапорщик Задов", new DateTime(1973, 9, 10), WeaponType.AK47),
            new Civilian("Володька", new DateTime(2003, 7, 5), WeaponType.M4A1, false),
            new Military("Наталья морская пехота", new DateTime(1961, 2, 22), WeaponType.AK47),
            new Civilian("Виталий Цаль", new DateTime(1990, 11, 19), WeaponType.M4A1, true),
            new Civilian("Артём Выживалово", new DateTime(1991, 7, 26), WeaponType.AK47, true)
        ];

        foreach (var customer in customers)
        {
            shootingRange.Enter(customer);
        }
    }
}