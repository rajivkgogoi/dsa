using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.Sorting
{
    internal class SelectionSort
    {
        public void SortAscending(int[] unsortedArray)
        {
            int[] temp = new int[unsortedArray.Length];

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                int smallIndex = GetSmallestNumberIndex(unsortedArray);
                temp[i] = unsortedArray[smallIndex];
                unsortedArray[smallIndex] = int.MaxValue;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }

        private int GetSmallestNumberIndex(int[] myArray)
        {
            int smallestIndex = 0;
            int smallestNumberInArray = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i] < smallestNumberInArray)
                {
                    smallestNumberInArray = myArray[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }
    }
}
