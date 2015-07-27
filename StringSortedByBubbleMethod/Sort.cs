using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortedByBubbleMethod
{
    public class Sort
    {
       public static void BubbleSort(string[] array, IComparer<string> comparer)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (comparer.Compare(array[j], array[j+1]) > 0)
                    {
                       Swap(ref array[j],ref array[j+1]);
                    }
                }
            }
        }

        private static void Swap(ref string s1,ref string s2)
        {
             string temp = string.Empty;
             temp = s1;
             s1 = s2;
             s2 = temp;
        }

       
    }
}
