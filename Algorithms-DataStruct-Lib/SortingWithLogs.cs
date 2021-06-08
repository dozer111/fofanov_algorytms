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

        public static void MergeSort(int[] array)
        {
            int[] auxilaryArray = new int[array.Length];
            Console.WriteLine($"\telements => {array.Length}");


            int count = 1;
            Sort(0, array.Length - 1);


            /* верхняя/нижняя граница */
            void Sort(int lowerBoundary, int higherBoundary)
            {
                Console.WriteLine($"\tSort[{count}],low[{lowerBoundary}],high[{higherBoundary}]");
                count++;


                if (higherBoundary <= lowerBoundary)
                {
                    Console.WriteLine("1 items now. Return");
                    return;
                }
                    

                // правые подмассивы будут больше левых в случае невозможности разделить их на ровные части
                int midIndex = (higherBoundary + lowerBoundary) / 2;

                // начинаем разделение массивов на сиблинги
                Console.WriteLine($"Делим ЛЕВУЮ часть");
                Sort(lowerBoundary, midIndex);
                Console.WriteLine($"Делим ПРАВУЮ часть");
                Sort(midIndex + 1, higherBoundary);


                Console.WriteLine("Sort finished, start merge");

                Merge(lowerBoundary, midIndex, higherBoundary);
            }

            void Merge(int low, int mid, int high)
            {
                Console.WriteLine($"low[{low}],mid[{mid}],high[{high}]");
                if (array[mid] <= array[mid + 1])
                {
                    Console.WriteLine("Обе половины отсортированы верно. RETURN");
                    return;
                }
                    


                // i - первый елем левого массива
                // j - первый елем правого массива
                int i = low;
                int j = mid + 1;

                Array.Copy(array, low, auxilaryArray, low, high - low + 1);

                for (int k = low; k <= high; k++)
                {
                    if (i > mid)
                    {
                        array[k] = auxilaryArray[j++];
                        Console.WriteLine($"i > mid,елементов много, перебираем правую часть i[{i}]mid[{mid}]");
                    }
                    else if (j > high)
                    {
                        array[k] = auxilaryArray[i++];
                        Console.WriteLine($"j > high по идее, елементов мало, срабатывает ближе к концу на малых массивах");
                    }

                    else if (auxilaryArray[j] < auxilaryArray[i])
                    {
                        array[k] = auxilaryArray[j++];
                        Console.WriteLine($"следующий меньше предыдущего, должно сработать сначала");
                    }
                    else {
                        array[k] = auxilaryArray[i++];
                        Console.WriteLine($"предыдущий меньше следующего, должно сработать сначала");
                    } 
                }


            }


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
