using System;
using System.Collections.Generic;
using System.Linq;
using Insertionsort;
namespace Sort
{
    class Shellsort
    {
        public static  List<int> runSynchron(List<int> listToSort)
        {
            int k, h;
            int[] arrayToSort = listToSort.ToArray();
            int[] spalten = {
                2147483647, 1131376761, 410151271, 157840433,
                58548857, 21521774, 8810089, 3501671, 1355339, 543749, 213331,
                84801, 27901, 11969, 4711, 1968, 815, 271, 111, 41, 13, 4, 1
            };
            for (k = 0; k < spalten.Length; k++)
            {
                h = spalten[k];
                Insertionsort.Insertionsort.Sort_Matrix(arrayToSort, h);
            }
            return arrayToSort.ToList();
        }
    }
}