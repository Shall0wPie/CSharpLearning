namespace ConsoleApp1.L6Pets;

public class L6Pets : ILesson
{
    public void Run()
    {
        Application.AddOrder("Петя", "79990000001", "Хулиган", PetTypes.Shlepa);
        Application.AddOrder("Петя", "79990000001", "Чимс", PetTypes.Doge);
        Application.AddOrder("Анна", "79990000002", "Чмоня", PetTypes.Chmonya);
        Application.AddOrder("Виктория", "79990000003", "Чимс", PetTypes.Doge);
        Application.AddOrder("Гена", "79990000004", "Бутус", PetTypes.SobakaBarabaka);
        
        Application.GetOrdersInfo();
    }
}