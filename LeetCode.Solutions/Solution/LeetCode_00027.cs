// problem name: Remove Element
// problem url: https://leetcode.com/problems/remove-element/description/

// Author: Mehedi Hasan Kajol
// Date: 03 Jan 2025
// Profile: https://leetcode.com/u/Mehedi/ 

namespace LeetCode.Solutions.Solution;

internal class LeetCode_00027
{
    public int RemoveElement(int[] nums, int val)
    {
        List<int> list = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                list.Add(nums[i]);
            }
        }

        for (int i = 0; i < list.Count; i++)
        {
            nums[i] = list[i];
        }

        return list.Count;
    }
}
