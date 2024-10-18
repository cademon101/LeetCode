
// Is this nested for loop bad?


using System.Data.Common;

/// <summary>
/// Remove all occurrences of val in nums, return the number of elements in nums which are not equal to val.
/// </summary>
/// 
/// Change the array nums such that the first k elements of nums contain the elements which are not equal to val. 
/// 
/// The remaining elements of nums are not important as well as the size of nums.
/// 
/// What I am going to do is keep a pointer to any spots in the front then swap spots with a thing at the end
/// Once we run into a spot with 
/// Im working backwords!!!
public class RemoveElementInArray {
    public int RemoveElement(int[] nums, int val) {

    int k=0;
    int valToReplace;
    int spotForVal;

    for (int i = nums.Length-1; i >= 0; i--)
    {
        if (nums[i]==val)
        {
            k++;
            for (int i2 = nums.Length-1; i2 >= 0; i2--) 
            {
                if(i == nums.Length) break;
                if(nums[i2] != val)
                { 
                valToReplace = nums[i2];
                nums[i2] = val;
                nums[i] = valToReplace;    
                break;
                }
            }
            
        }

    }
    return k;
    }
}