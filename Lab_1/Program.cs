using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to find the sum of all elements in an integer array using a loop
            /*int sum = 0;
            int [] arr = { 1, 2, 3,4,5};
            for (int i = 0; i < arr.Length; i++) 
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);*/


            //Create a C# program that calculates the average of values in a floating-point array using a loop.
            /*float sum = 0;
            float[] arr = { 2.4f, 5.6f,6.7f,45.6f};

            foreach (float f in arr) 
            {
                sum += f;
            }
            float avg = sum / arr.Length;
            Console.WriteLine(avg);*/


            //Develop a C# program that finds the largest element in an integer array using a loop and if-else statements.

            /*int[] numbers = { 10, 4, 30, 8, 25, 17, 50 };

            int largest = numbers[0]; 

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }

            Console.WriteLine("The largest element in the array is: " + largest);*/


            //Write a C# program that counts the number of even and odd elements in an integer array using a loop and if-else statements.

            /*int[] numbers = { 2, 7, 14, 9, 22, 6, 11, 18, 3, 4 };
                         int evenCount = 0;
                         int oddCount = 0;

                         foreach (int number in numbers)
                         {
                             if (number % 2 == 0)
                             {
                                 evenCount++;
                             }
                             else
                             {
                                 oddCount++;
                             }
                         }

                         Console.WriteLine("Number of even elements: " + evenCount);
                         Console.WriteLine("Number of odd elements: " + oddCount);*/

            //Implement a C# program that reverses the elements of an integer array using a loop.

            /*int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Console.WriteLine("Original array:");
                PrintArray(numbers);

                ReverseArray(numbers);

                Console.WriteLine("Reversed array:");
                PrintArray(numbers);
        

            static void ReverseArray(int[] arr)
            {
                int left = 0;
                int right = arr.Length - 1;

                while (left < right)
                {
                    // Swap elements at left and right indices
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    // Move indices towards each other
                    left++;
                    right--;
                }
            }

            static void PrintArray(int[] arr)
            {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            }
            */


            //Create a C# program that multiplies each element in an integer array by a specified factor using a loop.


            /*int[] numbers = { 2, 4, 6, 8, 10 };
                int factor = 3;

                Console.WriteLine("Original array:");
                PrintArray(numbers);

                MultiplyArray(numbers, factor);

                Console.WriteLine($"Array after multiplying by {factor}:");
                PrintArray(numbers);
        

            static void MultiplyArray(int[] arr, int factor)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] *= factor;
                }
            }

            static void PrintArray(int[] arr)
            {
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }*/


            //Write a C# program that searches for a specific value in an integer array using a loop and returns its index if found.

            /*int[] numbers = { 10, 20, 30, 40, 50 };
                int targetValue = 30;

                int index = SearchArray(numbers, targetValue);

                if (index != -1)
                {
                    Console.WriteLine($"The target value {targetValue} was found at index {index}.");
                }
                else
                {
                    Console.WriteLine($"The target value {targetValue} was not found in the array.");
                }
        

            static int SearchArray(int[] arr, int target)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == target)
                    {
                        return i; 
                    }
                }
                return -1;
            }*/


            //Develop a C# program that finds the second smallest element in an integer array using loops and sorting techniques.

            /*int[] numbers = { 5, 8, 2, 10, 3, 7, 1, 6, 9, 4 };

               int secondSmallest = FindSecondSmallest(numbers);

               Console.WriteLine($"The second smallest element in the array is: {secondSmallest}");


           static int FindSecondSmallest(int[] arr)
           {
               if (arr.Length < 2)
               {
                   throw new ArgumentException("Array must have at least two elements.");
               }

               int smallest = Math.Min(arr[0], arr[1]);
               int secondSmallest = Math.Max(arr[0], arr[1]);

               for (int i = 2; i < arr.Length; i++)
               {
                   if (arr[i] < smallest)
                   {
                       secondSmallest = smallest;
                       smallest = arr[i];
                   }
                   else if (arr[i] < secondSmallest && arr[i] != smallest)
                   {
                       secondSmallest = arr[i];
                   }
               }

               return secondSmallest;
           }*/


            //Create a C# program that removes all duplicates from an integer array using loops and additional data structures.


            /*int[] numbers = { 2, 5, 8, 2, 9, 5, 10, 8, 7 };

                int[] uniqueNumbers = RemoveDuplicates(numbers);

                Console.WriteLine("Original array:");
                PrintArray(numbers);

                Console.WriteLine("Array after removing duplicates:");
                PrintArray(uniqueNumbers);
            

            static int[] RemoveDuplicates(int[] arr)
            {
                HashSet<int> seenNumbers = new HashSet<int>();
                List<int> uniqueNumbersList = new List<int>();

                foreach (int num in arr)
                {
                    if (!seenNumbers.Contains(num))
                    {
                        seenNumbers.Add(num);
                        uniqueNumbersList.Add(num);
                    }
                }

                return uniqueNumbersList.ToArray();
            }

            static void PrintArray(int[] arr)
            {
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }*/


            //Write a C# program that finds the common elements between two integer arrays using loops.

             /*int[] array1 = { 2, 5, 8, 10, 12 };
                int[] array2 = { 5, 7, 8, 12, 15 };

                int[] commonElements = FindCommonElements(array1, array2);

                Console.WriteLine("Common elements:");
                PrintArray(commonElements);
            

            static int[] FindCommonElements(int[] arr1, int[] arr2)
            {
                // Create a HashSet to store elements of the first array
                HashSet<int> set = new HashSet<int>(arr1);

                List<int> commonElementsList = new List<int>();

                foreach (int num in arr2)
                {
                    if (set.Contains(num))
                    {
                        commonElementsList.Add(num);
                    }
                }

                return commonElementsList.ToArray();
            }

            static void PrintArray(int[] arr)
            {
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }*/
        }
    }
}