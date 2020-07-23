using System;
using System.Diagnostics;
using static Datastructures.Datastructures;

namespace Bucketsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            int range = 100;
            int[] arrToSort = MyLists.generateList(0, range, length).ToArray();
            Console.Write("Unsorted List: ");
            foreach (int i in arrToSort)
            {
                Console.Write("{0} ", i);
            }
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var sortedList = Sort.Bucketsort.runSynchron(arrToSort);
            watch.Stop();
            Console.Write("\nSorted List: ");
            foreach (int i in sortedList)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine($"Bucketsort Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.ReadKey();
        }
    }
}
