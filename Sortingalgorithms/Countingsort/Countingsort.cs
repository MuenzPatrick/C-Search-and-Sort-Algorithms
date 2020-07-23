using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countingsort
{
    public class Countingsort
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

        public static void run_with_faktor(List<int> liste, int i, int faktor)
        {
            int[] ausgabe = new int[i];
            int a;
            int[] zaehlen = new int[10];
            zaehlen.Initialize();
            for (a = 0; a < i; a++)
                zaehlen[(liste[a] / faktor) % 10]++;
            for (a = 1; a < 10; a++)
                zaehlen[a] += zaehlen[a - 1];

            for (a = i-1; a >= 0; a--)
            {
                ausgabe[zaehlen[(liste[a] / faktor) % 10] - 1] = liste[a];
                zaehlen[(liste[a] / faktor) % 10] --;
            }

            for (a = 0; a < i; a++)
                liste[a] = ausgabe[a];
        }
    }
}
