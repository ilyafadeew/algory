using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ALGORY.Extensions;
using ALGORY.Sort;
using static System.Int32;
using Console = ALGORY.Extensions.Console;

namespace ALGORY
{
    class Program
    {
        private static int[] ArrayElements { get; set; } = {1, 6, 8, 3, 9, 7, 4, 2, 63, 7, 3784, 35, 6, 27};
        private static int SearchElement { get; set; } = 29;
        private const bool IsAppRunning = true;


        private static void Main(string[] args)
        {
            var arrayElementsInString = string.Join(",", ArrayElements.Select(element => element.ToString()).ToArray());
            Console.WriteLineInColor("Array of elements = "+arrayElementsInString, ConsoleColor.Green);
            
            var sortingAlgorithms = new List<ISortAlgorithm>()
            {
                new SelectionSort(ArrayElements),
                new BoubbleSort(ArrayElements),
                new QuickSort(ArrayElements)
            };
            foreach (var sortingAlgorithm in sortingAlgorithms)
            {
                var (iterationCount, sortedArray) = sortingAlgorithm.Sort();
                var sortedArrayInString = string.Join(",", sortedArray.Select(element => element.ToString()).ToArray());
                
                Console.WriteLineInColor($"Sorting algorithm is {sortingAlgorithm.GetType().Name}." +
                                         $" Sorted array is {sortedArrayInString}. Iteration count is {iterationCount}", ConsoleColor.Blue);
            }

            var (multiplyDigit, loopCount) =  Recursion.Multiply(3);
            Console.WriteLineInColor($"Recursive multiply digit is = {multiplyDigit}, loopCount is {loopCount}", ConsoleColor.Red);
            
            while (IsAppRunning)
            {
                Console.WriteLineInColor("Enter an element to search: ", ConsoleColor.Green);
                var userTypedElement = System.Console.ReadLine();
                SearchElement = Parse(string.IsNullOrEmpty(userTypedElement) ? SearchElement.ToString() : userTypedElement);
            
                var searchAlgorithms = new List<ISearchAlgorithm>()
                {
                    new LinearSearch(ArrayElements, SearchElement),
                    new BinarySearch(ArrayElements, SearchElement)
                };
                foreach (var searchAlgorithm in searchAlgorithms)
                {
                    var (iterationCount, isElementFound) = searchAlgorithm.Search();

                    Console.WriteLineInColor($"{searchAlgorithm.GetType().Name} element found ?" +
                                               $" {isElementFound}. Iteration count is {iterationCount}", ConsoleColor.Blue);
                }
            }
        }
    }
}