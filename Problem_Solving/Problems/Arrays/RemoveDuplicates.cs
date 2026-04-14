namespace Problem_Solving.Problems.Arrays
{
    public static class RemoveDuplicates
    {
        public static int RemoveDuplicateFunction(int[] arr)
        {
            int k = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    arr[k] = arr[i];
                    k++;
                }
            }
            return k;
        }
    }
}
