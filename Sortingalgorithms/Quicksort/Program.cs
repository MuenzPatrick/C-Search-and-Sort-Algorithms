using System;
using System.Collections.Generic;
using System.Diagnostics;
using static Datastructures.Datastructures;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listToSort = MyLists.generateList(0, 100, 10);
            Console.Write("Unsorted List: ");
            listToSort.ForEach(i => Console.Write("{0} ", i));
            Stopwatch watch = new Stopwatch();
            watch.Start();
            List<int> sortedList = Sort.Quicksort.runSynchron(listToSort);
            watch.Stop();
            Console.Write("\nSorted List: ");
            sortedList.ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine();
            Console.WriteLine($"Quicksort Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.ReadKey();
        }
    }
}
