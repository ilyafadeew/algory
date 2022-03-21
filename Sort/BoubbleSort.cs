using System;
using Console = ALGORY.Extensions.Console;

namespace ALGORY.Sort
{
    public class BoubbleSort : ISortAlgorithm
    {
        private int[] ArrayElements { get; set; }

        public BoubbleSort(int[] array)
        {
            ArrayElements = array;
        }
        
        public (int iterationCount, int[] sotredArray) Sort()
        {
            var iterationCount = 0;
            for (var i = 0; i < ArrayElements.Length; i++)
            {
                for (var j = 0; j < ArrayElements.Length; j++)
                {
                    if (j + 1 < ArrayElements.Length)
                        if (ArrayElements[j + 1] < ArrayElements[j])
                            (ArrayElements[j], ArrayElements[j + 1]) = (ArrayElements[j + 1], ArrayElements[j]);
                    
                    iterationCount++;
                }   
            }
             
            Console.WriteLineInColor($"The hardness of {nameof(BoubbleSort)} algorithm is " +
                                     $"O(n^2) = O({ArrayElements.Length*ArrayElements.Length})", ConsoleColor.Yellow);

            return (iterationCount, ArrayElements);
        }
    }
}