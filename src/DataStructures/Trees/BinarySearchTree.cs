namespace DataStructures.Trees;

public class BinarySearchTree<T> : IBinarySearchTree<T> where T : IComparable<T>
{
    private Node? _root;
    
    public int Count { get; private set; }
    public bool IsEmpty => Count == 0;
    
    public void Insert(T value)
    {
        _root = Insert(_root, value);
    }

    private Node Insert(Node? root, T value)
    {
        if (root is null)
        {
            Count++;
            return new Node(value);
        }

        int cmp = root.Value.CompareTo(value);

        if (cmp < 0)
        {
            root.Right = Insert(root.Right, value);
        }
        else if (cmp > 0)
        {
            root.Left = Insert(root.Left, value);
        }
        
        return root;
    }

    public bool Contains(T value)
    {
        return Contains(_root, value);
    }

    private bool Contains(Node? root, T value)
    {
        if (root is null)
        {
            return false;
        }

        int cmp = root.Value.CompareTo(value);

        if (cmp < 0)
        {
            return Contains(root.Right, value);
        }
        
        if (cmp > 0)
        {
            return Contains(root.Left, value);
        }

        return true;
    }

    public void Remove(T value)
    {
        _root = Remove(_root, value);
    }

    private Node? Remove(Node? root, T value)
    {
        if (root is null)
        {
            return null;
        }

        int cmp = root.Value.CompareTo(value);
        
        if (cmp < 0)
        {
            root.Right = Remove(root.Right, value);
        }
        else if (cmp > 0)
        {
            root.Left = Remove(root.Left, value);
        }
        else
        {
            if (root.Left is null)
            {
                Count--;
                return root.Right;
            }

            if (root.Right is null)
            {
                Count--;    
                return root.Left;
            }

            Node minNode = GetMinValueNode(root.Right);
            root.Value = minNode.Value;
            root.Right = Remove(root.Right, minNode.Value);
        }

        return root;
    }

    private Node GetMinValueNode(Node root)
    {
        Node currentNode = root;
        while (currentNode.Left != null)
        {
            currentNode = currentNode.Left;
        }

        return currentNode;
    }

    public IEnumerable<T> InOrder()
    {
        List<T> result = [];
        InOrder(_root, result);
        return result;
    }

    private void InOrder(Node? root, List<T> result)
    {
        if (root is null)
        {
            return;
        }

        InOrder(root.Left, result);
        result.Add(root.Value);
        InOrder(root.Right, result);
    }

    public IEnumerable<T> PreOrder()
    {
        List<T> result = [];
        PreOrder(_root, result);
        return result;
    }

    private void PreOrder(Node? root, List<T> result)
    {
        if (root is null)
        {
            return;
        }
        
        result.Add(root.Value);
        PreOrder(root.Left, result);
        PreOrder(root.Right, result);
    }

    public IEnumerable<T> PostOrder()
    {
        List<T> result = [];
        PostOrder(_root, result);
        return result;
    }

    private void PostOrder(Node? root, List<T> result)
    {
        if (root is null)
        {
            return;
        }

        PostOrder(root.Left, result);
        PostOrder(root.Right, result);
        result.Add(root.Value);
    }

    private sealed class Node(T value)
    {
        public T Value { get; set;  } = value;
        public Node? Left { get; set; }
        public Node? Right { get; set; }
    }
}