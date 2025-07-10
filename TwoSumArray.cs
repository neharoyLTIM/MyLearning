///Two Sum - Pair with given Sum
///Given an array arr[] of n integers and a target value, check if there exists a pair 
/// whose sum equals the target. 
/// This is a variation of the 2Sum problem.

using System;

namespace DSA
{
    public class GfGSearch
    {

        // Function to perform binary search
        static bool binarySearch(int[] arr, int left, int right, int target)
        {
            while (left <= right)
            {
                Console.WriteLine($"Searching for {target} between indices {left} and {right}");
                int mid = left + (right - left) / 2;
                Console.WriteLine($"Mid index: {mid}, Mid value: {arr[mid]}");
                if (arr[mid] == target)
                    return true;
                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
                Console.WriteLine($"Updated search range: {left} to {right}");
            }
            return false;
        }

        // Function to check whether any pair exists
        // whose sum is equal to the given target value
        public static bool twoSum(int[] arr, int target)
        {
            // Sort the array
            Array.Sort(arr);

            // Iterate through each element in the array
            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];
                Console.WriteLine($"Current element: {arr[i]}, Complement: {complement}");
                // Use binary search to find the complement
                if (binarySearch(arr, i + 1, arr.Length - 1, complement))
                    return true;
            }
            // If no pair is found
            return false;
        }
    }
}