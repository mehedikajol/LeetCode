// problem name: String to Integer (atoi)
// problem url: https://leetcode.com/problems/string-to-integer-atoi/description/

// Author: Mehedi Hasan Kajol
// Date: 03 Jan 2025
// Profile: https://leetcode.com/u/Mehedi/ 

namespace LeetCode.Solutions.Solution;

internal class LeetCode_00008
{
    public int MyAtoi(string s)
    {
        long tempResult = 0;
        int i = 0;
        bool isNegative = false;

        for (; i < s.Length; i++)
        {
            if (s[i] != ' ')
                break;
        }

        if (s.Length > i && s[i] == '-')
        {
            isNegative = true;
            i++;
        }
        else if (s.Length > i && s[i] == '+')
        {
            i++;
        }

        for (; i < s.Length; i++)
        {
            if (char.IsDigit(s[i]))
            {
                tempResult = tempResult * 10 + (s[i] - '0');
                if (tempResult > int.MaxValue)
                {
                    if (isNegative)
                    {
                        return int.MinValue;
                    }
                    return int.MaxValue;
                }
            }
            else
            {
                break;
            }
        }

        return (int)tempResult * (isNegative ? -1 : 1);
    }
}
