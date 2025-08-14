/*
 * @lc app=leetcode id=326 lang=csharp
 *
 * [326] Power of Three
 */

// @lc code=start
public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n <= 0)
        {
            return false;
        }
        while (n % 3 == 0)
        {
            n /= 3;
        }
        return n == 1; // 回傳 true 代表 n 是 3 的次方
    }
}
// @lc code=end

