using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2Project2
{
    public class AlgoritmsSearch
    {
        //log2N
        public static int BinarySearch(int[] array, int value)
        {
            int indexStart = 0;
            int indexEnd = array.Length - 1;

            int retIndex = -1;

            while (indexStart <= indexEnd)
            {
                int middle = (indexStart + indexEnd) / 2;

                if (value > array[middle])
                    indexStart = middle + 1;
                else if (value < array[middle])
                    indexEnd = middle - 1;
                else
                {
                    retIndex = middle;
                    break;
                }
            }

            return retIndex;
        }
    }
}
