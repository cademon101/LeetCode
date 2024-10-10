using System.Globalization;
using System.Linq.Expressions;
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
///  This one was a pain, it was most certainly a learning experiance but one that left me feeling defeated. 
///  Had cheat the answerer in the end gonna spam comments to find out how I did it
///    
public class MergeSortedArray {
 public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int nums1Pointer = m-1; //Translate pointers
        int nums2Pointer = n-1; 
        int totalSize = m+n-1; 

        //this loop and each loop subtracts from the 'nums pointer' to get total
        //Main goal is use nums2 pointer till its all in 
        while (nums2Pointer>=0) //while nums 2 isnt all checked out 
        {
            //IF we have space left in nums1 && when the spot in nums is > than the spot in nums2
            if(nums1Pointer >=0 && nums1[nums1Pointer] > nums2[nums2Pointer] ) 
                nums1[totalSize--] = nums1[nums1Pointer--]; //nums1 just equals the nums1 
            else 
                nums1[totalSize--] = nums2[nums2Pointer--]; //the nums1 were pointing at with the total = the nums2
        }
        //Array.Sort(nums1);
    }
} 