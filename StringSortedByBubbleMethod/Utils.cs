using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortedByBubbleMethod
{
    public class Utils
    {
        private static string GenerateRandomString(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random((Guid.NewGuid().GetHashCode()));
            string result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        public static string[] GenerateStringArray(int arraySize, int minStringSize, int maxStringSize)
        {
            string[] array = new string[arraySize];
            Random random = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Utils.GenerateRandomString(random.Next(minStringSize, maxStringSize));
            }
            return array;
        }
    }
}
