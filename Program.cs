using System;
using DSA;
using System.Collections.Generic;

class Program {
    static void Main()
    {
        // int[] arr = { 0, -1, 2, -3, 1 };
        // int target = -2;

        // if (DSA.GfGSearch.twoSum(arr, target))
        // {
        //     Console.WriteLine("true");
        // }
        // else
        // {
        //     Console.WriteLine("false");
        // }

        // int[] prices = { 7, 10, 1, 3, 6, 9, 2 };
        // Console.WriteLine(DSA.GfGProfit.MaxProfit(prices));
        // Console.WriteLine("Find Duplicates in Array:");
        // int[] arr2 = { 1, 2, 3, 4, 5, 5, 7, 8, 9, 10, 1, 2, 2, 4, 5, 6, 7, 8, 9, 8 };
        // int[] duplicates = DSA.GfGDuplicates.FindDuplicates(arr2);
        // Console.WriteLine("Duplicates: " + string.Join(", ", duplicates));
        Console.WriteLine("Product of all elements except self:");
        int[] productInts = { 7, 10, 1, 3, 6, 9, 2 };
        var products = DSA.ProductArray.productExceptSelf(productInts);
        // foreach (var kvp in products)
        // {
        //     Console.WriteLine($"Element: {kvp.Key}, Product of others: {kvp.Value}");
        // }
        // Console.WriteLine("Maximum Product of subarray elements in given array:");
        // int result = DSA.GfGMaxProductArray.MaxProduct(productInts);
        // Console.WriteLine($"Maximum product of a given array: {result}");
        // int[] arr = { 0, -1, 2, -3, 1, -7, 8, 5, -4 };
        // Console.WriteLine("Find minimum element in a sorted array which was unsorted at some point");
        // int min = DSA.GfGFindMinimumInArray.FindMin(arr);
        // Console.WriteLine($"Minimum element in the array: {min}");
        // int[] sortedarr = { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
        // int target = 9;
        // int index = DSA.GfGSearchInSortedArray.Search(sortedarr, target);
        // if (index != -1)
        // {
        //     Console.WriteLine($"Element {target} found at index {index}");
        // }
        // else
        // {
        //     Console.WriteLine($"Element {target} not found in the array");
        // }
        Console.WriteLine("Find all triplets with zero sum in the array:");
        int[] tripletArr = { 0, -1, 2, -3, 1, -7, 8, 5, -4 };
        var triplets = DSA.GfGTripletSum.GetTripletIndexesWithZeroSum(tripletArr);
        if (triplets.Count > 0)
        {
            Console.WriteLine("Triplets with zero sum found:");
            foreach (var triplet in triplets)
            {
                Console.WriteLine($"Indices: {triplet[0]}, {triplet[1]}, {triplet[2]}");
            }
        }
        else
        {
            Console.WriteLine("No triplets with zero sum found.");
        }
        int[] water = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int maxWater = DSA.GfGMaxWater.MaxWater(water);
        Console.WriteLine($"Maximum water that can be contained: {maxWater}");

    }
}