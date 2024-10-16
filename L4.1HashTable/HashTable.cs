namespace ConsoleApp1;

public class HashTable<T>
{
    protected uint _size;
    protected List<T>[] _arr;

    public HashTable() : this(10) { }
    
    public HashTable(uint size)
    {
        _size = size;
        _arr = new List<T>[_size];

        for (var i = 0; i < _size; i++)
        {
            _arr[i] = new List<T>();
        }
    }

    public void Add(T value)
    {
        var index = GetHash(value);
        var list = _arr[index];
        
        list.AddBack(value);
    }

    public bool Contains(T value)
    {
        var index = GetHash(value);

        return _arr[index].Contains(value);
    }

    public bool Remove(T value)
    {
        var index = GetHash(value);

        return _arr[index].Remove(value);
    }

    protected uint GetHash(T value)
    {
        return unchecked((uint)value.GetHashCode() % _size);
    }
}