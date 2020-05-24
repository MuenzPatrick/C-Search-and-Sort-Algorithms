using System;
using System.Collections.Generic;

namespace Datastructures
{
    public class Datastructures
    {
        public class MyLists
        {
            public static List<int> generateList(int start, int end, int elementCount)
            {
                List<int> randomList = new List<int>();
                Random rand = new Random();
                int i = 0;
                while (i < elementCount)
                {
                    int number = rand.Next(start, end);
                    randomList.Add(number);
                    i++;
                }
                return randomList;
            }
        }

        public class BinaryNode
        {
                public int value { get; set; }
                public BinaryNode leftChild { get; set; }

                public BinaryNode rightChild { get; set; }
        }
    }
}
