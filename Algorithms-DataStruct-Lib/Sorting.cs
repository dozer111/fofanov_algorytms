using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Algorithms_DataStruct_Lib
{
    // сортировка массива по возрастанию
    public class Sorting
    {

        public static void MergeSort(int[] array)
        {
            int[] auxilaryArray = new int[array.Length];

            Sort(0, array.Length - 1);

            /* верхняя/нижняя граница */
            void Sort(int lowerBoundary,int higherBoundary)
            {
                if (higherBoundary <= lowerBoundary)
                    return;

                // правые подмассивы будут больше левых в случае невозможности разделить их на ровные части
                int midIndex = (higherBoundary + lowerBoundary) / 2;

                // начинаем разделение массивов на сиблинги
                Sort(lowerBoundary, midIndex);
                Sort(midIndex+1, higherBoundary);

                Merge(lowerBoundary, midIndex, higherBoundary);
            }

            void Merge(int low,int mid,int high) {

                if (array[mid] <= array[mid + 1])
                    return;


                // i - первый елем левого массива
                // j - первый елем правого массива
                int i = low;
                int j = mid + 1;

                Array.Copy(array, low, auxilaryArray, low, high - low + 1);

                for(int k = low;k <= high;k++)
                {
                    if (i > mid) array[k] = auxilaryArray[j++];
                    else if (j > high) array[k] = auxilaryArray[i++];
                    else if (auxilaryArray[j] < auxilaryArray[i]) array[k] = auxilaryArray[j++];
                    else array[k] = auxilaryArray[i++];
                }


            }


        }









        public static void ShellSort(int[] array)
        {
            // 1 определяемся с gap
            int gap = 1;
            while (gap < array.Length / 3)
            {
                gap = 3 * gap + 1;
            }

            // PREorder + sorting(если gap == 1)
            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        Swap(array, j, j - gap);
                    }
                }
                gap /= 3;
            }
        }

        // Проходим по массиву, изначально в голове формируется отсортированный массив с 1 елем
        // Поставили wall на alreadySortedArray.Length
        // Взяли значение wall, это текущее неотсортированное значение currUnsorted
        // Если оно больше предыдущего - значит записываем в этот же индекс это же значение, и не заходим в цикл
        // Если меньше - заходим в цикл, и перезаписываем елементы, пока массив не отсортируется
        // 
        // in-place
        // стабилен
        // n^2
        // 
        // Самая большая проблема - возможно большое к-во оперций сдвига
        // Главный плюс перед selectionSort и bubbleSort - в идеале сложность может быть линейной
        public static void InsertionSort(int[] array)
        {
            for (int wall = 1; wall < array.Length; wall++)
            {
                int currentUnsorted = array[wall];

                // индекс, в который мы в конечтном итоге вставим неотсортированное значение
                int i = 0;
                for (i = wall; i > 0 && array[i - 1] > currentUnsorted; i--)
                {
                    array[i] = array[i - 1];
                }

                array[i] = currentUnsorted;
            }
        }


        // Проходим по массиву, находим максимальное число 
        // меняем их местами с текущим хвостом
        // 
        // in-place
        // НЕ стабилен
        // n^2
        // 
        public static void SelectionSort(int[] array)
        {
            for (int wall = array.Length - 1; wall > 0; wall--)
            {
                int maxValueIndex = 0;
                for (int i = 1; i <= wall; i++)
                {
                    if (array[i] > array[maxValueIndex])
                    {
                        maxValueIndex = i;
                    }
                }

                Swap(array, wall, maxValueIndex);

            }
        }

        // Берем 2 соседних элемента
        // если левый больше правого - меняем местами
        //
        // in-place
        // стабилет
        // n^2
        public static void BubbleSort(int[] array)
        {
            for (int wall = array.Length - 1; wall > 0; wall--)
            {
                for (int i = 0; i < wall; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        // меняет местами 2 элемента массива
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
