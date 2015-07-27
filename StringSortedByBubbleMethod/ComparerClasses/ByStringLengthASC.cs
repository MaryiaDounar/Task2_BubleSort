using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortedByBubbleMethod.ComparerClasses
{
    public class ByStringLengthASC : IComparer<string>
    {
        public int Compare(string s1, string s2)
        {
            return s1.Length - s2.Length;
        }
    }
}
