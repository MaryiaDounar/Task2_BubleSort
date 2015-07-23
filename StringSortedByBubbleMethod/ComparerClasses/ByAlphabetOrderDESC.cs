using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortedByBubbleMethod.ComparerClasses
{
    public class ByAlphabetOrderDESC : IComparer<string>
    {
    int IComparer<string>.Compare(string s1, string s2)
        {
            return s2.CompareTo(s1);
        }
    }
}
