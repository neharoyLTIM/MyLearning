///3 Sum - Find All Triplets with Zero Sum
///Given an array arr[], the task is to find all possible indices {i, j, k} 
/// of triplet {arr[i], arr[j], arr[k]} such that their sum is equal to zero 
/// and all indices in a triplet should be distinct (i != j, j != k, k != i).
///  We need to return indices of a triplet in sorted order, i.e., i < j < k.
using System;
using System.Collections.Generic;

namespace DSA
{
    public static class GfGTripletSum
    {
        public static List<List<int>> GetTripletIndexesWithZeroSum(int[] arr)
        {
            Dictionary<int, List<int>> maps = new Dictionary<int, List<int>>();
            List<List<int>> triplets = new List<List<int>>();   

            for(int j=0; j < arr.Length; j++)
            {
                for(int k=j+1; k < arr.Length; k++)
                {
                    int sum = -(arr[j] + arr[k]);
                    if (maps.ContainsKey(sum))
                    {
                        foreach (int i in maps[sum])
                        {
                            if (i < j && j < k) // Ensure i < j < k
                            {
                                triplets.Add(new List<int> { i, j, k });
                            }
                        }
                    }
                }
                if (!maps.ContainsKey(arr[j]))
                {
                    maps[arr[j]] = new List<int>();
                }
                maps[arr[j]].Add(j);
            }
        return triplets;
        }   
    }
}