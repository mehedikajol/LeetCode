// problem name: Majority Element
// problem url: https://leetcode.com/problems/majority-element/description/

// Author: Mehedi Hasan Kajol
// Date: 20 Dec 2024
// Profile: https://leetcode.com/u/Mehedi/

namespace LeetCode.Solutions.Solution;

internal class LeetCode_00169
{
    public int MajorityElement(int[] nums)
    {
        var valuesTable = new Dictionary<int, int>();
        foreach (var item in nums)
        {
            if (valuesTable.ContainsKey(item))
            {
                valuesTable[item]++;
            }
            else
            {
                valuesTable.Add(item, 1);
            }

            if (valuesTable[item] > nums.Length / 2)
                return item;
        }
        return 0;
    }
}
