using Algorithms_DataStruct_Lib;
using System;
using System.Diagnostics;
using System.Linq;

namespace Algs
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestTimeComplexityOnKints();
            //AlgsPraticeTest.TestBubbleSort();
            //AlgsPraticeTest.TestSelectionSort();
            //AlgsPraticeTest.TestInsertionSort();
            //AlgsPraticeTest.TestShellSort();
            AlgsPraticeTest.TestMergeSortWithLogs();
            //AlgsPraticeTest.TestAll();
        }

        // самые первые занятия, когда показывался подсчет времени
        private static void TestTimeComplexityOnKints()
        {
            /// 1 => 160ms 
            /// 2 => 1.35s
            /// 4 => 10.26s
            /// 8 => 1m20s
            ///
            var ints = In.ReadInts("4Kints.txt").ToArray(); 

            var watch = new Stopwatch();
            watch.Start();

            var triplets = ThreeSum.Count(ints);

            watch.Stop();

            Console.WriteLine($"The number of \"zero-triplets\" : {triplets}");
            Console.WriteLine($"Time taken: {watch.Elapsed:g}");


            Console.Read();
        }


    }
}
