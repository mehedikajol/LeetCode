// problem name: Majority Element II
// problem url: https://leetcode.com/problems/majority-element-ii/

// Author: Mehedi Hasan Kajol
// Date: 20 Dec 2024
// Profile: https://leetcode.com/u/Mehedi/

namespace LeetCode.Solutions.Solution;

internal class LeetCode_00229
{
    public IList<int> MajorityElement(int[] nums)
    {
        var valuesTable = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (valuesTable.ContainsKey(num))
            {
                valuesTable[num]++;
            }
            else
            {
                valuesTable.Add(num, 1);
            }
        }

        var result = new List<int>();

        var reference = nums.Length / 3;
        foreach (var key in valuesTable.Keys)
        {
            if (valuesTable[key] > reference)
            {
                result.Add(key);
            }
        }

        return result;
    }
}
