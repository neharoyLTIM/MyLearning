/// Product of Array Except Self
/// Given an array arr[] of n integers, construct a product array res[] (of the same size) 
/// such that res[i] is equal to the product of all the elements of arr[] except arr[i].
using System;
using System.Collections.Generic;

namespace DSA
{
    public class ProductArray
    {
        // Function to find the product of all elements in an array - Default 2 loops approach
        public static Dictionary<int, int> Product(int[] arr)
        {
            var products = new Dictionary<int, int>();
            int product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product = 1;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        product *= arr[j];
                    }

                }
                products.Add(arr[i], product);
                Console.WriteLine($"Multiplying {arr[i]}, Current product: {product}");
            }

            return products;
        }

        public static int[] productExceptSelf(int[] arr)
        {
            int n = arr.Length;
            int[] prefProduct = new int[n];
            int[] suffProduct = new int[n];
            int[] res = new int[n];
            //int[] productInts = { 7, 10, 1, 3, 6, 9, 2 };
            // Construct the prefProduct array
            prefProduct[0] = 1;
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("Array element at index " + (i - 1) + ": " + arr[i - 1]);
                Console.WriteLine("Prefix Product of index i-1 " + (i - 1) + ": " + prefProduct[i - 1]);
                prefProduct[i] = arr[i - 1] * prefProduct[i - 1];
                Console.WriteLine("Prefix Product of index i-1 " + i + ": " + prefProduct[i]);
            }
            // Construct the suffProduct array
            suffProduct[n - 1] = 1;
            for (int j = n - 2; j >= 0; j--)
            {
                Console.WriteLine("Array element at index j+1 " + (j + 1) + ": " + arr[j + 1]);
                Console.WriteLine("Suffix Product of index j+1 " + (j + 1) + ": " + suffProduct[j + 1]);
                suffProduct[j] = arr[j + 1] * suffProduct[j + 1];
                Console.WriteLine("Suffix Product of index j " + j + ": " + suffProduct[j]);
            }
            // Construct the result array using
            // prefProduct[] and suffProduct[]
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Prefix Product at index " + i + ": " + prefProduct[i]);
                Console.WriteLine("Suffix Product at index " + i + ": " + suffProduct[i]);
                res[i] = prefProduct[i] * suffProduct[i];
                Console.WriteLine("Result at index " + i + ": " + res[i]);
            }
            return res;
    }
        
        
    }
}