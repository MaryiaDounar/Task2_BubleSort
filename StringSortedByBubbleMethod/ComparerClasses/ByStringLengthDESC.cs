using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortedByBubbleMethod.ComparerClasses
{
    public class ByStringLengthDESC : IComparer<string>
    {
         int IComparer<string>.Compare(string s1, string s2)
        {
            return s2.Length - s1.Length;
        }
    }
}
