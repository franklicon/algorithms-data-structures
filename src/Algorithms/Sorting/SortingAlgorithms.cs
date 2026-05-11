namespace Algorithms.Sorting;

public static class SortingAlgorithms
{
    public static void BubbleSort<T>(T[] array) where T : IComparable<T>
    {
        for (int i = 0; i < array.Length; i++)
        {
            var swapped = false;
            for (int j = 1; j < array.Length - i; j++)
            {
                if (array[j - 1].CompareTo(array[j]) > 0)
                {
                    (array[j - 1], array[j]) = (array[j], array[j - 1]);
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }
    }

    public static void InsertionSort<T>(T[] array) where T : IComparable<T>
    {
        for (int i = 1; i < array.Length; i++)
        {
            int j = i;
            while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
            {
                (array[j], array[j - 1]) = (array[j - 1], array[j]);
                j--;
            }
        }
    }
}