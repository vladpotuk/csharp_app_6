using System;

class Program3
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 2, 3, 4, 5 };
        IntArray3 array = new IntArray3(arr);

        Console.WriteLine($"Кількість унікальних значень: {array.CountDistinct()}");

        int valueToCompare = 3;
        Console.WriteLine($"Кількість значень, рівних {valueToCompare}: {array.EqualToValue(valueToCompare)}");
    }
}
