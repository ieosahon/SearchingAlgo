using System;
using System.Collections.Generic;

namespace SearchingAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 0;
            var res = LinearSearchAlgo.LinearSearch(arr, k);
            Console.WriteLine(res);

            Console.WriteLine("########################");
            List<int> list = new() { 1, 2, 3, 4, 5, 6, 7 };
            int l = 10;
            var listRes = LinearSearchAlgo.LinearSearch(list, l);
            Console.WriteLine(listRes);

            Console.WriteLine("########################");

            int [] arr1 = {0, 40, 5, 3, 8,  4, 6, 7};
            int k1 = 5;
            var res1 = BinarySearchAlgo.BinarySearch(arr1, k1);
            Console.WriteLine(res1);

            Console.WriteLine("########################");
            int[] arr2 = { 0, 40, 5, 3, 8, 4, 6, 7 };
            var k2 = 4;
            var r = arr2.Length - 1;
            var l1 = 0;

            var res2 = BinarySearchUsingRecusion.BinarySearch(arr2, k2, l1, r);
            Console.WriteLine(res2);
        }
    }
}
