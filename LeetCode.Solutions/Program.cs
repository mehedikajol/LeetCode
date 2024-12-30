using LeetCode.Solutions;

int[][] data = [[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]];

var obj = new LeetCode_00056();

var result = obj.Merge(data);

Print2DCollection(result);

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