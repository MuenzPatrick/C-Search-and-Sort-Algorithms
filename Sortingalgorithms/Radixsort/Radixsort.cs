using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Countingsort;
namespace Radixsort
{
    class Radixsort
    {
        public static void  runSynchron(List<int> listToSort)
        {
            int max = listToSort.Max();
            for(int faktor = 1; max/faktor > 0; faktor *=10)
            {
                Countingsort.Countingsort.run_with_faktor(listToSort, listToSort.Count, faktor);
            }
        }
    }
}
