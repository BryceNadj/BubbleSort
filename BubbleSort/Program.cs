// Bubble sort made by Bryce Nadjmejkuti 
// 27/03/2022

using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iterationCountArray = new int[500];
            float average = 0;

            for (int i = 0; i < iterationCountArray.Length; i++)
           {
                iterationCountArray[i] = BubbleSort(GenerateRandomArray());
                average += iterationCountArray[i];
            }

            Console.WriteLine("Average: " + average / iterationCountArray.Length);
        }
        
        private static int[] GenerateRandomArray()
        {
            int[] unsortedArray = new int[50];
            Random randInt = new Random();

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = randInt.Next(0, 100);
            }

            return unsortedArray;
        }

        private static int BubbleSort(int[] unsortedArray)
        {
            int iterationCount = 0;
            bool hasIterated = true;
            while (hasIterated)
            {
                hasIterated = false;
                for (int i = 0; i < unsortedArray.Length; i++)
                {
                    if (i == unsortedArray.Length - 1) continue; // Reached end of array so restart
                    if (unsortedArray[i] > unsortedArray[i + 1])
                    {
                        int temp = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[i + 1];
                        unsortedArray[i + 1] = temp;
                        hasIterated = true;
                        iterationCount++;
                    }
                }
            }
            return iterationCount;
        }

        private static void PrintArray(int[] unsortedArray)
        {
            string arr = "";
            for (int i = 0; i < 50; i++)
            {
                arr += unsortedArray[i] + ", ";
            }
            Console.WriteLine(arr);
        }
    }
}
