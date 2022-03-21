using System;
using System.Collections.Generic;
using System.Linq;
using ALGORY.Extensions;
using Console = ALGORY.Extensions.Console;

namespace ALGORY
{
    public class BinarySearch : ISearchAlgorithm
    {
        private int[] ArrayElements { get; set; }
        private int SearchElement { get; set; }

        public BinarySearch(int[] array, int searchElement)
        {
            ArrayElements = array;
            Array.Sort(ArrayElements);
            SearchElement = searchElement;
        }

        public (int iterationCount, bool isElementFound) Search()
        {
            var iterationCount = 0;
            var elementFounded = false;
            var middle = ArrayElements.Length/2;

            while (ArrayElements[middle] != SearchElement && ArrayElements.Length > 1)
            {
                iterationCount++;
                
                ArrayElements = ArrayElements[middle] > SearchElement ? 
                    ArrayElements.Take(middle).ToArray() 
                    :
                    ArrayElements.Skip(middle).ToArray();

                middle = ArrayElements.Length / 2;
            }
            
            if (ArrayElements[middle] == SearchElement)
                elementFounded = true;
            
            Console.WriteLineInColor($"The hardness of {nameof(BinarySearch)} algorithm is " +
                                       $"O(log2n) = O({Math.Log2(ArrayElements.Length)})", ConsoleColor.Yellow);
            return (iterationCount, elementFounded);
        }
    }
}