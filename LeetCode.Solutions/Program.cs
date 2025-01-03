﻿using LeetCode.Solutions.Solution;

int[] data = [1, 8, 6, 2, 5, 4, 8, 3, 7];
string s = "-5";

var obj = new LeetCode_00008();

var result = obj.MyAtoi(s);
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