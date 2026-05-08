namespace DataStructures.Queues;

public interface IQueue<T>
{
    int Count { get; }
    bool IsEmpty { get; }
    void Enqueue(T value);
    T Dequeue();
    T Peek();
    bool Contains(T value);
}
