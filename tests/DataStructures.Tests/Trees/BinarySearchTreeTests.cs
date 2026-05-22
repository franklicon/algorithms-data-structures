using DataStructures.Trees;

namespace DataStructures.Tests.Trees;

public class BinarySearchTreeTests
{
    // --- Insert / Count / IsEmpty ---

    [Fact]
    public void NewTree_ShouldBeEmpty()
    {
        var bst = new BinarySearchTree<int>();

        Assert.True(bst.IsEmpty);
        Assert.Equal(0, bst.Count);
    }

    [Fact]
    public void Insert_OnEmptyTree_ShouldIncreaseCountAndNotBeEmpty()
    {
        var bst = new BinarySearchTree<int>();

        bst.Insert(5);

        Assert.False(bst.IsEmpty);
        Assert.Equal(1, bst.Count);
    }

    [Fact]
    public void Insert_MultipleValues_ShouldIncreaseCountForEach()
    {
        var bst = new BinarySearchTree<int>();

        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(8);

        Assert.Equal(3, bst.Count);
    }

    [Fact]
    public void Insert_DuplicateValue_ShouldNotIncreaseCount()
    {
        var bst = new BinarySearchTree<int>();

        bst.Insert(5);
        bst.Insert(5);

        Assert.Equal(1, bst.Count);
    }

    // --- Contains ---

    [Fact]
    public void Contains_OnEmptyTree_ShouldReturnFalse()
    {
        var bst = new BinarySearchTree<int>();

        Assert.False(bst.Contains(5));
    }

    [Fact]
    public void Contains_WhenValueIsRoot_ShouldReturnTrue()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);

        Assert.True(bst.Contains(5));
    }

    [Fact]
    public void Contains_WhenValueIsInLeftSubtree_ShouldReturnTrue()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);

        Assert.True(bst.Contains(3));
    }

    [Fact]
    public void Contains_WhenValueIsInRightSubtree_ShouldReturnTrue()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(8);

        Assert.True(bst.Contains(8));
    }

    [Fact]
    public void Contains_WhenValueIsAbsent_ShouldReturnFalse()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(8);

        Assert.False(bst.Contains(99));
    }

    [Fact]
    public void Contains_WhenValueIsDeepInTree_ShouldReturnTrue()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(8);
        bst.Insert(1);
        bst.Insert(4);

        Assert.True(bst.Contains(1));
        Assert.True(bst.Contains(4));
    }

    [Fact]
    public void Contains_WithStrings_ShouldFindInsertedValues()
    {
        var bst = new BinarySearchTree<string>();
        bst.Insert("banana");
        bst.Insert("apple");
        bst.Insert("cherry");

        Assert.True(bst.Contains("apple"));
        Assert.True(bst.Contains("cherry"));
        Assert.False(bst.Contains("mango"));
    }

    // --- Remove ---

    [Fact]
    public void Remove_LeafNode_ShouldDecreaseCount()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(8);

        bst.Remove(3);

        Assert.Equal(2, bst.Count);
        Assert.False(bst.Contains(3));
    }

    [Fact]
    public void Remove_NodeWithOnlyRightChild_ShouldReplaceWithChild()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(4);

        bst.Remove(3);

        Assert.Equal(2, bst.Count);
        Assert.False(bst.Contains(3));
        Assert.True(bst.Contains(4));
    }

    [Fact]
    public void Remove_NodeWithOnlyLeftChild_ShouldReplaceWithChild()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(2);

        bst.Remove(3);

        Assert.Equal(2, bst.Count);
        Assert.False(bst.Contains(3));
        Assert.True(bst.Contains(2));
    }

    [Fact]
    public void Remove_NodeWithTwoChildren_ShouldReplaceWithInOrderSuccessor()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(8);
        bst.Insert(6);
        bst.Insert(9);

        bst.Remove(8);

        Assert.Equal(4, bst.Count);
        Assert.False(bst.Contains(8));
        Assert.True(bst.Contains(6));
        Assert.True(bst.Contains(9));
    }

    [Fact]
    public void Remove_RootNode_ShouldUpdateRoot()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(8);

        bst.Remove(5);

        Assert.Equal(2, bst.Count);
        Assert.False(bst.Contains(5));
        Assert.True(bst.Contains(3));
        Assert.True(bst.Contains(8));
    }

    [Fact]
    public void Remove_OnlyNode_ShouldMakeTreeEmpty()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);

        bst.Remove(5);

        Assert.True(bst.IsEmpty);
        Assert.Equal(0, bst.Count);
    }

    [Fact]
    public void Remove_AbsentValue_ShouldNotChangeCount()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);

        bst.Remove(99);

        Assert.Equal(2, bst.Count);
    }

    // --- Traversals ---

    [Fact]
    public void InOrder_ShouldReturnValuesSorted()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(8);
        bst.Insert(1);
        bst.Insert(4);

        Assert.Equal([1, 3, 4, 5, 8], bst.InOrder());
    }

    [Fact]
    public void PreOrder_ShouldReturnRootFirst()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(8);
        bst.Insert(1);
        bst.Insert(4);

        Assert.Equal([5, 3, 1, 4, 8], bst.PreOrder());
    }

    [Fact]
    public void PostOrder_ShouldReturnRootLast()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(8);
        bst.Insert(1);
        bst.Insert(4);

        Assert.Equal([1, 4, 3, 8, 5], bst.PostOrder());
    }

    [Fact]
    public void InOrder_OnEmptyTree_ShouldReturnEmptySequence()
    {
        var bst = new BinarySearchTree<int>();

        Assert.Empty(bst.InOrder());
    }

    [Fact]
    public void InOrder_AfterRemoval_ShouldReflectUpdatedTree()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(8);

        bst.Remove(3);

        Assert.Equal([5, 8], bst.InOrder());
    }
}
