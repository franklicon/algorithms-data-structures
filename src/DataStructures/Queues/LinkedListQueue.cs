namespace DataStructures.Queues;

public class LinkedListQueue<T>
{
    private Node? _head;
    private Node? _tail;
    
    public int Count { get; private set; }
    public bool IsEmpty => Count == 0;

    public void Enqueue(T value)
    {
        Node newNode = new(value);

        if (IsEmpty)
        {
            _head = newNode;
        }
        else
        {
            _tail!.Next = newNode;
        }

        _tail = newNode;

        Count++;
    }

    public T Dequeue()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T value = _head!.Value;
        _head = _head.Next;
        Count--;

        if (_head is null)
        {
            _tail = null;
        }
            
        return value;
    }

    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T value = _head!.Value;
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
    }
}
