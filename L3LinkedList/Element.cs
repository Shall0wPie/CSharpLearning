namespace ConsoleApp1.L3LinkedList;

public class Element<T>
{
    public Element<T>? Next { get; set; }
    public Element<T>? Previous { get; set; }
    public T Value { get; set; }

    public Element(T value) : this(value, null, null) { }
    public Element(T value, Element<T> next, Element<T> previous)
    {
        Value = value;
        Next = next;
        Previous = previous;
    }

    ~Element()
    {
        // Чекнуть что память не течет
        Console.WriteLine($"Element {Value} was destroyed");
    }
}