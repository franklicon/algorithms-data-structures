using DataStructures.LinkedLists;

namespace DataStructures.Tests.LinkedLists;

public class SinglyLinkedListTests
{
    [Fact]
    public void NewList_ShouldBeEmpty()
    {
        var list = new SinglyLinkedList<int>();

        Assert.True(list.IsEmpty);
        Assert.Equal(0, list.Count);
    }

    [Fact]
    public void RemoveLast_OnEmptyList_ShouldThrow()
    {
        var list = new SinglyLinkedList<int>();

        Assert.Throws<InvalidOperationException>(() => list.RemoveLast());
    }

    [Fact]
    public void RemoveLast_OnSingleNodeList_ShouldReturnValueAndEmptyList()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(42);

        var removed = list.RemoveLast();

        Assert.Equal(42, removed);
        Assert.True(list.IsEmpty);
        Assert.Equal(0, list.Count);
    }

    [Fact]
    public void RemoveLast_OnMultiNodeList_ShouldRemoveTailInOrder()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        Assert.Equal(3, list.RemoveLast());
        Assert.Equal(2, list.RemoveLast());
        Assert.Equal(1, list.RemoveLast());
        Assert.True(list.IsEmpty);
        Assert.Equal(0, list.Count);
    }

    [Fact]
    public void RemoveLast_WithDuplicateValues_ShouldRemoveByPositionNotValue()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(7);
        list.AddLast(7);
        list.AddLast(7);

        Assert.Equal(7, list.RemoveLast());
        Assert.Equal(2, list.Count);
        Assert.Equal(7, list.RemoveLast());
        Assert.Equal(1, list.Count);
        Assert.Equal(7, list.RemoveLast());
        Assert.True(list.IsEmpty);
    }

    [Fact]
    public void RemoveFirst_OnEmptyList_ShouldThrow()
    {
        var list = new SinglyLinkedList<int>();

        Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
    }

    [Fact]
    public void RemoveFirst_OnSingleNodeList_ShouldReturnValueAndEmptyList()
    {
        var list = new SinglyLinkedList<int>();
        list.AddFirst(42);

        var removed = list.RemoveFirst();

        Assert.Equal(42, removed);
        Assert.True(list.IsEmpty);
        Assert.Equal(0, list.Count);
    }

    [Fact]
    public void RemoveFirst_OnMultiNodeList_ShouldRemoveHeadInOrder()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        Assert.Equal(1, list.RemoveFirst());
        Assert.Equal(2, list.RemoveFirst());
        Assert.Equal(3, list.RemoveFirst());
        Assert.True(list.IsEmpty);
        Assert.Equal(0, list.Count);
    }

    [Fact]
    public void RemoveFirst_AfterListBecomesEmpty_ShouldAllowReuse()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(10);
        list.RemoveFirst();

        list.AddLast(20);

        Assert.Equal(20, list.RemoveFirst());
        Assert.True(list.IsEmpty);
    }

    [Fact]
    public void Contains_OnEmptyList_ShouldReturnFalse()
    {
        var list = new SinglyLinkedList<int>();

        Assert.False(list.Contains(10));
    }

    [Fact]
    public void Contains_WhenValueExists_ShouldReturnTrue()
    {
        var list = new SinglyLinkedList<int>();
        list.AddFirst(2);
        list.AddLast(4);
        list.AddLast(6);

        Assert.True(list.Contains(4));
    }

    [Fact]
    public void Contains_WhenValueDoesNotExist_ShouldReturnFalse()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(3);
        list.AddLast(5);

        Assert.False(list.Contains(2));
    }

    [Fact]
    public void Contains_WithNullableReferenceType_ShouldHandleNull()
    {
        var list = new SinglyLinkedList<string?>();
        list.AddLast("a");
        list.AddLast(null);
        list.AddLast("c");

        Assert.True(list.Contains(null));
        Assert.False(list.Contains("z"));
    }
}
