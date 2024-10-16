namespace ConsoleApp1;

public class Node
{
    public int Value { get; private set; }
    public int Count { get; set; }
    public Node? Left;
    public Node? Right;

    public Node(int value) : this(value, null, null){ }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Count = 1;
        Left = left;
        Right = right;
    }
}