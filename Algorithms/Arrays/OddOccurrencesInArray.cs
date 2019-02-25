using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Arrays
{
    public static class OddOccurrencesInArray
    {
        public static int FindOddNumber(int[] array)
        {
            if (array.Length == 1)
                return array[0];

            var hashSet = new HashSet<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (hashSet.Contains(array[i]))
                    hashSet.Remove(array[i]);
                else hashSet.Add(array[i]);
            }

            return hashSet.Any() ? hashSet.First() : 0;
        }
    }
}