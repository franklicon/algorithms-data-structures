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

    public static void MergeSort<T>(T[] array) where T : IComparable<T>
    {
        MergeSortAux(array, 0, array.Length - 1);
    }

    private static void MergeSortAux<T>(T[] array, int left, int right) where T : IComparable<T>
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSortAux<T>(array, left, mid);
            MergeSortAux<T>(array, mid + 1, right);
            Merge(array, left, mid, right);
        }
    }

    private static void Merge<T>(T[] array, int left, int mid, int right) where T : IComparable<T>
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        T[] leftArray = new T[n1];
        T[] rightArray = new T[n2];
        
        Array.Copy(array, left, leftArray, 0, n1);
        Array.Copy(array, mid + 1, rightArray, 0, n2);

        int i = 0;
        int j = 0;
        int k = left;

        while (i < n1 && j < n2)
        {
            if (leftArray[i].CompareTo(rightArray[j]) <= 0)
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }

            k++;
        }
        
        while (i < n1)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }
        
        while (j < n2)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }
}