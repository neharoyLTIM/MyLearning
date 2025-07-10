using System;
using System.Collections.Generic;

namespace DSA
{
    public class GfGFindMinimumInArray
    {
        // Function to find the minimum element in an array 
        //Minimum in Rotated Sorted - Use Binary Search
        public static int FindMin(int[] arr)
        {
            int min = 0;
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
            }
            // int[] arr = { 0, -1, 2, -3, 1 };
            int hi = arr.Length - 1;
            int lo = 0;
            int mid = lo + hi / 2;
            // Perform binary search to find the minimum element
            while (lo < hi)
            {

                Console.WriteLine($"Checking middle index {mid}, value: {arr[mid]}");
                // If the array is already sorted, the first element is the minimum
                if (arr[lo] < arr[lo + 1])
                {
                    min = arr[lo];
                    Console.WriteLine($"Minimum found at index {lo}, value: {min}");
                    break;
                }
                // The right half is not sorted. So the minimum element must be in the right half.
                else if (arr[mid] > arr[hi])
                {
                    Console.WriteLine($"Right half is not sorted, searching in right half from index {mid + 1} to {hi}");
                    lo = mid + 1;
                }
                // If mid is less than the first element, search in the left half
                else
                {
                    Console.WriteLine($"Left half is not sorted, searching in left half from index {lo} to {mid}");
                    hi = mid;
                }
            }
            return min;
        }
    }
}