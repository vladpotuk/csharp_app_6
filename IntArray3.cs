using System;
using System.Collections.Generic;

public class IntArray3 : ICalc2
{
    private int[] elements;

    public IntArray3(int[] arr)
    {
        elements = arr;
    }

    public int CountDistinct()
    {
        HashSet<int> uniqueValues = new HashSet<int>(elements);
        return uniqueValues.Count;
    }

    public int EqualToValue(int valueToCompare)
    {
        int count = 0;
        foreach (var element in elements)
        {
            if (element == valueToCompare)
                count++;
        }
        return count;
    }
}
