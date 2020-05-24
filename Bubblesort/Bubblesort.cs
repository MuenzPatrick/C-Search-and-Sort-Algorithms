using System;
using System.Collections.Generic;
using System.Text;

namespace Bubblesort
{
    /// <summary>
    /// Class contains Bubblesort variantes
    /// </summary>
    class Bubblesort
    {
        /// <summary>
        /// Runs Bubblesort synchron and iterative
        /// </summary>
        /// <param name="listToSort">the list that will be sorted</param>
        /// <returns>sorted List</returns>
        public static List<int> RunSynchron(List<int> listToSort, Boolean showProgress = false)
        {
            int k = 0;
            for (int i = 1; i < listToSort.Count; i++)
            {
                for (int j = 0; j < listToSort.Count-i;j++)
                {
                    int a = listToSort[j];
                    int b = listToSort[j+1];
                    if (a > b)
                    {
                        int c = a;
                        listToSort[j] = b;
                        listToSort[j+1] = c;
                        if(showProgress)
                        {
                            k++;
                            Console.Write("\nStep {0}: ", k);
                            listToSort.ForEach(i => Console.Write("{0} ", i));
                        }
                    }
                }
            }
            return listToSort;
        }
    }
}
