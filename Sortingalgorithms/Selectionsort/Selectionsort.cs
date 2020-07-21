using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selectionsort
{
    class Selectionsort
    {
        public static List<int> runSynchron(List<int> listToSort, Boolean showProgress = false)
        {
            int maxIdx = listToSort.Count - 1;
            int currIdx = 0;
            do
            {
                int minPos = currIdx;
                for (int idx = currIdx + 1; idx <= maxIdx; idx++)
                {
                    if (listToSort[idx] < listToSort[minPos])
                    {
                        minPos = idx;
                    }
                }
                listToSort[minPos] ^= listToSort[currIdx];
                listToSort[currIdx] ^= listToSort[minPos];
                listToSort[minPos] ^= listToSort[currIdx];
                currIdx++;
            } while (currIdx < maxIdx);
            return listToSort;
        }
    }
}
