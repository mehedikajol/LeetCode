// problem name: Find All Anagrams in a String
// problem url: https://leetcode.com/problems/find-all-anagrams-in-a-string/description/

// Author: Mehedi Hasan Kajol
// Date: 03 Jan 2025
// Profile: https://leetcode.com/u/Mehedi/ 

namespace LeetCode.Solutions.Solution;

internal class LeetCode_00438
{
    public IList<int> FindAnagrams(string s, string p)
    {
        List<int> list = [];

        int[] pCount = new int[26], sCount = new int[26];

        foreach (char c in p)
        {
            pCount[c - 'a']++;
        }

        if(s.Length < p.Length)
        {
            return list;
        }

        string firstSubstring = s.Substring(0, p.Length);

        foreach (char c in firstSubstring)
        {
            sCount[c - 'a']++;
        }

        for (int i = 0; i <= s.Length - p.Length; i++)
        {
            if (IsEqual(pCount, sCount))
            {
                list.Add(i);
            }

            if(i + p.Length < s.Length)
            {
                sCount[s[i] - 'a']--;
                sCount[s[i + p.Length] - 'a']++;
            }
        }

        return list;
    }

    bool IsEqual(int[] s, int[] p)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != p[i])
            {
                return false;
            }
        }

        return true;
    }
}
