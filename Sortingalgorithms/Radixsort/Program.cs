using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Datastructures.Datastructures;

namespace Radixsort
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
            Radixsort.runSynchron(listToSort);
            watch.Stop();
            Console.Write("\nSorted List: ");
            listToSort.ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine();
            Console.WriteLine($"Radixsort Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.ReadKey();
        }
    }
}
