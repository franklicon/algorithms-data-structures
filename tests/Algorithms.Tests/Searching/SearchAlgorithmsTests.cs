using Algorithms.Searching;

namespace Algorithms.Tests.Searching;

public class SearchAlgorithmsTests
{
    [Fact]
    public void BinarySearch_WhenTargetIsInMiddle_ShouldReturnCorrectIndex()
    {
        int[] array = [1, 3, 5, 7, 9];

        int index = SearchAlgorithms.BinarySearch(array, 5);

        Assert.Equal(2, index);
    }

    [Fact]
    public void BinarySearch_WhenTargetIsFirst_ShouldReturnZero()
    {
        int[] array = [1, 3, 5, 7, 9];

        int index = SearchAlgorithms.BinarySearch(array, 1);

        Assert.Equal(0, index);
    }

    [Fact]
    public void BinarySearch_WhenTargetIsLast_ShouldReturnLastIndex()
    {
        int[] array = [1, 3, 5, 7, 9];

        int index = SearchAlgorithms.BinarySearch(array, 9);

        Assert.Equal(4, index);
    }

    [Fact]
    public void BinarySearch_WhenTargetIsNotPresent_ShouldReturnNegativeOne()
    {
        int[] array = [1, 3, 5, 7, 9];

        int index = SearchAlgorithms.BinarySearch(array, 4);

        Assert.Equal(-1, index);
    }

    [Fact]
    public void BinarySearch_WhenTargetIsLessThanAllElements_ShouldReturnNegativeOne()
    {
        int[] array = [2, 4, 6, 8];

        int index = SearchAlgorithms.BinarySearch(array, 0);

        Assert.Equal(-1, index);
    }

    [Fact]
    public void BinarySearch_WhenTargetIsGreaterThanAllElements_ShouldReturnNegativeOne()
    {
        int[] array = [2, 4, 6, 8];

        int index = SearchAlgorithms.BinarySearch(array, 10);

        Assert.Equal(-1, index);
    }

    [Fact]
    public void BinarySearch_OnSingleElementArray_WhenTargetMatches_ShouldReturnZero()
    {
        int[] array = [42];

        int index = SearchAlgorithms.BinarySearch(array, 42);

        Assert.Equal(0, index);
    }

    [Fact]
    public void BinarySearch_OnSingleElementArray_WhenTargetDoesNotMatch_ShouldReturnNegativeOne()
    {
        int[] array = [42];

        int index = SearchAlgorithms.BinarySearch(array, 7);

        Assert.Equal(-1, index);
    }

    [Fact]
    public void BinarySearch_OnEmptyArray_ShouldReturnNegativeOne()
    {
        int[] array = [];

        int index = SearchAlgorithms.BinarySearch(array, 1);

        Assert.Equal(-1, index);
    }

    [Fact]
    public void BinarySearch_WhenArrayHasTwoElements_AndTargetIsFirst_ShouldReturnZero()
    {
        int[] array = [3, 7];

        int index = SearchAlgorithms.BinarySearch(array, 3);

        Assert.Equal(0, index);
    }

    [Fact]
    public void BinarySearch_WhenArrayHasTwoElements_AndTargetIsSecond_ShouldReturnOne()
    {
        int[] array = [3, 7];

        int index = SearchAlgorithms.BinarySearch(array, 7);

        Assert.Equal(1, index);
    }

    [Fact]
    public void BinarySearch_WithStrings_WhenTargetIsPresent_ShouldReturnCorrectIndex()
    {
        string[] array = ["apple", "banana", "cherry", "mango"];

        int index = SearchAlgorithms.BinarySearch(array, "cherry");

        Assert.Equal(2, index);
    }

    [Fact]
    public void BinarySearch_WithStrings_WhenTargetIsAbsent_ShouldReturnNegativeOne()
    {
        string[] array = ["apple", "banana", "cherry", "mango"];

        int index = SearchAlgorithms.BinarySearch(array, "grape");

        Assert.Equal(-1, index);
    }
}
