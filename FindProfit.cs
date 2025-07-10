/// Stock Buy and Sell - Max one Transaction Allowed
/// Given an array prices[] of length N, representing the prices of the stocks on different days, 
/// the task is to find the maximum profit possible by buying and selling the stocks on different days 
/// when at most one transaction is allowed. 
/// Here one transaction means 1 buy + 1 Sell.

using System;
using System.Collections.Generic;


namespace DSA
{
    public class GfGProfit
    {
        public static int MaxProfit(int[] prices)
        {
            int minSoFar = prices[0];
            int res = 0;
            Console.WriteLine($"Initial minimum price: {minSoFar}");
            // Update the minimum value seen so far 
            // if we see smaller
            for (int i = 1; i < prices.Length; i++)
            {
                minSoFar = Math.Min(minSoFar, prices[i]);
                Console.WriteLine($"Updated minimum price at index {i}: {minSoFar}");
                // Update result if we get more profit                
                res = Math.Max(res, prices[i] - minSoFar);
                Console.WriteLine($"Current price: {prices[i]}, Profit if sold now: {prices[i] - minSoFar}, Max profit so far: {res}");
            }
            Console.WriteLine($"Maximum profit possible: {res}");
            return res;
        }

    }
}