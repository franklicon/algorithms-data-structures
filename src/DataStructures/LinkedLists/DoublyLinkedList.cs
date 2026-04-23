namespace DataStructures.LinkedLists;

public class DoublyLinkedList<T>
{
    private Node? _head;
    private Node? _tail;
    
    public int Count { get; private set; }
    public bool IsEmpty => Count == 0;

    public void AddFirst(T value)
    {
        Node newNode = new(value);
        
        if (IsEmpty)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _head!.Previous = newNode;
            newNode.Next = _head;
            _head = newNode;
        }
        
        Count++;
    }

    public void AddLast(T value)
    {
        Node newNode = new(value);

        if (IsEmpty)
        {
            _head = newNode;
        }
        else
        {
            _tail!.Next = newNode;
            newNode.Previous = _tail;
        }

        _tail = newNode;
        Count++;
    }

    public T RemoveFirst()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("The list is empty");
        }

        T value = _head!.Value;
        _head = _head.Next;

        if (_head is null)
        {
            _tail = null;
        }
        else
        {
            _head.Previous = null;
        }

        Count--;
        return value;
    }

    public T RemoveLast()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("The list is empty");
        }

        T value = _tail!.Value;
        _tail = _tail.Previous;
        if (_tail is null)
        {
            _head = null;
        }
        else
        {
            _tail.Next = null;
        };

        Count--;
        return value;
    }

    public bool Contains(T value)
    {
        Node? currentNode = _head;
        EqualityComparer<T> comparer = EqualityComparer<T>.Default;
        
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
        public Node? Previous { get; set; }
    }
}