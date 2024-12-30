namespace LeetCode.Solutions;

internal class LeetCode_00217
{
    // problem name: Contains Duplicate
    // problem url: https://leetcode.com/problems/contains-duplicate/description/

    // Author: Mehedi Hasan Kajol
    // Date: 30 Dec 2024
    // Profile: https://leetcode.com/u/Mehedi/

    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> values = new(nums);
        if(values.Count != nums.Length)
        {
            return true;
        }

        //Dictionary<int, int> keyValuePairs = new();

        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (keyValuePairs.ContainsKey(nums[i]))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        keyValuePairs.Add(nums[i], 1);
        //    }
        //}

        return false;
    }
}
