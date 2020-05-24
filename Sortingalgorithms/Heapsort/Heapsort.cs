using System;
using System.Collections.Generic;
using System.Text;
using static Datastructures.Datastructures;

namespace Heapsort
{
    class Heapsort
    {
        public List<int> listToSort { get; set; }
        public BinaryNode Tree { get; set; }
        public void BuildHeap()
        {
            Queue<BinaryNode> parents = new Queue<BinaryNode>();
            this.Tree.value = listToSort[0];
            int head = listToSort[1];
            parents.Enqueue(Tree);
            int i = 2;
            while(i < listToSort.Count)
            {
                BinaryNode parent = parents.Peek();
                parents.Dequeue();
                BinaryNode leftChild = new BinaryNode();
                BinaryNode rightChild = null;
                leftChild.value = listToSort[i];
                i++;
                parents.Enqueue(leftChild);
                if (i < listToSort.Count)
                {
                    rightChild = new BinaryNode();
                    rightChild.value = listToSort[i];
                    i++;
                    parents.Enqueue(rightChild);
                }
                parent.leftChild = leftChild;
                parent.rightChild = rightChild;
            }
        }
    }
}
