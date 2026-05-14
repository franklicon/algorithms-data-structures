using Algorithms.Sorting;

namespace Algorithms.Tests.Sorting;

public class SortingAlgorithmsTests
{
    [Fact]
    public void BubbleSort_OnUnsortedArray_ShouldSortAscending()
    {
        int[] array = [5, 3, 8, 1, 9, 2];

        SortingAlgorithms.BubbleSort(array);

        Assert.Equal([1, 2, 3, 5, 8, 9], array);
    }

    [Fact]
    public void BubbleSort_OnAlreadySortedArray_ShouldRemainSorted()
    {
        int[] array = [1, 2, 3, 4, 5];

        SortingAlgorithms.BubbleSort(array);

        Assert.Equal([1, 2, 3, 4, 5], array);
    }

    [Fact]
    public void BubbleSort_OnReverseSortedArray_ShouldSortAscending()
    {
        int[] array = [5, 4, 3, 2, 1];

        SortingAlgorithms.BubbleSort(array);

        Assert.Equal([1, 2, 3, 4, 5], array);
    }

    [Fact]
    public void BubbleSort_OnArrayWithDuplicates_ShouldSortAscending()
    {
        int[] array = [3, 1, 3, 2, 1];

        SortingAlgorithms.BubbleSort(array);

        Assert.Equal([1, 1, 2, 3, 3], array);
    }

    [Fact]
    public void BubbleSort_OnArrayWithNegativeNumbers_ShouldSortAscending()
    {
        int[] array = [0, -3, 5, -1, 2];

        SortingAlgorithms.BubbleSort(array);

        Assert.Equal([-3, -1, 0, 2, 5], array);
    }

    [Fact]
    public void BubbleSort_OnTwoElementArray_WhenUnsorted_ShouldSwap()
    {
        int[] array = [7, 2];

        SortingAlgorithms.BubbleSort(array);

        Assert.Equal([2, 7], array);
    }

    [Fact]
    public void BubbleSort_OnSingleElementArray_ShouldRemainUnchanged()
    {
        int[] array = [42];

        SortingAlgorithms.BubbleSort(array);

        Assert.Equal([42], array);
    }

    [Fact]
    public void BubbleSort_OnEmptyArray_ShouldNotThrow()
    {
        int[] array = [];

        var exception = Record.Exception(() => SortingAlgorithms.BubbleSort(array));

        Assert.Null(exception);
    }

    [Fact]
    public void BubbleSort_WithStrings_ShouldSortAlphabetically()
    {
        string[] array = ["banana", "apple", "cherry", "apricot"];

        SortingAlgorithms.BubbleSort(array);

        Assert.Equal(["apple", "apricot", "banana", "cherry"], array);
    }

    [Fact]
    public void InsertionSort_OnUnsortedArray_ShouldSortAscending()
    {
        int[] array = [5, 3, 8, 1, 9, 2];

        SortingAlgorithms.InsertionSort(array);

        Assert.Equal([1, 2, 3, 5, 8, 9], array);
    }

    [Fact]
    public void InsertionSort_OnAlreadySortedArray_ShouldRemainSorted()
    {
        int[] array = [1, 2, 3, 4, 5];

        SortingAlgorithms.InsertionSort(array);

        Assert.Equal([1, 2, 3, 4, 5], array);
    }

    [Fact]
    public void InsertionSort_OnReverseSortedArray_ShouldSortAscending()
    {
        int[] array = [5, 4, 3, 2, 1];

        SortingAlgorithms.InsertionSort(array);

        Assert.Equal([1, 2, 3, 4, 5], array);
    }

    [Fact]
    public void InsertionSort_OnArrayWithDuplicates_ShouldSortAscending()
    {
        int[] array = [3, 1, 3, 2, 1];

        SortingAlgorithms.InsertionSort(array);

        Assert.Equal([1, 1, 2, 3, 3], array);
    }

    [Fact]
    public void InsertionSort_OnArrayWithNegativeNumbers_ShouldSortAscending()
    {
        int[] array = [0, -3, 5, -1, 2];

        SortingAlgorithms.InsertionSort(array);

        Assert.Equal([-3, -1, 0, 2, 5], array);
    }

    [Fact]
    public void InsertionSort_WhenSmallestElementIsLast_ShouldMoveitToFront()
    {
        int[] array = [3, 5, 7, 1];

        SortingAlgorithms.InsertionSort(array);

        Assert.Equal([1, 3, 5, 7], array);
    }

    [Fact]
    public void InsertionSort_OnTwoElementArray_WhenUnsorted_ShouldSwap()
    {
        int[] array = [7, 2];

        SortingAlgorithms.InsertionSort(array);

        Assert.Equal([2, 7], array);
    }

    [Fact]
    public void InsertionSort_OnSingleElementArray_ShouldRemainUnchanged()
    {
        int[] array = [42];

        SortingAlgorithms.InsertionSort(array);

        Assert.Equal([42], array);
    }

    [Fact]
    public void InsertionSort_OnEmptyArray_ShouldNotThrow()
    {
        int[] array = [];

        var exception = Record.Exception(() => SortingAlgorithms.InsertionSort(array));

        Assert.Null(exception);
    }

    [Fact]
    public void InsertionSort_WithStrings_ShouldSortAlphabetically()
    {
        string[] array = ["banana", "apple", "cherry", "apricot"];

        SortingAlgorithms.InsertionSort(array);

        Assert.Equal(["apple", "apricot", "banana", "cherry"], array);
    }

    [Fact]
    public void MergeSort_OnUnsortedArray_ShouldSortAscending()
    {
        int[] array = [5, 3, 8, 1, 9, 2];

        SortingAlgorithms.MergeSort(array);

        Assert.Equal([1, 2, 3, 5, 8, 9], array);
    }

    [Fact]
    public void MergeSort_OnAlreadySortedArray_ShouldRemainSorted()
    {
        int[] array = [1, 2, 3, 4, 5];

        SortingAlgorithms.MergeSort(array);

        Assert.Equal([1, 2, 3, 4, 5], array);
    }

    [Fact]
    public void MergeSort_OnReverseSortedArray_ShouldSortAscending()
    {
        int[] array = [5, 4, 3, 2, 1];

        SortingAlgorithms.MergeSort(array);

        Assert.Equal([1, 2, 3, 4, 5], array);
    }

    [Fact]
    public void MergeSort_OnArrayWithDuplicates_ShouldSortAscending()
    {
        int[] array = [3, 1, 3, 2, 1];

        SortingAlgorithms.MergeSort(array);

        Assert.Equal([1, 1, 2, 3, 3], array);
    }

    [Fact]
    public void MergeSort_OnArrayWithNegativeNumbers_ShouldSortAscending()
    {
        int[] array = [0, -3, 5, -1, 2];

        SortingAlgorithms.MergeSort(array);

        Assert.Equal([-3, -1, 0, 2, 5], array);
    }

    [Fact]
    public void MergeSort_OnTwoElementArray_WhenUnsorted_ShouldSwap()
    {
        int[] array = [7, 2];

        SortingAlgorithms.MergeSort(array);

        Assert.Equal([2, 7], array);
    }

    [Fact]
    public void MergeSort_OnSingleElementArray_ShouldRemainUnchanged()
    {
        int[] array = [42];

        SortingAlgorithms.MergeSort(array);

        Assert.Equal([42], array);
    }

    [Fact]
    public void MergeSort_OnEmptyArray_ShouldNotThrow()
    {
        int[] array = [];

        var exception = Record.Exception(() => SortingAlgorithms.MergeSort(array));

        Assert.Null(exception);
    }

    [Fact]
    public void MergeSort_WithStrings_ShouldSortAlphabetically()
    {
        string[] array = ["banana", "apple", "cherry", "apricot"];

        SortingAlgorithms.MergeSort(array);

        Assert.Equal(["apple", "apricot", "banana", "cherry"], array);
    }

    [Fact]
    public void MergeSort_WithDuplicates_ShouldBeStable()
    {
        int[] array = [3, 1, 2, 1, 3];

        SortingAlgorithms.MergeSort(array);

        Assert.Equal([1, 1, 2, 3, 3], array);
    }

    [Fact]
    public void QuickSort_OnUnsortedArray_ShouldSortAscending()
    {
        int[] array = [5, 3, 8, 1, 9, 2];

        SortingAlgorithms.QuickSort(array);

        Assert.Equal([1, 2, 3, 5, 8, 9], array);
    }

    [Fact]
    public void QuickSort_OnAlreadySortedArray_ShouldRemainSorted()
    {
        int[] array = [1, 2, 3, 4, 5];

        SortingAlgorithms.QuickSort(array);

        Assert.Equal([1, 2, 3, 4, 5], array);
    }

    [Fact]
    public void QuickSort_OnReverseSortedArray_ShouldSortAscending()
    {
        int[] array = [5, 4, 3, 2, 1];

        SortingAlgorithms.QuickSort(array);

        Assert.Equal([1, 2, 3, 4, 5], array);
    }

    [Fact]
    public void QuickSort_OnArrayWithDuplicates_ShouldSortAscending()
    {
        int[] array = [3, 1, 3, 2, 1];

        SortingAlgorithms.QuickSort(array);

        Assert.Equal([1, 1, 2, 3, 3], array);
    }

    [Fact]
    public void QuickSort_OnArrayWithNegativeNumbers_ShouldSortAscending()
    {
        int[] array = [0, -3, 5, -1, 2];

        SortingAlgorithms.QuickSort(array);

        Assert.Equal([-3, -1, 0, 2, 5], array);
    }

    [Fact]
    public void QuickSort_WhenPivotIsMinimumElement_ShouldSortCorrectly()
    {
        int[] array = [3, 5, 4, 1, 2];

        SortingAlgorithms.QuickSort(array);

        Assert.Equal([1, 2, 3, 4, 5], array);
    }

    [Fact]
    public void QuickSort_WhenPivotIsMaximumElement_ShouldSortCorrectly()
    {
        int[] array = [3, 1, 2, 4, 5];

        SortingAlgorithms.QuickSort(array);

        Assert.Equal([1, 2, 3, 4, 5], array);
    }

    [Fact]
    public void QuickSort_OnTwoElementArray_WhenUnsorted_ShouldSwap()
    {
        int[] array = [7, 2];

        SortingAlgorithms.QuickSort(array);

        Assert.Equal([2, 7], array);
    }

    [Fact]
    public void QuickSort_OnSingleElementArray_ShouldRemainUnchanged()
    {
        int[] array = [42];

        SortingAlgorithms.QuickSort(array);

        Assert.Equal([42], array);
    }

    [Fact]
    public void QuickSort_OnEmptyArray_ShouldNotThrow()
    {
        int[] array = [];

        var exception = Record.Exception(() => SortingAlgorithms.QuickSort(array));

        Assert.Null(exception);
    }

    [Fact]
    public void QuickSort_WithStrings_ShouldSortAlphabetically()
    {
        string[] array = ["banana", "apple", "cherry", "apricot"];

        SortingAlgorithms.QuickSort(array);

        Assert.Equal(["apple", "apricot", "banana", "cherry"], array);
    }
}
