using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgo
{
    public class BinarySearchAlgo
    {
        public static int BinarySearch(int [] arr, int k)
        {
            Array.Sort(arr);
            int first = 0;
            int last = arr.Length - 1;
            
            while(first <= last)
            {
                int mid = (first + last) / 2;
                if (arr[mid] == k)
                {
                    return mid;
                }
                else if (arr[mid] < k)
                {
                    first =  mid + 1;
                }
                else if (arr[mid] > k)
                {
                    last = mid - 1;
                }
            }
            return -1;
        }
    }
}
