using LeetCode.Solutions;

var data = new int[] { 2, 2, 1, 1, 1, 2, 2 };

var obj = new LeetCode_00169();

var result = obj.MajorityElement(data);

PrintInt(result);

#region Print Methods

void PrintInt(int data)
{
    Console.WriteLine(data);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

#endregion