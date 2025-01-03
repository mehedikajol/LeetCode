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
        List<char> stack = [];

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Add(')');
            }
            else if (s[i] == '{')
            {
                stack.Add('}');
            }
            else if (s[i] == '[')
            {
                stack.Add(']');
            }
            else
            {
                if (stack.Count == 0 || stack[stack.Count - 1] != s[i])
                {
                    return false;
                }
                stack.RemoveAt(stack.Count - 1);
            }
        }

        return stack.Count == 0;
    }
}
