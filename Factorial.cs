/// Given a number find the factorial of that number
/// Factorial of a number n is the product of all positive integers less than or equal to the number n.

using System;
using System.Collections.Generic;   

namespace DSA
{
    public class GfGFactorial
    {
        // Function to calculate factorial of a number
        public static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }
            if (n == 0 || n == 1)
            {
                return 1;
            }
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}