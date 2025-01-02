// problem name: Longest Palindrome
// problem url: https://leetcode.com/problems/longest-palindrome/description/

// Author: Mehedi Hasan Kajol
// Date: 02 Jan 2025
// Profile: https://leetcode.com/u/Mehedi/

namespace LeetCode.Solutions.Solution;

internal class LeetCode_00409
{
    public int LongestPalindrome(string s)
    {
        Dictionary<char, int> keyValuePairs = new();
        int maxPalindromeLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (keyValuePairs.ContainsKey(s[i]))
            {
                keyValuePairs[s[i]]++;
            }
            else
            {
                keyValuePairs.Add(s[i], 1);
            }
        }

        int maxOddLength = 0;
        foreach (var kvp in keyValuePairs)
        {
            if (kvp.Value % 2 == 0)
            {
                maxPalindromeLength += kvp.Value;
            }
            else
            {
                if (maxOddLength > kvp.Value)
                {
                    maxPalindromeLength += kvp.Value > 2 ? kvp.Value - 1 : 0;
                }
                else
                {
                    maxPalindromeLength += maxOddLength > 2 ? maxOddLength - 1 : 0;
                    maxOddLength = kvp.Value;
                }
            }
        }
        maxPalindromeLength += maxOddLength;

        return maxPalindromeLength;
    }
}
