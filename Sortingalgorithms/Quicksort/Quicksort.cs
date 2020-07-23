using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Quicksort
    {
        public static List<int> runSynchron(List<int> listToSort, Boolean showProgress = false)
        {
            quicksort(listToSort, 0, listToSort.Count - 1);
            return listToSort;
        }

        private static void quicksort(List<int> listToSort, int left, int right)
        {
            if (left < right)
            {
                int splitter = split(listToSort, left, right);
                quicksort(listToSort, left, splitter - 1);
                quicksort(listToSort, splitter + 1, right);
            }
        }

        private static int split(List<int> listToSort, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = listToSort[right];
            while (i < j)
            {
                while (i < right && listToSort[i] < pivot)
                {
                    i += 1;
                }

                while (j > left && listToSort[j] >= pivot)
                {
                    j -= 1;
                }

                if (i < j)
                {
                    listToSort[i] ^= listToSort[j];
                    listToSort[j] ^= listToSort[i];
                    listToSort[i] ^= listToSort[j];
                }

                if (listToSort[i] > pivot)
                {
                    listToSort[i] ^= listToSort[right];
                    listToSort[right] ^= listToSort[i];
                    listToSort[i] ^= listToSort[right];
                }
            }
            return i;
        }
    }
}
