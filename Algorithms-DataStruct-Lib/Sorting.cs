using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStruct_Lib
{
    public class Sorting
    {

        public static void SelectionSort(int[] array)
        {
            for(int wall = array.Length -1;wall > 0;wall--)
            {
                int maxValueIndex = 0;
                for(int i = 1;i <= wall;i++)
                {
                    if(array[i] > array[maxValueIndex])
                    {
                        maxValueIndex = i;
                    }
                }

                Swap(array, wall, maxValueIndex);

            }
        }






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
