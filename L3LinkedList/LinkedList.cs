using System.Collections;

namespace ConsoleApp1.L3LinkedList;

public abstract class LinkedList<T> : IEnumerable<T>
{
    public int Count { get; private set; }
    private readonly int _capacity;
    protected Element<T>? _first;
    protected Element<T>? _last;

    protected LinkedList() : this(0) { }

    protected LinkedList(int capacity)
    {
        _capacity = capacity;
        
    }

    protected void AddHead(T value)
    {
        if (IsInit(value))
            return;

        var newElement = new Element<T>(value, _first, null);
        _first.Previous = newElement;
        _first = newElement;
        Count++;
    }

    protected void AddBack(T value)
    {
        if (IsInit(value))
            return;

        var newElement = new Element<T>(value, null, _last);
        _last.Next = newElement;
        _last = newElement;
        Count++;
    }
    
    private bool IsInit(T value) 
    {
        // Ну название да такое себе, но чет фантазии нет назвать как то соответствующе действиям
        if (Count == _capacity && _capacity > 0)
            Clear();

        if (Count == 0)
        {
            var element = new Element<T>(value);
            _first = element;
            _last = element;
            Count++;
            
            return true;
        }

        return false;
    }

    public bool Contains(T value)
    {
        return IndexOf(value) != -1;
    }

    public int IndexOf(T value)
    {
        var index = 0;

        foreach (var item in this)
        {
            if (EqualityComparer<T>.Default.Equals(item, value))
            {
                return index;
            }
            index++;
        }
        
        return -1;
    }

    protected void RemoveAt(int index)
    {
        var element = Get(index);
        var next = element?.Next;
        var previous = element?.Previous;

        if (next != null)
            next.Previous = previous;
        else
            _last = previous;

        if (previous != null)
            previous.Next = next;
        else
            _first = next;

        Count--;
    }

    protected bool Remove(T value)
    {
        var index = IndexOf(value);

        if (index != -1)
        {
            RemoveAt(index);
            return true;
        }

        return false;
    }

    protected void Insert(int index, T value)
    {
        if (index == 0)
        {
            AddHead(value);
            return;
        }

        if (index == Count)
        {
            AddBack(value);
            return;
        }

        var current = Get(index);
        var element = new Element<T>(value, current, current.Previous);

        current.Previous.Next = element;
        current.Previous = element;
        Count++;
    }

    private Element<T> Get(int index)
    {
        if (index < 0 || index >= Count)
            throw new IndexOutOfRangeException();

        Element<T> element;

        if (Count / 2 >= index)
        {
            element = _first;

            for (var i = 0; i < index; i++)
            {
                element = element.Next;
            }
        }
        else
        {
            element = _last;

            for (var i = Count - 1; i > index; i--)
            {
                element = element.Previous;
            }
        }

        return element;
    }

    public void Clear()
    {
        _first = null;
        _last = null;
        Count = 0;
    }

    public T this[int index]
    {
        get => Get(index).Value;
        set => Get(index).Value = value;
    }

    public IEnumerator<T> GetEnumerator()
        => new Enumerator(_first);

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();

    private struct Enumerator : IEnumerator<T>
    {
        private Element<T?> _currentNode;
        public T? Current => _currentNode.Value;
        object? IEnumerator.Current => Current;

        public Enumerator(Element<T> first)
        {
            _currentNode = new Element<T?>(default, first, null);
        }

        public bool MoveNext()
        {
            if (_currentNode?.Next == null)
                return false;
            
            _currentNode = _currentNode?.Next;
            return true;

        }

        public void Reset()
        {
            _currentNode = null;
        }

        public void Dispose() { }
    }
}