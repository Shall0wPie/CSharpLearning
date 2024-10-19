namespace ConsoleApp1.L3LinkedList;

public class List<T> : LinkedList<T>
{
    public new void AddHead(T value)
        => base.AddHead(value);

    public new void AddBack(T value)
        => base.AddBack(value);
    
    public new void RemoveAt(int index)
        => base.RemoveAt(index);
    
    public new bool Remove(T value)
        => base.Remove(value);
    
    public new void Insert(int index, T value)
        => base.Insert(index, value);
}