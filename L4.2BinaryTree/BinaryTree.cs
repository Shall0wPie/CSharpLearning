namespace ConsoleApp1;

public class BinaryTree
{
    private Node? _root;

    public void Insert(int value)
    {
        if (_root == null)
        {
            _root = new Node(value);
            return;
        }

        var current = _root;
        
        while (true)
        {
            if (current.Value == value)
            {
                current.Count++;
                return;
            }

            if (value > current.Value)
            {
                if (current.Right == null)
                {
                    current.Right = new Node(value);
                    return;
                }
                
                current = current.Right;
            }
            else
            {
                if (current.Left == null)
                {
                    current.Left = new Node(value);
                    return;
                }
                 
                current = current.Left;
            }
        }
    }

    public bool FindElement(int value, out int count)
    {
        var current = _root;
        count = 0;

        while (current != null)
        {
            if (current.Value == value)
            {
                count = current.Count;
                return true;
            }
            
            current =  value > current.Value ? current.Right : current.Left;
        }

        return false;
    }
}