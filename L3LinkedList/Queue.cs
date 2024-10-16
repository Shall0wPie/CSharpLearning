namespace ConsoleApp1;

public class Queue<T> : LinkedList<T>
{
    public Queue() : base() { }
    public Queue(int capacity) : base(capacity) { }
    
    public void Enqueue(T item)
    {
        AddBack(item);
    }

    public T Dequeue()
    {
        T value = _first.Value;
        
        RemoveAt(0);
        
        return value;
    }

    public T Peek()
    {
        return _first.Value;
    }
    
}