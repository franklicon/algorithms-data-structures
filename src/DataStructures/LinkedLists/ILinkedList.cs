namespace DataStructures.LinkedLists;

public interface ILinkedList<T>
{
    int Count { get; }
    bool IsEmpty { get; }
    void AddFirst(T value);
    void AddLast(T value);
    T RemoveFirst();
    T RemoveLast();
    bool Contains(T value);
}
