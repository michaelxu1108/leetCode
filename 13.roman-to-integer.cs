/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> map = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int value = map[s[i]];
            if (i < s.Length - 1 && value < map[s[i + 1]])
            {
                total -= value; // 減法
            }
            else
            {
                total += value; // 加法
            }
        }
        return total;
    }
}
// @lc code=end

