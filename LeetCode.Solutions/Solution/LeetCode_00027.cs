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
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[count++] = nums[i];
            }
        }

        return count;
    }
}
