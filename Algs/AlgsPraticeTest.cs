using Algorithms_DataStruct_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs
{
    public class AlgsPraticeTest
    {
        public static void TestBubbleSort()
        {
            int[][] samples = new int[7][];

            samples[0] = new int[1] { 147 };
            samples[1] = new int[2] { 51, 97 };
            samples[2] = new int[3] { 107, 228, 187 };
            samples[3] = new int[4] { 90, 126, 252, 140 };
            samples[4] = new int[5] { 37, 163, 240, 83, 117 };
            samples[5] = new int[6] { 160, 220, 18, 24, 56, 252 };
            samples[6] = new int[7] { 91, 183, 41, 89, 137, 160, 98 };


            for (int i = 0; i < samples.Length; i++)
            {
                Console.WriteLine($"\nBubbleSort: {i}");
                Sorting.BubbleSort(samples[i]);
                foreach (var el in samples[i])
                {
                    Console.Write($"{el} ");
                }

            }

        }
    }

    
}
