using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Mergesort
    {
        public static List<int> runSynchron(List<int> listToSort, Boolean showProgress=false)
        {
            if (listToSort.Count <= 1) return listToSort;
            else
            {
                int half = listToSort.Count / 2;
                List<int> leftList = splitList(0, half, listToSort).ToList();
                List<int> rightList = splitList(half, listToSort.Count, listToSort).ToList();
                leftList = runSynchron(leftList,showProgress);
                rightList = runSynchron(rightList,showProgress);
                return merge(leftList, rightList);
            }
        }

        private static IEnumerable<int> splitList(int startIndex, int endIndex, List<int> list)
        {
            for(int i = startIndex; i < endIndex;i++)
            {
                yield return list[i];
            }
        }

        private static List<int> merge(List<int> leftList, List<int> rightList)
        {
            List<int> sortedList = new List<int>();
            while(leftList.Count > 0 && rightList.Count > 0)
            {
                if(leftList[0] <= rightList[0])
                {
                    sortedList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                } else {
                    sortedList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }
            while(leftList.Count > 0)
            {
                sortedList.Add(leftList[0]);
                leftList.RemoveAt(0);
            }
            while(rightList.Count > 0)
            {
                sortedList.Add(rightList[0]);
                rightList.RemoveAt(0);
            }
            return sortedList;
        }
    }
}
