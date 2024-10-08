using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace solutions;
/// <summary>
/// Problem 88
/// Merge nums1 and nums2 into a single array sorted in non-decreasing order.
/// </summary>
///  Both are already sorted...   
///  num1 is a chest with enough space for both, but conatins both unsorted
///  We could use less than but that would mean that nums1 will only be less
///  My current idea: we make an array that acts as a cup and add depending upon its space 
///  [][Q] How can we merge succseful 
///  [][A] I found out we can just go backwards
public class MergeSortedArray {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int arraySize = m+n;
        int nums2Size = m;
        if(arraySize == 1)
        {
            if(nums1.Length == 0)
            {
                Array.Copy(nums2, nums1, n);
                return;
            }
            return;
        }
        for (int i = 0; i < m ; i++)
        {
            nums1[arraySize-1] = nums2[nums2Size-1];
            arraySize--;
            nums2Size--;            
        }
        Array.Sort(nums1);
    }
} 