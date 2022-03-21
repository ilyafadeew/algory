using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Console = ALGORY.Extensions.Console;

namespace ALGORY.Sort;

public class QuickSort : ISortAlgorithm
{
    private int[] ArrayElements { get; set; }
    private int IterationCount { get; set; } = 0;

    public QuickSort(int[] array)
    {
        ArrayElements = array;
    }
    
    public (int iterationCount, int[] sotredArray) Sort()
    {
        var sortedArray = Algorythm(ArrayElements);
        
        Console.WriteLineInColor($"The hardness of {nameof(QuickSort)} algorithm is " +
                                 $"O(log2n*n) = O({Math.Log2(ArrayElements.Length) * ArrayElements.Length})", ConsoleColor.Yellow);

        return (IterationCount, sortedArray.ToArray());
    }

    private IEnumerable<int> Algorythm(IList<int> array)
    {
        if (array.Count <= 1)
            return array;

        var pivotIndex = array.Count / 2;
        var pivot = array[pivotIndex];
        var less = new List<int>();
        var greater = new List<int>();
        var summary = new List<int>();

        for (var i = 0; i < array.Count; i++)
        {
            IterationCount++;
            
            if(i == pivotIndex)
                continue;

            if (array[i] < pivot)
            {
                less.Add(array[i]);
            }
            else
            {
                greater.Add(array[i]);
            }
        }
        
        var sortedLess = Algorythm(less);
        var sortedGreater = Algorythm(greater);
            
        summary.AddRange(sortedLess);
        summary.Add(pivot);
        summary.AddRange(sortedGreater);
            
        return summary;
    }

}