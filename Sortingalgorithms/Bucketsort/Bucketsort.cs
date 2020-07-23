using Insertionsort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Bucketsort
    {
        public static List<int> runSynchron(int[] listToSort)
        {
            List<int> sortedList = new List<int>();
            int max = Convert.ToInt32(Math.Floor(Math.Log10(listToSort.Max())));
            max = Convert.ToInt32(Math.Pow(10, max));
            int numOfBuckets = 10;
            List<int>[] buckets = new List<int>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<int>();
            }
            //Iterate through the passed array and add each integer to the appropriate bucket
            for (int i = 0; i < listToSort.Length; i++)
            {
                int bucket = (listToSort[i] / (1*max));
                buckets[bucket].Add(listToSort[i]);
            }
            //Sort each bucket and add it to the result List
            for (int i = 0; i < numOfBuckets; i++)
            {
                int[] a = buckets[i].ToArray(); 
                Insertionsort.Insertionsort.Sort(a);
                sortedList.AddRange(a);
            }
            return sortedList;
        }
    }
}
