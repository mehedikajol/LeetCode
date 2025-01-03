using LeetCode.Solutions.Solution;

int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
int target = 2;
string s = "-5";

var obj = new LeetCode_00027();

var result = obj.RemoveElement(nums, target);
//obj.SortColors(data);

PrintInt(result);

#region Print Methods

void PrintInt(int data)
{
    Console.WriteLine(data);
}

void PrintCollection<TValue>(IEnumerable<TValue> arr)
{
    for (int i = 0; i < arr.Count(); i++)
    {
        Console.Write(arr.ElementAt(i) + " ");
    }
    Console.WriteLine();
}

void Print2DCollection<T>(IEnumerable<IEnumerable<T>> collection)
{
    foreach (var innerCollection in collection)
    {
        PrintCollection(innerCollection);
    }
}

void PrintBoolean(bool data)
{
    Console.WriteLine(data ? "True" : "False");
}

#endregion