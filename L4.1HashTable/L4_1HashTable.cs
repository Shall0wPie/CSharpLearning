namespace ConsoleApp1;

public class L4_1HashTable : ILesson
{
    public void Run()
    {
        var hashTable = new HashTable<string>();
        
        hashTable.Add("1");
        hashTable.Add("21");
        hashTable.Add("31");
        hashTable.Add("4");
        
        Console.WriteLine($"Remove 31 - {hashTable.Remove("31")}");
        
        Console.WriteLine($"1 - {hashTable.Contains("1")}");
        Console.WriteLine($"21 - {hashTable.Contains("21")}");
        Console.WriteLine($"31 - {hashTable.Contains("31")}");
        Console.WriteLine($"4 - {hashTable.Contains("4")}");
        
        // Просто чек на то что кастомные типы норм работают с дженерик хэштейблом
        var hashTable2 = new HashTable<Element<int>>();
        
        var element1 = new Element<int>(1);
        var element2 = new Element<int>(2);
        var element3 = new Element<int>(33);
        
        hashTable2.Add(element1);
        hashTable2.Add(element2);
        hashTable2.Add(element3);
        
        Console.WriteLine($"Remove 3 - {hashTable2.Remove(element2)}");
        
        Console.WriteLine($"1 - {hashTable2.Contains(element1)}");
        Console.WriteLine($"3 - {hashTable2.Contains(element2)}");
        Console.WriteLine($"33 - {hashTable2.Contains(element3)}");
    }
}