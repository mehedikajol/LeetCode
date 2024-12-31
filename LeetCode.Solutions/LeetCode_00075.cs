
// problem name: Sort Colors
// problem url: https://leetcode.com/problems/sort-colors/description/

// Author: Mehedi Hasan Kajol
// Date: 31 Dec 2024
// Profile: https://leetcode.com/u/Mehedi/

namespace LeetCode.Solutions;

internal class LeetCode_00075
{
    public void SortColors(int[] nums)
    {
        BubbleSort_Optimized(nums);
    }

    // Bubble Sort
    private void BubbleSort(int[] nums)
    {
        int length = nums.Length;

        // Outer loop
        for (int i = 0; i < length - 1; i++)
        {
            // Inner loop
            for (int j = 0; j < length - i - 1; j++)
            {
                // Compare adjacent elements
                if (nums[j] > nums[j + 1])
                {
                    SwapArrayElements(nums, j, j + 1);
                }
            }
        }
    }

    // Optimized Bubble sort
    private void BubbleSort_Optimized(int[] nums)
    {
        int length = nums.Length;

        // Outer loop
        for (int i = 0; i < length - 1; i++)
        {
            bool swaped = false;
            // Inner loop
            for (int j = 0; j < length - i - 1; j++)
            {
                // Compare adjacent elements
                if (nums[j] > nums[j + 1])
                {
                    SwapArrayElements(nums, j, j + 1);
                    swaped = true;
                }
            }
            if (!swaped)
            {
                break;
            }
        }
    }

    private void SwapArrayElements(int[] nums, int indexOne, int indexTwo)
    {
        int temp = nums[indexOne];
        nums[indexOne] = nums[indexTwo];
        nums[indexTwo] = temp;
    }
}
