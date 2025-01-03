// problem name: Longest Palindromic Substring
// problem url: https://leetcode.com/problems/longest-palindromic-substring/description/

// Author: Mehedi Hasan Kajol
// Date: 03 Jan 2025
// Profile: https://leetcode.com/u/Mehedi/ 

namespace LeetCode.Solutions.Solution;

internal class LeetCode_00005
{
    public string LongestPalindrome(string s)
    {
        int maxlen = 0;
        string result = string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            int l = i, r = i;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                if (r - l + 1 > maxlen)
                {
                    maxlen = r - l + 1;
                    result = s.Substring(l, maxlen);
                }
                l--;
                r++;
            }

            l = i;
            r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                if (r - l + 1 > maxlen)
                {
                    maxlen = r - l + 1;
                    result = s.Substring(l, maxlen);
                }
                l--;
                r++;
            }
        }

        return result;
    }
}
