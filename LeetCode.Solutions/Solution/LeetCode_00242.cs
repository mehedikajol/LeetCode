// problem name: Valid Anagram
// problem url: https://leetcode.com/problems/valid-anagram/description/

// Author: Mehedi Hasan Kajol
// Date: 02 Jan 2025
// Profile: https://leetcode.com/u/Mehedi/

namespace LeetCode.Solutions.Solution;

internal class LeetCode_00242
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> firstKeyValuePairs = new();
        Dictionary<char, int> secondKeyValuePairs = new();

        if (s.Length != t.Length)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (firstKeyValuePairs.ContainsKey(s[i]))
            {
                firstKeyValuePairs[s[i]]++;
            }
            else
            {
                firstKeyValuePairs.Add(s[i], 1);
            }

            if (secondKeyValuePairs.ContainsKey(t[i]))
            {
                secondKeyValuePairs[t[i]]++;
            }
            else
            {
                secondKeyValuePairs.Add(t[i], 1);
            }
        }

        foreach (KeyValuePair<char, int> entry in firstKeyValuePairs)
        {
            if (!secondKeyValuePairs.ContainsKey(entry.Key) || (secondKeyValuePairs[entry.Key] != entry.Value))
            {
                return false;
            }
        }

        return true;
    }
}
