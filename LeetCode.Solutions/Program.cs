using LeetCode.Solutions;

int[] data = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];

var obj = new LeetCode_00217();

var result = obj.ContainsDuplicate(data);

PrintBoolean(result);

#region Print Methods

void PrintInt(int data)
{
    Console.WriteLine(data);
}

void PrintCollection(IEnumerable<int> arr)
{
    for (int i = 0; i < arr.Count(); i++)
    {
        Console.Write(arr.ElementAt(i) + " ");
    }
    Console.WriteLine();
}

void PrintBoolean(bool data)
{
    Console.WriteLine(data ? "True" : "False");
}

#endregion