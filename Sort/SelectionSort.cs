using System;
using System.Data;
using Console = ALGORY.Extensions.Console;

namespace ALGORY.Sort
{
    public class SelectionSort : ISortAlgorithm
    {
        private int[] ArrayElements { get; set; }

        public SelectionSort(int[] array)
        {
            ArrayElements = array;
        }
        
        public (int iterationCount, int[] sotredArray) Sort()
        {
            var iterationCount = 0;
            
            for (var i = 0; i < ArrayElements.Length; i++)
            {
                var indexMin = i;
                for (var j = i+1; j < ArrayElements.Length; j++)
                {
                    if (ArrayElements[j] < ArrayElements[indexMin])
                        indexMin = j;
                    
                    iterationCount++;
                }

                (ArrayElements[i], ArrayElements[indexMin]) = (ArrayElements[indexMin], ArrayElements[i]);
            }
            
            Console.WriteLineInColor($"The hardness of {nameof(SelectionSort)} algorithm is " +
                                     $"O(n^2) = O({ArrayElements.Length*ArrayElements.Length})", ConsoleColor.Yellow);
            
            return (iterationCount, ArrayElements);
        }
    }
}