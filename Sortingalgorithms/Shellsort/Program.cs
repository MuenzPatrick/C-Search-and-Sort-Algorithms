using System;
using System.Collections.Generic;
using System.Diagnostics;
using static Datastructures.Datastructures;

namespace Shellsort
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
            List<int> sortedList = Sort.Shellsort.runSynchron(listToSort);
            watch.Stop();
            Console.Write("\nSorted List: ");
            sortedList.ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine();
            Console.WriteLine($"Selectionsort Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.ReadKey();
        }
    }
}
