using System.Linq;

namespace Algorithms.Arrays
{
    public static class CyclicRotation
    {
        public static int[] Rotate(int[] array, int n)
        {
            if (n == array.Length)
                return array;

            if (!array.Any(el => el != 0))
                return array;

            int[] rotated = new int[array.Length];
            array.CopyTo(rotated, 0);

            for (int i = 0; i < n; i++)
            {
                rotated = Rotate(rotated);
            }

            return rotated;
        }

        private static int[] Rotate(int[] array)
        {
            int[] rotated = new int[array.Length];
            rotated[0] = array[array.Length - 1];

            for (int i = 1; i < array.Length; i++)
            {
                rotated[i] = array[i - 1];
            }

            return rotated;
        }
    }
}