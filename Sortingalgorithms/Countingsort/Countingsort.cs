using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countingsort
{
    class Countingsort
    {
        public static void runSynchron(List<int> listToSort)
        {
            int maxNumber = listToSort.Max();
            int[] tempList = new int[maxNumber + 1];
            for(int i = 0; i < listToSort.Count; i++)
            {
                tempList[listToSort[i]]++;
            }
            int finalposition = 0;
            for(int i = 0; i <= maxNumber; i++)
            {
                for( int j = 0; j < tempList[i]; j++)
                {
                    listToSort[finalposition] = i;
                    finalposition++;
                }
            }
        }
    }
}
