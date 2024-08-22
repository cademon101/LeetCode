
using System;
using System.Linq;
namespace Two_sum_leetcode_1;

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] testArray = { 2, 7, 11, 15 };
        Console.WriteLine($"[{string.Join(", ", solution.twoSum(testArray, 9))}]");
    }
}


