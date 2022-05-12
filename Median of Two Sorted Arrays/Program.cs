using System;
using System.Linq;

namespace Median_of_Two_Sorted_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3 };
            int[] b = { 2 };
            double c = FindMedianSortedArrays(a, b);

            Console.WriteLine(c);
            Console.ReadKey();
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] combined = nums1.Concat(nums2).ToArray();

            Array.Sort(combined);

            int arrayCount = (combined.Length / 2) - 1;

            double res = 0;
            if (combined.Count() % 2 == 1) return res = (double)combined[arrayCount + 1];
            else
            {
                return res = (double)(combined[arrayCount] + combined[arrayCount + 1])/2;
            }
        }
    }
}
