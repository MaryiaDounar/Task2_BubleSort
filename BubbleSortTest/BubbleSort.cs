using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using StringSortedByBubbleMethod.ComparerClasses;
using StringSortedByBubbleMethod;

namespace BubbleSortTest
{
    [TestFixture]
    public class BubbleSort
    {
        public const int ARRAY_SIZE = 10;
        public const int MIN_STRING_LENGTH = 5;
        public const int MAX_STRING_LENGTH = 11;
        public const string SUBSTRING = "H";

        public IEnumerable<TestCaseData> ComparerTestData
        {
            get
            {
                yield return new TestCaseData(new ByAlphabetOrderASC());
                yield return new TestCaseData(new ByAlphabetOrderDESC());
                yield return new TestCaseData(new ByCharacterCountASC { substring = SUBSTRING });
                yield return new TestCaseData(new ByCharacterCountDESC { substring = SUBSTRING });
                yield return new TestCaseData(new ByStringLengthASC());
                yield return new TestCaseData(new ByStringLengthDESC());
            }
        }
        [Test, TestCaseSource("ComparerTestData")]
        public void BubbleSortTest(IComparer<string> comparer)
        {
            string[] array = Utils.GenerateStringArray(ARRAY_SIZE, MIN_STRING_LENGTH, MAX_STRING_LENGTH);
            string[] sortedArray = Sort.BubbleSort(array, comparer);
            Array.Sort(array, comparer);
            Assert.That(array, Is.EqualTo(sortedArray));
        }

    }
}
