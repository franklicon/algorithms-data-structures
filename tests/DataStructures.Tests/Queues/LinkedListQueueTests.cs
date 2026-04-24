using DataStructures.Queues;

namespace DataStructures.Tests.Queues;

public class LinkedListQueueTests
{
    [Fact]
    public void NewQueue_ShouldBeEmpty()
    {
        var queue = new LinkedListQueue<int>();

        Assert.True(queue.IsEmpty);
        Assert.Equal(0, queue.Count);
    }

    [Fact]
    public void Enqueue_OnEmptyQueue_ShouldIncreaseCountAndNotBeEmpty()
    {
        var queue = new LinkedListQueue<int>();

        queue.Enqueue(10);

        Assert.False(queue.IsEmpty);
        Assert.Equal(1, queue.Count);
    }

    [Fact]
    public void Enqueue_MultipleValues_ShouldIncreaseCount()
    {
        var queue = new LinkedListQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Assert.False(queue.IsEmpty);
        Assert.Equal(3, queue.Count);
    }

    [Fact]
    public void Enqueue_WithNullableReferenceType_ShouldIncreaseCount()
    {
        var queue = new LinkedListQueue<string?>();

        queue.Enqueue("a");
        queue.Enqueue(null);
        queue.Enqueue("c");

        Assert.Equal(3, queue.Count);
        Assert.False(queue.IsEmpty);
    }

    [Fact]
    public void Dequeue_OnEmptyQueue_ShouldThrow()
    {
        var queue = new LinkedListQueue<int>();

        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
    }

    [Fact]
    public void Dequeue_OnSingleItemQueue_ShouldReturnValueAndEmptyQueue()
    {
        var queue = new LinkedListQueue<int>();
        queue.Enqueue(42);

        var value = queue.Dequeue();

        Assert.Equal(42, value);
        Assert.True(queue.IsEmpty);
        Assert.Equal(0, queue.Count);
    }

    [Fact]
    public void Dequeue_OnMultipleItems_ShouldFollowFifoOrder()
    {
        var queue = new LinkedListQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Assert.Equal(1, queue.Dequeue());
        Assert.Equal(2, queue.Dequeue());
        Assert.Equal(3, queue.Dequeue());
        Assert.True(queue.IsEmpty);
        Assert.Equal(0, queue.Count);
    }

    [Fact]
    public void Dequeue_AfterQueueBecomesEmpty_ShouldAllowReuse()
    {
        var queue = new LinkedListQueue<int>();
        queue.Enqueue(10);
        queue.Dequeue();

        queue.Enqueue(20);

        Assert.Equal(20, queue.Dequeue());
        Assert.True(queue.IsEmpty);
    }

    [Fact]
    public void Peek_OnEmptyQueue_ShouldThrow()
    {
        var queue = new LinkedListQueue<int>();

        Assert.Throws<InvalidOperationException>(() => queue.Peek());
    }

    [Fact]
    public void Peek_OnNonEmptyQueue_ShouldReturnHeadWithoutRemoving()
    {
        var queue = new LinkedListQueue<int>();
        queue.Enqueue(5);
        queue.Enqueue(6);

        var peeked = queue.Peek();

        Assert.Equal(5, peeked);
        Assert.Equal(2, queue.Count);
        Assert.False(queue.IsEmpty);
        Assert.Equal(5, queue.Dequeue());
    }

    [Fact]
    public void Peek_MultipleCalls_ShouldNotChangeQueueState()
    {
        var queue = new LinkedListQueue<int>();
        queue.Enqueue(7);
        queue.Enqueue(8);

        Assert.Equal(7, queue.Peek());
        Assert.Equal(7, queue.Peek());
        Assert.Equal(2, queue.Count);
        Assert.Equal(7, queue.Dequeue());
        Assert.Equal(8, queue.Dequeue());
    }

    [Fact]
    public void Contains_OnEmptyQueue_ShouldReturnFalse()
    {
        var queue = new LinkedListQueue<int>();

        Assert.False(queue.Contains(10));
    }

    [Fact]
    public void Contains_WhenValueExists_ShouldReturnTrue()
    {
        var queue = new LinkedListQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Assert.True(queue.Contains(2));
    }

    [Fact]
    public void Contains_WhenValueDoesNotExist_ShouldReturnFalse()
    {
        var queue = new LinkedListQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Assert.False(queue.Contains(4));
    }

    [Fact]
    public void Contains_WithNullableReferenceType_ShouldHandleNull()
    {
        var queue = new LinkedListQueue<string?>();
        queue.Enqueue("a");
        queue.Enqueue(null);
        queue.Enqueue("c");

        Assert.True(queue.Contains(null));
        Assert.False(queue.Contains("z"));
    }
}
