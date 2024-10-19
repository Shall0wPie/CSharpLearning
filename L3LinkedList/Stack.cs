namespace ConsoleApp1.L3LinkedList;

public class Stack<T> : LinkedList<T>
{
    public Stack() : base() { }
    
    public Stack(int capacity) : base(capacity) { }
    
    public void Push(T value)
    {
        AddHead(value);
    }

    public T Peek()
    {
        return _first.Value;
    }

    public T Pop()
    {   
        T value = _first.Value;
        
        RemoveAt(0);

        return value;
    }
}