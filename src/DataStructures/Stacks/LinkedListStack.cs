namespace DataStructures.Stacks;

public class LinkedListStack<T> : IStack<T>
{
    private Node? _top;
        
    public int Count { get; private set; }

    public bool IsEmpty => Count == 0;

    public void Push(T value)
    {
        Node newNode = new(value)
        {
            Next = _top
        };
        _top = newNode;
        Count++;
    }

    public T Pop()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("The stack is empty");
        }

        T value = _top!.Value;
        _top = _top.Next;
        Count--;
        
        return value;
    }

    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("The stack is empty");
        }

        T value = _top!.Value;

        return value;
    }

    public bool Contains(T value)
    {
        EqualityComparer<T> comparer = EqualityComparer<T>.Default;

        Node? currentNode = _top;

        while (currentNode != null)
        {
            if (comparer.Equals(currentNode.Value, value))
            {
                return true;
            }

            currentNode = currentNode.Next;
        }

        return false;
    }

    private sealed class Node(T value)
    {
        public T Value { get; } = value;
        public Node? Next { get; set; }
    }
}