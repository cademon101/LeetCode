using System.Globalization;
using System.Runtime.Serialization;

namespace solutions;
/// <summary>
/// Problem 88
/// Merge nums1 and nums2 into a single array sorted in non-decreasing order.
/// </summary>
///  Both are already sorted...   
///  num1 is a chest with enough space for both, but conatins both unsorted
///  We could use less than but that would mean that nums1 will only be less
///  
public class MergeSortedArray {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int counter = 0;
        for (int i = 0; i < nums1.Length ; i++)
        {
            if(nums1[i]>nums2[counter]){
                nums1
            }
        }
    }
} 