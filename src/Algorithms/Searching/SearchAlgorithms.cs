namespace Algorithms.Searching;

public static class SearchAlgorithms
{
    public static int BinarySearch<T>(T[] array, T target) where T : IComparable<T>
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int cmp = array[mid].CompareTo(target);
            
            if (cmp > 0)
            {
                right = mid - 1;
            }
            else if (cmp < 0)
            {
                left = mid + 1;
            }
            else
            {
                return mid;
            }
        }

        return -1;
    }
}