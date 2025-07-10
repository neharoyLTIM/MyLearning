/// Find duplicates in O(n) time and O(n) extra space
///Given an array arr[] of n elements that contains elements from 0 to n-1, 
/// with any of these numbers appearing any number of times. 
/// The task is to find the repeating numbers.

using System;
using System.Collections.Generic;

namespace DSA
{
    public class GfGDuplicates
    {
        public static int[] FindDuplicates(int[] arr)
        {
            var dictSeen = new Dictionary<int, int>();
            var duplicates = new List<int>();
            foreach (var num in arr)
            {
                if (dictSeen.ContainsKey(num))
                {
                    dictSeen[num]++;
                    if (dictSeen[num] >= 2) // Only add the number when it is seen the second time
                    {
                        duplicates.Add(num);
                    }
                }
                else
                {
                    dictSeen[num] = 1;
                }
            }
            foreach (var kvp in dictSeen)
            {
                Console.WriteLine($"Number: {kvp.Key}, Count: {kvp.Value}");
                duplicates.Add(kvp.Key);
            }
            return duplicates.ToArray();
        }
    }
}