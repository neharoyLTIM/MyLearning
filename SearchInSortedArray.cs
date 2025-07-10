/// Search in a Sorted and Rotated Array
///Given a sorted and rotated array arr[] of n distinct elements, 
/// the task is to find the index of given key in the array. 
/// If the key is not present in the array, return -1.

using System;
using System.Collections.Generic;

namespace DSA
{
    public class GfGSearchInSortedArray
    {
        // Function to search an element in a sorted array using binary search
        public static int Search(int[] arr, int target)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
            }

            int lo = 0;
            int hi = arr.Length - 1;

            while (lo <= hi)
            {
                int mid = lo + hi  / 2;

                if (arr[mid] == target)
                {
                    return mid; // Element found
                }
                else if (arr[mid] < target)
                {
                    lo = mid + 1; // Search in the right half
                }
                else
                {
                    hi = mid - 1; // Search in the left half
                }
            }

            return -1; // Element not found
        }
    }
}