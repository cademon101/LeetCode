
using System;
using System.Linq;
namespace Two_sum_leetcode_1;
using solutions;
public static class Program
{
    public static void Main(string[] args)
    {
        MergeSortedArray solution = new MergeSortedArray();
        int[] nums1 = {1,2,3,0,0,0};
        int n = 3;
        int[] nums2 = {2,5,6};
        int m = 3;

        solution.Merge(nums1, m, nums2, n);
        Console.WriteLine($"[{string.Join(", ", nums1)}]"); 
        //Console.WriteLine($"[{string.Join(", ", solution.Merge(nums1, m, nums2, n))}]");
    }
}


