
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
        MergeSort(nums);
    }

    #region Bubble Sort
    // Regular Bubble Sort
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
    #endregion

    #region Selection Sort
    // Selection Sort
    private void SelectionSort(int[] nums)
    {
        int length = nums.Length;

        for (int i = 0; i < length - 1; i++)
        {
            int min_index = i;
            for (int j = i + 1; j < length; j++)
            {
                if (nums[j] < nums[min_index])
                {
                    min_index = j;
                }
            }

            SwapArrayElements(nums, i, min_index);
        }
    }
    #endregion

    #region Insertion Sort
    // Insertion Sort
    private void InsertionSort(int[] nums)
    {
        int length = nums.Length;

        for (int i = 1; i < length; i++)
        {
            int elemtentToCompare = nums[i];
            int j = i - 1;

            while (j >= 0 && nums[j] > elemtentToCompare)
            {
                nums[j + 1] = nums[j];
                j--;
            }
            nums[j + 1] = elemtentToCompare;
        }
    }
    #endregion

    #region Merge Sort
    // Merge Sort
    private void MergeSort(int[] nums)
    {
        int length = nums.Length;
        if (length <= 1)
        {
            return;
        }

        int mid = length / 2;
        int[] leftArray = new int[mid];
        int[] rightArray = new int[length - mid];

        int i = 0, j = 0;

        for (; i < length; i++)
        {
            if (i < mid)
            {
                leftArray[i] = nums[i];
            }
            else
            {
                rightArray[j] = nums[i];
                j++;
            }
        }

        MergeSort(leftArray);
        MergeSort(rightArray);
        Merge(nums, leftArray, rightArray);
    }

    // Merge method
    private void Merge(int[] array, int[] leftArray, int[] rightArray)
    {
        int length = array.Length;
        int leftSize = length / 2;
        int rigthSize = length - leftSize;

        int i = 0, l = 0, r = 0;

        while (l < leftSize && r < rigthSize)
        {
            if (leftArray[l] < rightArray[r])
            {
                array[i] = leftArray[l];
                i++;
                l++;
            }
            else
            {
                array[i] = rightArray[r];
                i++;
                r++;
            }
        }
        while (l < leftSize)
        {
            array[i] = leftArray[l];
            i++;
            l++;
        }
        while (r < rigthSize)
        {
            array[i] = rightArray[r];
            i++;
            r++;
        }
    }
    #endregion

    /// <summary>
    /// Swap array elements
    /// </summary>
    /// <param name="nums">Inputed array needs to be swapped</param>
    /// <param name="indexOne">Swap element index one</param>
    /// <param name="indexTwo">Swap element index two</param>
    private void SwapArrayElements(int[] nums, int indexOne, int indexTwo)
    {
        int temp = nums[indexOne];
        nums[indexOne] = nums[indexTwo];
        nums[indexTwo] = temp;
    }
}
