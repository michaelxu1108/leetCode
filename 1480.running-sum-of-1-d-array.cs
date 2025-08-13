/*
 * @lc app=leetcode id=1480 lang=csharp
 *
 * [1480] Running Sum of 1d Array
 */

// @lc code=start
public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int[] result = new int[nums.Length];
        result[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = nums[i] + result[i - 1];


        }
        return result;
    }
}
// @lc code=end

