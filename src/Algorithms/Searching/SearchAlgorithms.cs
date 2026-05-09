namespace Algorithms.Searching;

public static class SearchAlgorithms
{
    public static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (array[mid] > target)
            {
                right = mid - 1;
            }
            else if (array[mid] < target)
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