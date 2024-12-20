using LeetCode.Solutions;

int[] data = [8154, 9139, 8194, 3346, 5450, 9190, 133, 8239, 4606, 8671, 8412, 6290];

var obj = new LeetCode_02404();

var result = obj.MostFrequentEven(data);

PrintInt(result);

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