using System.Diagnostics;

namespace JeanPaul_SortingAlgorithms
{
    internal class Program
    {
        /* While some sorting algorithms are less performant on large datasets 
           because they require many comparisons and swaps,
           others become more efficient thanks to the divide-and-conquer paradigm or the partitioning strategy
           which decomposes a problem into simpler instances of the same problem and then combines the solutions. */

        static void DisplayRuntime(Stopwatch stopwatch)
        {
            TimeSpan ts = stopwatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("Time Taken: " + elapsedTime);

        }

        static void DisplayRuntime(Stopwatch stopwatch, string AlgorithmName)
        {
            TimeSpan ts = stopwatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("*************************** RESULTS *****************************");
            Console.WriteLine();
            Console.WriteLine(" Algorithm: " + AlgorithmName + "   Time Taken: " + elapsedTime);
            Console.WriteLine();
            Console.WriteLine("*****************************************************************");
        }

        static int[] GenerateRandomArray(int length, int minValue, int maxValue)
        {
            Random rand = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(minValue, maxValue);
            }

            return array;
        }



        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            string AlgoName;
            char Choice;

            Console.WriteLine("Generating array...");
            // usage 100 thousand values
            stopwatch.Start();
            int[] largeArr = GenerateRandomArray(100000, 1, 100);
            stopwatch.Stop();
            DisplayRuntime(stopwatch);

            Console.WriteLine("Press any key to display the generated array...");
            Console.ReadKey(true);

            for (int i = 0; i < largeArr.Length; i++)
            {
                Console.Write(largeArr[i] + " ");

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("press any key to start sorting...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine();
            Console.WriteLine("  Q. Quick Sort      M. Merge Sort     B. Bubble Sort    I. Insertion Sort");
            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine();
            Console.Write("your choice: ");
            Choice = char.Parse(Console.ReadLine().ToLower());
            Console.WriteLine();


            switch (Choice)
            {
                case 'q':
                    Console.WriteLine();
                    AlgoName = "Quick Sort";
                    Console.WriteLine("starting sorting...");
                    Console.WriteLine();
                    stopwatch.Start();
                    int[] SortedArray = Sort.QuickSortAlgorithm(largeArr, 0, largeArr.Length - 1);
                    stopwatch.Stop();
                    DisplayRuntime(stopwatch, AlgoName);

                    Console.WriteLine("Press any key to display the sorted array");
                    Console.ReadKey(true);
                    Console.WriteLine();

                    for (int i = 0; i < SortedArray.Length; i++)
                    {
                        Console.Write(SortedArray[i] + " ");
                    }
                    break;

                case 'm':
                    Console.WriteLine();
                    AlgoName = "Merge Sort";
                    Console.WriteLine("starting sorting...");
                    Console.WriteLine();
                    stopwatch.Start();
                    SortedArray = Sort.MergeSortAlgorithm(largeArr, 0, largeArr.Length - 1);
                    stopwatch.Stop();
                    DisplayRuntime(stopwatch, AlgoName);

                    Console.WriteLine("Press any key to display the sorted array");
                    Console.ReadKey(true);
                    Console.WriteLine();

                    for (int i = 0; i < SortedArray.Length; i++)
                    {
                        Console.Write(SortedArray[i] + " ");
                    }
                    break;

                case 'b':
                    Console.WriteLine();
                    AlgoName = "Bubble Sort";
                    Console.WriteLine("starting sorting...");
                    Console.WriteLine();
                    stopwatch.Start();
                    SortedArray = Sort.BubbleSort(largeArr, largeArr.Length);
                    stopwatch.Stop();
                    DisplayRuntime(stopwatch, AlgoName);

                    Console.WriteLine("Press any key to display the sorted array");
                    Console.ReadKey(true);
                    Console.WriteLine();

                    for (int i = 0; i < SortedArray.Length; i++)
                    {
                        Console.Write(SortedArray[i] + " ");
                    }
                    break;

                case 'i':
                    Console.WriteLine();
                    AlgoName = "Insertion Sort";
                    Console.WriteLine("starting sorting...");
                    Console.WriteLine();
                    stopwatch.Start();
                    SortedArray = Sort.Insertinsort(largeArr);
                    stopwatch.Stop();
                    DisplayRuntime(stopwatch, AlgoName);

                    Console.WriteLine("Press any key to display the sorted array");
                    Console.ReadKey(true);
                    Console.WriteLine();

                    for (int i = 0; i < SortedArray.Length; i++)
                    {
                        Console.Write(SortedArray[i] + " ");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }

        }
    }
}