using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortedByBubbleMethod
{
    public class Sort
    {
       public static string[] BubbleSort(string[] array, IComparer<string> comparer)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (comparer.Compare(array[j], array[j+1]) > 0)
                    {
                       Swap(array, j, j+1);
                    }
                }
            }
            return array;
        }

        private static string[] Swap(string[] array, int i, int j)
        {
             string temp = string.Empty;
             temp = array[i];
             array[i] = array[j];
             array[j] = temp;
             return array;
        }

       
    }
}
