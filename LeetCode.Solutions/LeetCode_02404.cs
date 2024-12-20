namespace LeetCode.Solutions;

internal class LeetCode_02404
{
    // problem name: Frequent Even Element
    // problem url: https://leetcode.com/problems/most-frequent-even-element/description/

    // Author: Mehedi Hasan Kajol
    // Date: 21 Dec 2024
    // Profile: https://leetcode.com/u/Mehedi/ 

    public int MostFrequentEven(int[] nums)
    {
        var valuesTable = new SortedDictionary<int, int>();

        foreach (var num in nums)
        {
            if (num % 2 == 0)
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
        }

        if (valuesTable.Count == 0)
        {
            return -1;
        }

        var maxValue = valuesTable.Values.Max();
        return valuesTable
            .First(p => p.Value == maxValue)
            .Key;
    }
}
