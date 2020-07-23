using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Datastructures.Datastructures;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listToSort = MyLists.generateList(0, 100, 50);
            Console.Write("Unsorted List: ");
            listToSort.ForEach(i => Console.Write("{0} ", i));
            Sort.Quicksort.runSynchron(listToSort);
            Console.Write("\nSorted List: ");
            listToSort.ForEach(i => Console.Write("{0} ", i));
            Console.Write("\nRun Binary Search");
            Console.Write("\nWhich number is searched: ");
            int search = Convert.ToInt32(Console.ReadLine());
            Stopwatch watch = new Stopwatch();
            watch.Start();
            if (Search.BinarySearch.searchSynchron(listToSort, search))
            {
                watch.Stop();
                Console.WriteLine("\nFound");
            } else
            {
                watch.Stop();
                Console.WriteLine("\nnot Found");
            }
            Console.WriteLine();
            Console.WriteLine($"Binary Search Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.ReadKey();
        }
    }
}
