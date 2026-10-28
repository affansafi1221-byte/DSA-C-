
namespace DSA.Sorting;

public static class Sorting
{
    public static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            bool swapped = false;

            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    swapped = true;
                }
            }

            if (!swapped) break;
        }
    }

    public static int[] MergeSort(int[] arr)
    {
        if (arr.Length <= 1) return arr;

        int mid = arr.Length / 2;
        int[] left = MergeSort(arr[..mid]);
        int[] right = MergeSort(arr[mid..]);

        int[] result = new int[arr.Length];
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
            result[k++] = left[i] <= right[j] ? left[i++] : right[j++];

        while (i < left.Length)
            result[k++] = left[i++];

        while (j < right.Length)
            result[k++] = right[j++];

        return result;
    }

    public static void QuickSort(int[] arr, int low, int high)
    {
        if (low >= high) return;

        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);

        int p = i + 1;

        QuickSort(arr, low, p - 1);
        QuickSort(arr, p + 1, high);
    }
}
