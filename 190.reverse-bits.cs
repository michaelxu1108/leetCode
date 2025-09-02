/*
 * @lc app=leetcode id=190 lang=csharp
 *
 * [190] Reverse Bits
 */

// @lc code=start
public class Solution
{
    public int ReverseBits(int n)
    {
        int res = 0;
        for (int i = 0; i < 32; i++)
        {
            res <<= 1;
            res |= n & 1;
            n >>= 1;
        }
        return res;
    }
}
// @lc code=end

