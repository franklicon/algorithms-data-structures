namespace DataStructures.Stacks;

public interface IStack<T>
{
    int Count { get; }
    bool IsEmpty { get; }
    void Push(T value);
    T Pop();
    T Peek();
    bool Contains(T value);
}