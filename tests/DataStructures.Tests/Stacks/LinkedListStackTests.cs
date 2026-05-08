using DataStructures.Stacks;

namespace DataStructures.Tests.Stacks;

public class LinkedListStackTests
{
    [Fact]
    public void NewStack_ShouldBeEmpty()
    {
        var stack = new LinkedListStack<int>();

        Assert.True(stack.IsEmpty);
        Assert.Equal(0, stack.Count);
    }

    [Fact]
    public void Push_OnEmptyStack_ShouldIncreaseCountAndNotBeEmpty()
    {
        var stack = new LinkedListStack<int>();

        stack.Push(10);

        Assert.False(stack.IsEmpty);
        Assert.Equal(1, stack.Count);
    }

    [Fact]
    public void Push_MultipleValues_ShouldIncreaseCount()
    {
        var stack = new LinkedListStack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Assert.False(stack.IsEmpty);
        Assert.Equal(3, stack.Count);
    }

    [Fact]
    public void Push_WithNullableReferenceType_ShouldIncreaseCount()
    {
        var stack = new LinkedListStack<string?>();

        stack.Push("a");
        stack.Push(null);
        stack.Push("c");

        Assert.Equal(3, stack.Count);
        Assert.False(stack.IsEmpty);
    }

    [Fact]
    public void Pop_OnEmptyStack_ShouldThrow()
    {
        var stack = new LinkedListStack<int>();

        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Fact]
    public void Pop_OnSingleItemStack_ShouldReturnValueAndEmptyStack()
    {
        var stack = new LinkedListStack<int>();
        stack.Push(42);

        var value = stack.Pop();

        Assert.Equal(42, value);
        Assert.True(stack.IsEmpty);
        Assert.Equal(0, stack.Count);
    }

    [Fact]
    public void Pop_OnMultipleItems_ShouldFollowLifoOrder()
    {
        var stack = new LinkedListStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Assert.Equal(3, stack.Pop());
        Assert.Equal(2, stack.Pop());
        Assert.Equal(1, stack.Pop());
        Assert.True(stack.IsEmpty);
        Assert.Equal(0, stack.Count);
    }

    [Fact]
    public void Pop_AfterStackBecomesEmpty_ShouldAllowReuse()
    {
        var stack = new LinkedListStack<int>();
        stack.Push(10);
        stack.Pop();

        stack.Push(20);

        Assert.Equal(20, stack.Pop());
        Assert.True(stack.IsEmpty);
    }

    [Fact]
    public void Peek_OnEmptyStack_ShouldThrow()
    {
        var stack = new LinkedListStack<int>();

        Assert.Throws<InvalidOperationException>(() => stack.Peek());
    }

    [Fact]
    public void Peek_OnNonEmptyStack_ShouldReturnTopWithoutRemoving()
    {
        var stack = new LinkedListStack<int>();
        stack.Push(5);
        stack.Push(6);

        var peeked = stack.Peek();

        Assert.Equal(6, peeked);
        Assert.Equal(2, stack.Count);
        Assert.False(stack.IsEmpty);
        Assert.Equal(6, stack.Pop());
    }

    [Fact]
    public void Peek_MultipleCalls_ShouldNotChangeStackState()
    {
        var stack = new LinkedListStack<int>();
        stack.Push(7);
        stack.Push(8);

        Assert.Equal(8, stack.Peek());
        Assert.Equal(8, stack.Peek());
        Assert.Equal(2, stack.Count);
        Assert.Equal(8, stack.Pop());
        Assert.Equal(7, stack.Pop());
    }

    [Fact]
    public void Contains_OnEmptyStack_ShouldReturnFalse()
    {
        var stack = new LinkedListStack<int>();

        Assert.False(stack.Contains(10));
    }

    [Fact]
    public void Contains_WhenValueExists_ShouldReturnTrue()
    {
        var stack = new LinkedListStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Assert.True(stack.Contains(2));
    }

    [Fact]
    public void Contains_WhenValueDoesNotExist_ShouldReturnFalse()
    {
        var stack = new LinkedListStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Assert.False(stack.Contains(4));
    }

    [Fact]
    public void Contains_WithNullableReferenceType_ShouldHandleNull()
    {
        var stack = new LinkedListStack<string?>();
        stack.Push("a");
        stack.Push(null);
        stack.Push("c");

        Assert.True(stack.Contains(null));
        Assert.False(stack.Contains("z"));
    }
}
