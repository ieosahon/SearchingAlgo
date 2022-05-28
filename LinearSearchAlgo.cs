using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgo
{
    public class LinearSearchAlgo
    {
        public static int LinearSearch(int [] arr, int k)
        {
            int n = arr.Length;
            int i = 0;
            while (i < n)
            {
                if (arr[i] == k)
                {
                    return i;

                }
                i++;
            }
            return -1;
        }

        public static string LinearSearch(List<int> list, int l)
        {
            int n = list.Count;
            for (int i = 0; i < n; i++)
            {
                if (list[i] == l)
                {
                    return $"the index of the item to search for is {i}";
                }

            }
            return $"the item to search for is not found";
        }
    }
}
