
/// <summary>
/// Remove all occurrences of val in nums, return the number of elements in nums which are not equal to val.
/// </summary>
/// Change the array nums such that the first k elements of nums contain the elements which are not equal to val. 
/// The remaining elements of nums are not important as well as the size of nums.


public class RemoveElementInArray {
    public int RemoveElement(int[] nums, int val) {
    
    int k=0;
    for (int i = nums.Length-1; i >= 0; i--)
    {
        if (nums[i]==val) k++;
    }
    
    return k;
    }
}