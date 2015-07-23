using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortedByBubbleMethod.ComparerClasses
{
    public class ByCharacterCountDESC : IComparer<string>
    {
        public string substring { get; set; }

        int IComparer<string>.Compare(string s1, string s2)
        {
            return SymbolCount(s2, substring.ToUpper()) - SymbolCount(s1, substring.ToUpper());
        }

        private static int SymbolCount(string searchString, string subString)
        {
            return searchString.Split(new string[] { subString }, StringSplitOptions.None).Count() - 1;
        }
    }
}
