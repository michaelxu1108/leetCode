/*
 * @lc app=leetcode id=1672 lang=csharp
 *
 * [1672] Richest Customer Wealth
 */

// @lc code=start
public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int maxWealthSoFar = 0;
        foreach (var customer in accounts)
        {
            int currentWealth = 0; // Initialize current wealth for each customer
            foreach (var account in customer) // [1,5], [2,3], [3,8]
            {
                currentWealth += account; // 1 + 5 = 6, 2 + 3 = 5, 3 + 8 = 11
            }
            if (currentWealth > maxWealthSoFar) // 6 > 0, 5 > 6, 11 > 6
            {
                maxWealthSoFar = currentWealth; // 6, 6, 11
            }
        }
        return maxWealthSoFar; // 11
    }
}
// @lc code=end

