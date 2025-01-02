// problem name: Container With Most Water
// problem url: https://leetcode.com/problems/container-with-most-water/description/

// Author: Mehedi Hasan Kajol
// Date: 02 Jan 2025
// Profile: https://leetcode.com/u/Mehedi/ 

namespace LeetCode.Solutions.Solution;

internal class LeetCode_00011
{
    public int MaxArea(int[] height)
    {
        int maxVolume = 0, left = 0, right = height.Length - 1;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                maxVolume = Max(maxVolume, (right - left) * height[left++]);
            }
            else
            {
                maxVolume = Max(maxVolume, (right - left) * height[right--]);
            }
        }

        return maxVolume;
    }

    private int Max(int a, int b)
    {
        return a > b ? a : b;
    }
}
