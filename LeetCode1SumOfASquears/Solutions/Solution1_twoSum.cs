public class Solution
{
    public int[] twoSum(int[] nums, int target)
    {
        for (int curIndex = 0; curIndex < nums.Length; curIndex++)
        {
            int num1 = nums[curIndex];
            for (int comparIndex = 0; comparIndex < nums.Length; comparIndex++)
            {
                if (curIndex == comparIndex) { break; }
                int num2 = nums[comparIndex];
                if (num1 + num2 == target)
                {
                    return new int[2] { curIndex, comparIndex };
                }

            }
        }
        return new int[2] { 99, 99 };
    }
}