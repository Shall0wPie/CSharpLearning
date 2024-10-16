namespace ConsoleApp1;

public class L4_2BinaryTree : ILesson
{
    public void Run()
    {
        var tree = new BinaryTree();
        var arr = new int[] { 7, 9, 4, 3, 12, 9, 8, 10, 7, 4, 5, 6, 13, 8, 9 };

        foreach (var item in arr)
        {
            tree.Insert(item);
        }

        var distinctArray = arr
            .Distinct()
            .Order() // Почему это отдельный тип блин???
            .Append(2) // Проверить что отсутствующие элементы норм отрабатывают
            .Append(11); 
        
        foreach (var item in distinctArray)
        {
            int count;
            tree.FindElement(item, out count);
            Console.WriteLine($"{item}: {count}");
        }
    }
}