using LeetCode.Solutions;

int[] data = [1, 2];

var obj = new LeetCode_00229();

var result = obj.MajorityElement(data);

PrintCollection(result);

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

#endregion