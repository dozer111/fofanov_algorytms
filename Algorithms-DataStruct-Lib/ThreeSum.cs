using System;

namespace Algorithms_DataStruct_Lib
{

    public class ThreeSum
    {
        public static int Count(int[] a)
        {
            int n = a.Length;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int ii = i + 1; ii < n; ii++)
                {
                    for (int iii = ii + 1; iii < n; iii++)
                    {
                        if (a[i] + a[ii] + a[iii] == 0)
                        {
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }
    }
}
