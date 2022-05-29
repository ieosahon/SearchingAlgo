using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgo
{
    public class BinarySearchUsingRecusion
    {
        public static int BinarySearch(int [] arr, int k, int l, int r)
        {
            Array.Sort(arr);
            if (l > r)
            {
                return -1;
            }
            else
            {
                int m = (r + l) / 2;
                if (arr[m] == k)
                {
                    return m;
                }
                else if (arr[m] < k) 
                {
                   
                    return BinarySearch(arr, k, m+1, r);
                }
                else if (arr[m] > k)
                {
                    r = m - 1;
                    return BinarySearch(arr, k, l, m-1);
                }
            }
            return -2;
        }
    }
}
