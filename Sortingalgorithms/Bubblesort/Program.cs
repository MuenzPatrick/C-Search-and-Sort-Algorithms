using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listToSort = generateList(0, 10000, 100000);
            Console.Write("Unsorted List: ");
            //listToSort.ForEach(i => Console.Write("{0} ", i));
            Stopwatch watch = new Stopwatch();
            watch.Start();
            List<int> listSorted = Bubblesort.RunSynchron(listToSort,false);
            watch.Stop();
            Console.Write("\nSorted List: ");
            //listSorted.ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine($"Bubblesort Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.ReadKey();
        }

        public static List<int> generateList(int start, int end, int elementCount)
        {
            List<int> randomList = new List<int>();
            Random rand = new Random();
            int i = 0;
            while(i <= elementCount)
            {
                int number = rand.Next(start, end);
                randomList.Add(number);
                i++;
            }
            return randomList;
        }
    }
}
