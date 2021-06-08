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
        
        // малые данные для быстрого теста
        private static int[][] Data1()
        {
            int[][] samples = new int[7][];



            // на маленьких данных невозможно увидеть gap в работе
            samples[0] = new int[1] { 147 };
            samples[1] = new int[2] { 51, 97 };
            samples[2] = new int[3] { 107, 228, 187 };
            samples[3] = new int[4] { 90, 126, 252, 140 };
            samples[4] = new int[5] { 37, 163, 240, 83, 117 };
            samples[5] = new int[6] { 160, 220, 18, 24, 56, 252 };
            samples[6] = new int[7] { 91, 183, 41, 89, 137, 160, 98 };


            return samples;
        }

        // данные для теста к-ва итераций
        private static int[][] Data2()
        {
            int[][] samples = new int[6][];



            // на маленьких данных невозможно увидеть gap в работе
            samples[0] = new int[5] { 672, 533, 920, 16, 176 };
            samples[1] = new int[10] { 606, 298, 493, 11, 565, 997, 343, 345, 932, 32 };
            samples[2] = new int[20] { 517, 365, 865, 154, 915, 453, 259, 865, 259, 892, 624, 708, 574, 911, 601, 577, 103, 203, 694, 715 };
            samples[3] = new int[30] { 355, 430, 582, 557, 887, 193, 659, 827, 877, 239, 733, 966, 565, 593, 945, 893, 983, 146, 349, 508, 216, 114, 405, 964, 552, 11, 201, 233, 218, 792 };
            samples[4] = new int[40] { 135, 134, 180, 918, 757, 649, 699, 139, 303, 380, 68, 680, 347, 714, 289, 589, 169, 876, 635, 686, 299, 6, 346, 757, 431, 245, 954, 946, 563, 801, 748, 162, 588, 502, 295, 536, 817, 907, 605, 719 };
            samples[5] = new int[50] { 966, 830, 214, 984, 409, 11, 227, 460, 469, 973, 804, 818, 888, 429, 459, 232, 627, 495, 721, 336, 103, 438, 541, 687, 936, 938, 231, 746, 842, 55, 877, 230, 158, 352, 559, 600, 73, 967, 258, 787, 385, 422, 22, 234, 669, 932, 193, 905, 119, 681 };


            return samples;
        }


        // данные для теста 1 прохода алгоритма
        private static int[][] Data3()
        {
            int[][] samples = new int[1][];



            // на маленьких данных невозможно увидеть gap в работе
            //samples[0] = new int[5] { 672, 533, 920, 16, 176 };
            //samples[0] = new int[10] { 606, 298, 493, 11, 565, 997, 343, 345, 932, 32 };
            samples[0] = new int[10] { 60, 29, 49, 11, 56, 99, 34, 34, 93, 3};
            //samples[0] = new int[20] { 517, 365, 865, 154, 915, 453, 259, 865, 259, 892, 624, 708, 574, 911, 601, 577, 103, 203, 694, 715 };
            //samples[0] = new int[30] { 355, 430, 582, 557, 887, 193, 659, 827, 877, 239, 733, 966, 565, 593, 945, 893, 983, 146, 349, 508, 216, 114, 405, 964, 552, 11, 201, 233, 218, 792 };
            //samples[0] = new int[40] { 135, 134, 180, 918, 757, 649, 699, 139, 303, 380, 68, 680, 347, 714, 289, 589, 169, 876, 635, 686, 299, 6, 346, 757, 431, 245, 954, 946, 563, 801, 748, 162, 588, 502, 295, 536, 817, 907, 605, 719 };
            //samples[0] = new int[50] { 966, 830, 214, 984, 409, 11, 227, 460, 469, 973, 804, 818, 888, 429, 459, 232, 627, 495, 721, 336, 103, 438, 541, 687, 936, 938, 231, 746, 842, 55, 877, 230, 158, 352, 559, 600, 73, 967, 258, 787, 385, 422, 22, 234, 669, 932, 193, 905, 119, 681 };


            return samples;
        }

        // общий метод, который будет выводить только данные о том, сколько разные алгоритмы сделали Swap
        public static void TestAll()
        {
            TestShellSortWithLogs();
            TestInsertionSortWithLogs();
        }

        public static void TestShellSortWithLogs()
        {
            int[][] data = Data2();
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"\nShellSort: {i + 1}");

                SortingWithLogs.ShellSort(data[i]);
            }
        }

        public static void TestMergeSortWithLogs()
        {
            int[][] data = Data3();
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"\nMergeSort: {i + 1}");

                SortingWithLogs.MergeSort(data[i]);
            }
        }


        public static void TestInsertionSortWithLogs()
        {
            int[][] data = Data2();
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"\nInsertionSort: {i + 1}");

                SortingWithLogs.InsertionSort(data[i]);
            }
        }



        public static void TestShellSort()
        {
            int[][] samples = new int[7][];
            


            // на маленьких данных невозможно увидеть gap в работе
            samples[0] = new int[1] { 147 };
            samples[1] = new int[2] { 51, 97 };
            samples[2] = new int[3] { 107, 228, 187 };
            samples[3] = new int[4] { 90, 126, 252, 140 };
            samples[4] = new int[5] { 37, 163, 240, 83, 117 };
            samples[5] = new int[6] { 160, 220, 18, 24, 56, 252 };
            samples[6] = new int[7] { 91, 183, 41, 89, 137, 160, 98 };


            for (int i = 0; i < samples.Length; i++)
            {
                Console.WriteLine($"\nShellSort: {i + 1}");
                Sorting.ShellSort(samples[i]);
                foreach (var el in samples[i])
                {
                    Console.Write($"{el} ");
                }

            }

        }




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

        public static void TestInsertionSort()
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
                Console.WriteLine($"\nInsertionSort: {i + 1}");
                Sorting.InsertionSort(samples[i]);
                foreach (var el in samples[i])
                {
                    Console.Write($"{el} ");
                }

            }

        }

        public static void TestSelectionSort()
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
                Console.WriteLine($"\nSelectionSort: {i+1}");
                Sorting.SelectionSort(samples[i]);
                foreach (var el in samples[i])
                {
                    Console.Write($"{el} ");
                }

            }

        }

    }

    
}
