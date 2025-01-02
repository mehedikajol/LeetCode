using LeetCode.Solutions.Solution;

int[] data = [1, 8, 6, 2, 5, 4, 8, 3, 7];
string stringData = "A man, a plan, a canal: Panama";

var obj = new LeetCode_00125();

var result = obj.IsPalindrome(stringData);
//obj.SortColors(data);

PrintBoolean(result);

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