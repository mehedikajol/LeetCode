﻿// problem name: Valid Palindrome
// problem url: https://leetcode.com/problems/valid-palindrome/description/

// Author: Mehedi Hasan Kajol
// Date: 02 Jan 2025
// Profile: https://leetcode.com/u/Mehedi/ 

namespace LeetCode.Solutions.Solution;

internal class LeetCode_00125
{
    public bool IsPalindrome(string s)
    {
        int first = 0, last = s.Length - 1;

        while (first < last)
        {
            if (!char.IsLetterOrDigit(s[first]))
            {
                first++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[last]))
            {
                last--;
                continue;
            }

            if (char.ToLower(s[first]) != char.ToLower(s[last]))
            {
                return false;
            }
            first++;
            last--;
        }

        return true;
    }
}
