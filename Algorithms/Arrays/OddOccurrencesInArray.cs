namespace Algorithms.Arrays
{
    public static class OddOccurrencesInArray
    {
        public static int FindOddNumber(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                int nextPairIndex = i + 2;
                if (nextPairIndex < length)
                    if (array[i] != array[nextPairIndex])
                        return array[nextPairIndex];
            }

            return 0;
        }
    }
}