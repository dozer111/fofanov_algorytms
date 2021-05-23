using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStruct_Lib
{
    // полный дубль Sorting, только здесь болье данные, и можно посмотреть сколько раз выполнялась та, или иная операция
    public class SortingWithLogs
    {
        public static void ShellSort(int[] array)
        {
           
            int gap = 1;
            while (gap < array.Length / 3)
            {
                gap = 3 * gap + 1;
            }

        
            Console.WriteLine($"\telements => {array.Length}");
            int swapsCount = 0;
            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        swapsCount++;
                        Swap(array, j, j - gap);
                    }
                }
                gap /= 3;
            }


            Console.WriteLine($"\tswapsCount => {swapsCount}");
        }

        public static void InsertionSort(int[] array)
        {
            int swapsCount = 0;
            Console.WriteLine($"\telements => {array.Length}");
            for (int wall = 1; wall < array.Length; wall++)
            {
                int currentUnsorted = array[wall];

                
                
                int i = 0;
                for (i = wall; i > 0 && array[i - 1] > currentUnsorted; i--)
                {
                    swapsCount++;
                    array[i] = array[i - 1];
                }

                array[i] = currentUnsorted;
            }

            Console.WriteLine($"\tswapsCount => {swapsCount}");
        }



        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }

            int tempVal = array[i];
            array[i] = array[j];
            array[j] = tempVal;
        }
    }
}
