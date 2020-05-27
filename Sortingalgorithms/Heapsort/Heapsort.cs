using System;
using System.Collections.Generic;
using System.Text;
using static Datastructures.Datastructures;

namespace Heapsort
{
    public class Heapsort
    {
        /// <summary>
        /// Converts given arr in Heap and replaces largest element by  the rightmost leaf element
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        public static void heapSort(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);
            }
        }
        /// <summary>
        /// Creates Heapstrcuture by arrainging elements as required.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <param name="i"></param>
        static void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }
    }
}
