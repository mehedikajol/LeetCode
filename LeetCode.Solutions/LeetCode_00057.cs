﻿
// problem name: Insert Interval
// problem url: https://leetcode.com/problems/insert-interval/description/

// Author: Mehedi Hasan Kajol
// Date: 30 Dec 2024
// Profile: https://leetcode.com/u/Mehedi/ 

namespace LeetCode.Solutions;

internal class LeetCode_00057
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        intervals = intervals
            .Append(newInterval)
            .OrderBy(x => x[0])
            .ToArray();

        List<int[]> result = new();

        result.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++)
        {
            if (result[result.Count - 1][1] >= intervals[i][0])
            {
                result[result.Count - 1][1] = int.Max(result[result.Count - 1][1], intervals[i][1]);
            }
            else
            {
                result.Add(intervals[i]);
            }
        }

        return result.ToArray();
    }
}
