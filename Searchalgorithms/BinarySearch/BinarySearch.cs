using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class BinarySearch
    {
        static public bool searchSynchron(List<int> sortedList, int searchItem)
        {
            printList(sortedList);
            int length = sortedList.Count;
            if (length == 0) return false;
            if (searchItem < sortedList[length/2])
            {
                return searchSynchron(sortedList.GetRange(0, length / 2), searchItem);
            } else if(searchItem > sortedList[length/2])
            {
                return searchSynchron(sortedList.GetRange(length / 2, sortedList.Count - length / 2), searchItem);
            }

            return searchItem == sortedList[length / 2] ? true : false ;
        }

        static private void printList(List<int> list)
        {
            Console.Write("\nCurrent List: ");
            list.ForEach(i => Console.Write("{0} ", i));
        }
    }
}
