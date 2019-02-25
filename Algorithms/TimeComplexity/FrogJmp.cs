namespace Algorithms.TimeComplexity
{
    public static class FrogJmp
    {
        public static int GetNumber(int x, int y, int d)
        {
            if (x == y)
                return 0;

            return ((y - x) + (d - 1)) / d;
        }
    }
}