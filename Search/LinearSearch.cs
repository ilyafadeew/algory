using System;
using System.Collections.Generic;
using ALGORY.Extensions;
using Console = ALGORY.Extensions.Console;

namespace ALGORY
{
    public class LinearSearch : ISearchAlgorithm
    {
        private int[] ArrayElements { get; set; }
        private int SearchElement { get; set; }

        public LinearSearch(int[] array, int searchElement)
        {
            ArrayElements = array;
            SearchElement = searchElement;
        }
        
        public (int iterationCount, bool isElementFound) Search()
        {
            var iterationCount = 0;
            var isElementFound = false;
            
            foreach (var arrayElement in ArrayElements)
            {
                iterationCount++;
                if (arrayElement != SearchElement) continue;
                isElementFound = true;
                break;
            }

            Console.WriteLineInColor($"The hardness of {nameof(LinearSearch)} " +
                                       $"algorithm is O(n) = O({ArrayElements.Length})", ConsoleColor.Yellow);
            return (iterationCount, isElementFound);
        }
    }
}