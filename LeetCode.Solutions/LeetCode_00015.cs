// copilot: disable

// problem name: 3Sum
// problem url: https://leetcode.com/problems/3sum/description/

// Author: Mehedi Hasan Kajol
// Date: 30 Dec 2024
// Profile: https://leetcode.com/u/Mehedi/ 

namespace LeetCode.Solutions;

internal class LeetCode_00015
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        List<int[]> result = new();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int target = 0 - nums[i], left = i + 1, right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == target)
                {
                    result.Add([nums[i], nums[left], nums[right]]);
                    left++;
                    while (nums[left] == nums[left - 1] && left < right)
                    {
                        left++;
                    }
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result.ToArray();
    }
}
