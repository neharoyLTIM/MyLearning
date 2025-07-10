///Container with Most Water
/// Given an array arr[] of non-negative integers, where each element arr[i] represents the height of the vertical lines,
/// find the maximum amount of water that can be contained between any two lines, together with the x-axis.

using System;
using System.Collections.Generic;

namespace DSA
{
    public class GfGMaxWater
    {
        // Function to find the maximum water that can be contained
        public static int MaxWater(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                // Calculate the width and height
                int width = right - left;
                int h = Math.Min(height[left], height[right]);
                // Calculate the area
                int area = width * h;
                // Update maxArea if the current area is larger
                maxArea = Math.Max(maxArea, area);

                // Move the pointer pointing to the shorter line
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }
    }
}