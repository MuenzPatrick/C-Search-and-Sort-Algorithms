using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class Insertionsort
    {
        public static void Sort(int[] arr)
        {
            for(int i = 1; i< arr.Length; i++)
            {
                int valueToSort = arr[i];
                int j = i;
                while (j > 0 && arr[j-1] > valueToSort)
                {
                    arr[j] = arr[j - 1];
                    j -= 1;
                }
                arr[j] = valueToSort;
            }
        }
        public static void Sort_Matrix(int[] arr, int columns)
        {
            for (int i = columns; i < arr.Length; i++)
            {
                int valueToSort = arr[i];
                int j = i;
                while (j > 0 && arr[j - columns] > valueToSort)
                {
                    arr[j] = arr[j - columns];
                    j -=  columns;
                }
                arr[j] = valueToSort;
            }
        }
    }
}
