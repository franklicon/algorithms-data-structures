namespace DataStructures.Trees;

public interface IBinarySearchTree<T> where T : IComparable<T>
{
    int Count { get; }
    bool IsEmpty { get; }
    void Insert(T value);
    bool Contains(T value);
    void Remove(T value);
    IEnumerable<T> InOrder();
    IEnumerable<T> PreOrder();
    IEnumerable<T> PostOrder();
}