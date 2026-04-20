namespace Problem_Solving.Problems.ArraysAndLinkedList
{
    public static class TwoFurthestHousesWithDifferentColors
    {
        public static int MaxDistance(int[] colors)
        {
            int n = colors.Length;
            int maxDistance = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                if (colors[i] != colors[0])
                {
                    maxDistance = Math.Max(maxDistance, i);
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (colors[i] != colors[n - 1])
                {
                    maxDistance = Math.Max(maxDistance, n - 1 - i);
                    break;
                }
            }

            return maxDistance;
        }
        public static int Sum(int[] arr, int index)
        {
            if(index == arr.Length)
                return 0;

            return arr[index] + Sum(arr, index + 1);
        }
    }
}
