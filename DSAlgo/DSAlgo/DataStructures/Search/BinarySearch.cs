using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.DataStructures.Search
{
    public class BinarySearch
    {
        public int Search(int[] sortedArray, int itemToSearch)
        {
            int low = 0, high = sortedArray.Length - 1;
            int mid;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (itemToSearch == sortedArray[mid])
                {
                    return mid;
                }
                if (itemToSearch < sortedArray[mid])
                {
                    high = mid - 1;
                }
                if (itemToSearch > sortedArray[mid])
                {
                    low = mid + 1;
                }
            }


            return -1;
        }
    }
}
