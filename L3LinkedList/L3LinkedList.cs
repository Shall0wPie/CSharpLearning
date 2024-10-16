namespace ConsoleApp1;

public class L3LinkedList : ILesson
{
    public void Run()
    {
        Console.WriteLine("Начало работы");
        
        var queue = new Queue<int>(2);
        var stack = new Stack<int>(3);
        var arr = new int[] { 5, 10, 15, 20, 25 };
        
        Console.WriteLine("Переменные инициализированы");

        foreach (var element in arr)
        {
            queue.Enqueue(element);
            stack.Push(element);
        }
        
        Console.WriteLine("Очередь и Стек заполнены");
        Console.WriteLine("\nРабота с Очередью");

        while (queue.Count > 0)
        {
            Console.WriteLine($"Получил значение: {queue.Peek()}");
            Console.WriteLine($"Удалил значение: {queue.Dequeue()}");
        }
        
        Console.WriteLine("\nРабота со Стеком");
        
        while (stack.Count > 0)
        {
            Console.WriteLine($"Получил значение: {stack.Peek()}");
            Console.WriteLine($"Удалил значение: {stack.Pop()}");
        }
    }
}