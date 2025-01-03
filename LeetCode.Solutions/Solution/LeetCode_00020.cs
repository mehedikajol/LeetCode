// problem name: Valid Parentheses
// problem url: https://leetcode.com/problems/valid-parentheses/description/

// Author: Mehedi Hasan Kajol
// Date: 04 Jan 2025
// Profile: https://leetcode.com/u/Mehedi/ 

namespace LeetCode.Solutions.Solution;

internal class LeetCode_00020
{
    public bool IsValid(string s)
    {
        Stack<char> closes = [];
        Dictionary<char, char> keys = new Dictionary<char, char> { { '(', ')' }, { '{', '}' }, { '[', ']' } };

        for (int i = 0; i < s.Length; i++)
        {
            if (keys.ContainsKey(s[i]))
            {
                closes.Push(keys[s[i]]);
            }
            else
            {
                if (!closes.Any() || closes.Pop() != s[i])
                {
                    return false;
                }
            }
        }

        return !closes.Any();
    }
}
