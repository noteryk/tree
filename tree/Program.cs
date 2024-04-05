using System;

public class Node
{
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int value)
    {
        Value = value;
    }
}

public class BinarySearchTree
{
    public Node Root { get; set; }

    public BinarySearchTree()
    {
        Root = null;
    }

    public void Add(int value)
    {
        if (Root == null)
        {
            Root = new Node(value);
        }
        else
        {
            AddRecursive(Root, value);
        }
    }

    private void AddRecursive(Node current, int value)
    {
        if (value % 2 == 0)
        {
            if (current.Left == null)
            {
                current.Left = new Node(value);
            }
            else
            {
                AddRecursive(current.Left, value);
            }
        }
        else
        {
            if (current.Right == null)
            {
                current.Right = new Node(value);
            }
            else
            {
                AddRecursive(current.Right, value);
            }
        }
    }

    public bool Contains(int value)
    {
        return ContainsRecursive(Root, value);
    }

    private bool ContainsRecursive(Node current, int value)
    {
        if (current == null)
        {
            return false;
        }

        if (current.Value == value)
        {
            return true;
        }

        return value < current.Value
            ? ContainsRecursive(current.Left, value)
            : ContainsRecursive(current.Right, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree tree = new BinarySearchTree();

        tree.Add(10);
        tree.Add(5);
        tree.Add(15);
        tree.Add(3);
        tree.Add(7);
        tree.Add(13);
        tree.Add(17);

        Console.WriteLine("Czy 10 jest w drzewie? " + tree.Contains(10));
        Console.WriteLine("Czy 15 jest w drzewie? " + tree.Contains(15));
        Console.WriteLine("Czy 20 jest w drzewie? " + tree.Contains(20));

    }
}
