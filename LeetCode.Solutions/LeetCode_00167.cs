﻿
// problem name: Two Sum II - Input Array Is Sorted
// problem url: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/

// Author: Mehedi Hasan Kajol
// Date: 30 Dec 2024
// Profile: https://leetcode.com/u/Mehedi/ 

namespace LeetCode.Solutions;

internal class LeetCode_00167
{
    public int[] TwoSum(int[] numbers, int target)
    {
        Dictionary<int, int> keyValuePairs = new();

        for(int i = 0; i< numbers.Length; i++)
        {
            int diff = target - numbers[i];
            if(keyValuePairs.ContainsKey(diff))
            {
                return [keyValuePairs[diff] + 1, i + 1];
            }
            else
            {
                keyValuePairs[numbers[i]] = i;
            }
        }

        return [0, 0];
    }
}