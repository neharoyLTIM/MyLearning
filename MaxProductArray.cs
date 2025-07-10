///  Maximum Product Subarray
/// Given an array arr[] consisting of positive, negative, and zero values, 
/// find the maximum product that can be obtained from any contiguous subarray of arr[]
using System;
using System.Collections.Generic;

namespace DSA
{
    public class GfGMaxProductArray
    {
        // Function to find the maximum product of a contiguous subarray
        public static int MaxProduct(int[] arr)
        {
            int result = 0;
            if (arr == null || arr.Length == 0)
                return 0;
            if (arr.Length == 1)
                return arr[0];
            else
            {
                int maxProduct = int.MinValue;
                int leftMultipler = 1;
                int rightMultipler = 1;
                int n = arr.Length;

                for (int i = 0; i < n - 1; i++)
                {
                    leftMultipler *= arr[i];
                    rightMultipler *= arr[n - 1 - i];
                    Console.WriteLine($"Left multiplier at index {i}: {leftMultipler}, Right multiplier at index {n - 1 - i}: {rightMultipler}");
                    maxProduct = Math.Max(maxProduct, Math.Max(leftMultipler, rightMultipler));
                    Console.WriteLine($"Current max product: {maxProduct}");
                }
                result = maxProduct;
            }
            return result;
        }
    }
}