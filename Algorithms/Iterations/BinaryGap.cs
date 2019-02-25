using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Iterations
{
    public static class BinaryGap
    {
        public static List<int> FindBinaryGaps(int n)
        {
            var binaryString = Convert.ToString(n, 2);

            int startIndex = binaryString.IndexOf('1');

            int currentGap = 0;

            List<int> gaps = new List<int>();
            for (int i = startIndex + 1; i < binaryString.Length; i++)
            {
                if (binaryString[i] == '0')
                    currentGap++;
                if (binaryString[i] == '1' && currentGap != 0)
                {
                    gaps.Add(currentGap);
                    currentGap = 0;
                }
            }

            return gaps.Any() ? gaps : new List<int>(0);
        }
    }
}