
using System;
using System.Linq;
namespace Two_sum_leetcode_1;

using System.Runtime.InteropServices;
using solutions;
public static class Program
{
    public static void Main(string[] args)
    {
        RemoveElementInArray solution = new RemoveElementInArray();
        int[] nums1 = {0,1,2,2,3,0,4,2};


        //solution.RemoveElement(nums1, 3);
        System.Console.WriteLine(solution.RemoveElement(nums1, 2));
        Console.WriteLine($"[{string.Join(", ", nums1)}]"); 
        //Console.WriteLine($"[{string.Join(", ", solution.Merge(nums1, m, nums2, n))}]");
    }
}


