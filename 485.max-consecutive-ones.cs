/*
 * @lc app=leetcode id=485 lang=csharp
 *
 * [485] Max Consecutive Ones
 */

// @lc code=start
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int cur = 0, best = 0;
        foreach (var n in nums)
        {
            if (n == 1)
            {
                cur++;
                if (cur > best)
                {
                    best = cur;
                }
            }
            else
            {
                cur = 0;
            }
        }
        return best;
    }
}
// @lc code=end

