// problem name: Longest Substring Without Repeating Characters
// problem url: https://leetcode.com/problems/longest-substring-without-repeating-characters/description/

// Author: Mehedi Hasan Kajol
// Date: 03 Jan 2025
// Profile: https://leetcode.com/u/Mehedi/ 

namespace LeetCode.Solutions.Solution;

internal class LeetCode_00003
{
    public int LengthOfLongestSubstring(string s)
    {
        List<char> substr = new();

        int r = 0, l = 0, maxLength = 0;

        while (r < s.Length) // abcabcbb
        {
            if (substr.Contains(s[r]))
            {
                substr.Remove(s[l]);
                l++;
            }
            else
            {
                substr.Add(s[r]);
                r++;
            }

            maxLength = maxLength > substr.Count ? maxLength : substr.Count;
        }

        return maxLength;
    }
}
